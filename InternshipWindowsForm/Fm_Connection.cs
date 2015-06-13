using System;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace InternshipWindowsForm
{
    public partial class Fm_Connection : Form
    {
        //Thread initialisation
        private Thread Thread;
        //Modele initialization
        public ModeleEntity Me;
        //Initialize component fo the form
        public Fm_Connection()
        {
            InitializeComponent();
        }

        //Opening home
        private void openHome()
        {
            var home = new Fm_Home();
            home.ShowDialog();
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

        //Connexion butt
        private void button1_Click(object sender, EventArgs e)
        {
            if ((usernameField.Text == "") || (passwordField.Text == ""))
            {
                MessageBox.Show("Champs vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Sql connection
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString =
                    "server=37.187.37.245;user id=internship;password=abcd4ABCD;persistsecurityinfo=True;database=internship_management";
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT password FROM person WHERE login = '"+this.usernameField.Text+"' GROUP BY login";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                //Password var
                string myPss = null;

                //Read the data
                while (reader.Read())
                {
                    //Get data from reader
                    myPss = reader.GetString(0);
                }
                
                //Test if credentials are good
                if (CalculateMD5Hash(passwordField.Text) == myPss)
                {
                    //Threading to close windows
                    this.Close();
                    
                    //Get name
                    //Name = this.usernameField.Text;
                    //New thread creation
                    Thread = new Thread(openHome);
                    Thread.Start();
                }
                else
                {
                    MessageBox.Show("Mauvais identifiant ou mot de passe", "Erreur", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Fm_Connection_Load(object sender, EventArgs e)
        {
            usernameField.Select();
        }
    }
}
