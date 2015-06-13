using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipWindowsForm
{
    public partial class Fm_home_presentation : Form
    {
        public Fm_home_presentation()
        {
            InitializeComponent();
        }

        private void Fm_home_presentation_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = Name;
        }
    }
}
