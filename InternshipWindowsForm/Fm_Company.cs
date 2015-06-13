using System;
using System.Linq;
using System.Windows.Forms;

namespace InternshipWindowsForm
{
    //TODO change color for campany validation 
    public partial class Fm_Company : Form
    {
        //Model declaration
        public ModeleEntity Me;
        //Data inistilisation
        public Fm_Company(ModeleEntity entity)
        {
            Me = entity;
            InitializeComponent();
            companyBindingSource.DataSource = Me.company.ToList();
        }

        //Update Void
        public void UpdateCompany()
        {
            companyDataGridView.Refresh();
        }

        //Transfer data from row clicked to the detail view
        public void companyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get row clicked
            if (companyDataGridView.Columns[e.ColumnIndex].Name == "bt_details")
            {
                //Get data from row clicked
                company selectedCompany = (company)companyDataGridView.CurrentRow.DataBoundItem;
                
                if (selectedCompany != null)
                {
                    //Open form with the row data
                    Fm_Company_Detail fmCompanyDetailDetail = new Fm_Company_Detail(Me, selectedCompany);
                    fmCompanyDetailDetail.ShowDialog();
                }
            }
        }

        private void Fm_Company_Load(object sender, EventArgs e)
        {

        }
    }
}
