using System;
using System.Linq;
using System.Windows.Forms;

namespace InternshipWindowsForm
{
    public partial class Fm_Students : Form
    {
        public ModeleEntity Me;
        public Fm_Students(ModeleEntity entity)
        {
            InitializeComponent();
            Me = entity;
            personBindingSource.DataSource = Me.person.ToList();
        }

        public void UpdateStudent()
        {
            personBindingSource.DataSource = Me.person.ToList();
            personDataGridView.Refresh();
        }

        public DataGridView PersonDataGridView
        {
            get { return personDataGridView; }
        }

        private void personDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (personDataGridView.Columns[e.ColumnIndex].Name == "bt_details")
            {
                person selectedPerson = (person)personDataGridView.CurrentRow.DataBoundItem;
                if (selectedPerson != null)
                {
                    Fm_Student_Detail fmStudentDetail = new Fm_Student_Detail(Me, selectedPerson);
                    fmStudentDetail.ShowDialog();
                }
            }
        }

        private void Fm_Students_Load(object sender, EventArgs e)
        {

        }
    }
}
