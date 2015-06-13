using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace InternshipWindowsForm
{
    public partial class Fm_event_detail : Form
    {
        //TODO arriver sur le bon index apes appuyé sur les détails
        //TODO avoir bonne sauvegarde et supression
        public ModeleEntity Me;
        public bool boolSave = false;
        private @event SelectedCompany; 
        public Fm_event_detail(ModeleEntity entity)
        {
            Me = entity;
            InitializeComponent();

        }

        //Show detail from row selected
        public Fm_event_detail(ModeleEntity entity, @event selectedCompany)
            : this(entity)
        {
            eventBindingSource.Position = eventBindingSource.List.IndexOf(selectedCompany);
            SelectedCompany = selectedCompany;
        }

        public void  myTH()
        {
            var Form = new Fm_Home();
            Form.ShowDialog();
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (@eventBindingSource.Current != null)
            {
               


                Validate();
                eventBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.internship_managementDataSet);
                eventBindingSource.EndEdit();
                Me.SaveChanges();

                MessageBox.Show("Sauvegardé", "Sauvegardé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                eventBindingSource.DataSource = Me.@event.ToList();
                //Update
                
            }

        }

        private void Fm_event_detail_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'internship_managementDataSet._event'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.eventTableAdapter.Fill(this.internship_managementDataSet._event);
        }

        public bool isListOkt(List<TextBox> listTxtBox)
        {
            foreach (var currentTextBox in listTxtBox)
            {
                if (currentTextBox.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void Butt_add_Click(object sender, EventArgs e)
        {
            List<TextBox> txtBoxList = new List<TextBox>();

            txtBoxList.Add(nameTextBox);
            txtBoxList.Add(descriptionTextBox);
            txtBoxList.Add(address1TextBox);
            txtBoxList.Add(address2TextBox);
            txtBoxList.Add(townTextBox);
            txtBoxList.Add(zipCodeTextBox);
            txtBoxList.Add(telephoneTextBox);
            txtBoxList.Add(mailTextBox);
            if(boolSave == false)
            {
          
            foreach (var currentTxtBox in txtBoxList)
            {
                idTextBox.Text = "";
                currentTxtBox.Text = "";                
            }
            Butt_add.Text = "Sauvegarder";
            boolSave = true;
            }
            else if(isListOkt(txtBoxList) == true && mailTextBox.Text.Contains("@"))
            {
            if (eventBindingSource.Current != null)
            {

                var dtaFM = new Fm_events(Me);
                dtaFM.dataReset();



                //Date format convert
                dateDateTimePicker.Format = DateTimePickerFormat.Custom;
                dateDateTimePicker.CustomFormat = "yyyy-MM-dd";
                //

                //Connect to DB
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString =
                    "server=37.187.37.245;user id=internship;password=abcd4ABCD;persistsecurityinfo=True;database=internship_management";
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO event VALUES('', '" + this.id_schoolTextBox.Text + "','" + this.nameTextBox.Text + "','" + this.descriptionTextBox.Text + "','" + this.address1TextBox.Text + "','" + this.address2TextBox.Text + "','" + this.townTextBox.Text + "','" + this.zipCodeTextBox.Text + "', '" + this.telephoneTextBox.Text + "', '" + this.mailTextBox.Text + "', '" + this.dateDateTimePicker.Text + "')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //MessageBox.Show("date"+this.dateDateTimePicker.Text+"", "noConnectionDB", MessageBoxButtons.OK,
                  //      MessageBoxIcon.Exclamation);

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
            else
            {
                MessageBox.Show("Veuillez remplir les champs ou rentrer une adresse valide", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }
    }
}
