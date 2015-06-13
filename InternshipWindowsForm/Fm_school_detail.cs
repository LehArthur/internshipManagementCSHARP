using System;
using System.Linq;
using System.Windows.Forms;

namespace InternshipWindowsForm
{
    public partial class Fm_school_detail : Form
    {
        public ModeleEntity Me;
        public Fm_school_detail(ModeleEntity entity)
        {
            Me = entity;
            InitializeComponent();
            schoolBindingSource.DataSource = Me.school.ToList();
        }

        public Fm_school_detail(ModeleEntity entity, school selectedSchool)
            : this (entity)
        {
            schoolBindingSource.Position = schoolBindingSource.List.IndexOf(selectedSchool);
        }

        private void schoolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (schoolBindingSource != null)
            {
                MessageBox.Show("Sauvegardé", "Sauvegardé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                schoolBindingSource.EndEdit();
                Me.SaveChanges();
            }
        }

        private void Fm_school_detail_FormClosing(object sender, FormClosingEventArgs e)
        {
            var school = new Fm_school(Me);
            school.UpdateSchool();
        }

        private void Fm_school_detail_Load(object sender, EventArgs e)
        {

        }
    }
}
