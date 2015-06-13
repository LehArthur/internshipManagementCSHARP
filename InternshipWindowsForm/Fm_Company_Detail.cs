using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InternshipWindowsForm
{
    public partial class Fm_Company_Detail : Form
    {
        //Modele declaration
        public ModeleEntity Me;

        //Data inistialisation
        public Fm_Company_Detail(ModeleEntity entity)
        {
            Me = entity;
            InitializeComponent();
            companyBindingSource.DataSource = Me.company.ToList();
        }

        //Show detail from row selected
        public Fm_Company_Detail(ModeleEntity entity, company selectedCompany)
            : this(entity)
        {
            companyBindingSource.Position = companyBindingSource.List.IndexOf(selectedCompany);
        }

        //Save from binding navigator
        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (companyBindingSource.Current != null)
            {
                //Save data 
                companyBindingSource.EndEdit();
                Me.SaveChanges();
                
                MessageBox.Show("Sauvegardé", "Sauvegardé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Update
                var company = new Fm_Company(Me);
                company.UpdateCompany();
            }
        }

        //Add new
        private void Butt_add_Click(object sender, EventArgs e)
        {
            if (companyBindingSource.Current != null)
            {
                //Sql connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString =
                    "server=37.187.37.245;user id=internship;password=abcd4ABCD;persistsecurityinfo=True;database=internship_management";
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO company VALUES('','" + this.nameTextBox.Text + "','" + this.descriptionTextBox.Text + "','" + this.address1TextBox.Text + "','" + this.address2TextBox.Text + "','" + this.townTextBox.Text + "','" + this.zipCodeTextBox.Text + "', '" + this.telephoneTextBox.Text + "', '" + this.mailTextBox.Text + "', '" + this.validateCheckBox.Checked + "')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Test
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Reussi", "Ajout", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    //Closing after adding
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

        //Delete button
        private void Butt_delete_Click(object sender, EventArgs e)
        {
            //Delete item
            if (companyBindingSource.Current != null)
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString =
                    "server=37.187.37.245;user id=internship;password=abcd4ABCD;persistsecurityinfo=True;database=internship_management";
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM company WHERE id = '" + idTextBox.Text + "'";
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
                    MessageBox.Show("Pas de connection mon precieux true error", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                conn.Close();
            }
            //
        }

        private void Fm_Company_Detail_Load(object sender, EventArgs e)
        {

        }
    }
}
