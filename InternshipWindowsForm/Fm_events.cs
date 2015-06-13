using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace InternshipWindowsForm
{
    public partial class Fm_events : Form
    {
        public Thread EvenThread;
        public ModeleEntity Me;
        public Fm_events(ModeleEntity entity)
        {
            Me = entity;
            InitializeComponent();
            eventBindingSource.DataSource = Me.@event.ToList();
        }

        public void dataReset()
        {
            eventBindingSource.DataSource = Me.@event.ToList();
        }

        private void Fm_events_Load(object sender, EventArgs e)
        {

        }

        //Update Void
        public void UpdateEve()
        {
            eventDataGridView.Refresh();
        }

        public void newDetail()
        {
            var deta = new Fm_event_detail(Me);
            deta.ShowDialog();
        }

        //Transfer data from row clicked to the detail view
        private void eventDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get data clicked
            if (eventDataGridView.Columns[e.ColumnIndex].Name == "bt_details")
            {
                //Get data from row clicked
                @event selectedEvent = (@event)eventDataGridView.CurrentRow.DataBoundItem;
                
                if (selectedEvent != null)
                {
                    //Cast item
                    Fm_event_detail fmStudentDetail = new Fm_event_detail(Me, selectedEvent);
                    fmStudentDetail.Closed += new EventHandler(DetailForm_Closed);
                    fmStudentDetail.ShowDialog();
                }
            }
           
        }

        private void DetailForm_Closed(object sender, EventArgs e)
        {

        }
    }
}
