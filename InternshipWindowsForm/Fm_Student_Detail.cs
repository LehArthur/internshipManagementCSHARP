using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace InternshipWindowsForm
{
    public partial class Fm_Student_Detail : Form
    {
        public ModeleEntity Me;
        public Fm_Student_Detail(ModeleEntity entity)
        {
            InitializeComponent();
            Me = entity;
            personBindingSource.DataSource = Me.person.ToList();
        }
        public Fm_Student_Detail(ModeleEntity entity, person selectedPerson)
            : this(entity)
        {
            personBindingSource.Position = personBindingSource.List.IndexOf(selectedPerson);
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (personBindingSource.Current != null)
            {
                MessageBox.Show("Sauvegardé", "Sauvegardé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                personBindingSource.EndEdit();
                Me.SaveChanges();
            }
        }

        private void personBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (personBindingSource.Current != null)
            {
                Me.SaveChanges();
            }
        }

        //Encoding md5
        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder pass = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                pass.Append(hash[i].ToString("X2"));
            }
            return pass.ToString().ToLower();
        }

        public string idPerson(string ID)
        {
            var password = ID;
            return password;
        }

        //Insert new row student
        private void button1_Click(object sender, EventArgs e)
        {
            if (personBindingSource.Current != null)
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString =
                    "server=37.187.37.245;user id=internship;password=abcd4ABCD;persistsecurityinfo=True;database=internship_management";
                //Add person 
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO person VALUES('', 1, '"+this.firstNameTextBox.Text+"','"+this.lastNameTextBox.Text+"','"+this.loginTextBox.Text+"','"+CalculateMD5Hash(this.passwordTextBox.Text)+"','"+this.mailTextBox.Text+"','"+this.telephoneTextBox.Text+"')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Test
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Reussi", "Ajout", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    //Closing after deleting
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pas de connection mon precieux true error", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                conn.Close();
            }
        }

        //Delete row in database
        private void Butt_Delete_Click(object sender, EventArgs e)
        {
            //Delete item
            if (personBindingSource.Current != null)
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString =
                    "server=37.187.37.245;user id=internship;password=abcd4ABCD;persistsecurityinfo=True;database=internship_management";
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM person WHERE id = '" + idTextBox.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Test
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Reussi", "noConnectionDB", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    //Closing after adding
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pas de connection mon precieux true error", "noConnectionDB", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                conn.Close();
            }
            //
        }
        //

        private void Fm_Student_Detail_Load(object sender, EventArgs e)
        {

        }
    }
}

