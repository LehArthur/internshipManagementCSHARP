using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InternshipWindowsForm
{
    public partial class Fm_journal : Form
    {
        public ModeleEntity Me;
        public Fm_journal(ModeleEntity entity)
        {
            Me = entity;
            InitializeComponent();
            journalBindingSource.DataSource = Me.journal.ToList();
        }

        private void Fm_journal_Load(object sender, EventArgs e)
        {
           
        }

        private void ComboBox_Student_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void journalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
