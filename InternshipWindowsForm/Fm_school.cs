using System;
using System.Linq;
using System.Windows.Forms;

namespace InternshipWindowsForm
{
    public partial class Fm_school : Form
    {
        public ModeleEntity Me;
        public Fm_school(ModeleEntity entity)
        {
            Me = entity;
            InitializeComponent();
            schoolBindingSource.DataSource = Me.school.ToList();
        }

        public void UpdateSchool()
        {
            schoolDataGridView.Refresh();
        }

        private void schoolDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (schoolDataGridView.Columns[e.ColumnIndex].Name == "bt_details")
            {
                school selectedSchool = (school)schoolDataGridView.CurrentRow.DataBoundItem;
                if (selectedSchool != null)
                {
                    Fm_school_detail fmSchoolDetail = new Fm_school_detail(Me, selectedSchool);
                    fmSchoolDetail.ShowDialog();
                }
            }
        }

        private void Fm_school_Load(object sender, EventArgs e)
        {

        }

    }
}
