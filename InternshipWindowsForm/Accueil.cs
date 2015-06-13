using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;


namespace InternshipWindowsForm
{
    //TODO Refractor Fm_HOME classe without underscore #tryhard
    public partial class Fm_Home : Form
    {
        //Thread declaration
        private Thread ThreadI; 
        public ModeleEntity Me;

        //initialize content
        public Fm_Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            Me = new ModeleEntity();
        }

        //Without border code
        
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.Black, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //End connection border
         

        //Opening connection
        private void openConnection()
        {
            var connect = new Fm_Connection();
            connect.ShowDialog();
        }

        //Function that display Forms in panel 1
        public void panelFormShow(Form FM)
        {
            Form formPresentation = FM;
            formPresentation.TopLevel = false;
            formPresentation.AutoScroll = true;
            panel1.Controls.Add(formPresentation);
            formPresentation.Dock = DockStyle.Left;
            formPresentation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formPresentation.Show();
        }

        //Function that display Forms in panel 2
        public void panelFormShow1(Form FM1)
        {
            Form formPresentation = FM1;
            formPresentation.TopLevel = false;
            formPresentation.AutoScroll = true;
            panel2.Controls.Add(formPresentation);
            formPresentation.Dock = DockStyle.Left;
            formPresentation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formPresentation.Show();
        }
        
        //Panel Home
        public void Fm_Home_Load(object sender, EventArgs e)
        {
            var fmHomeChart = new Fm_chart_event();
            panelFormShow(fmHomeChart);

            var fmJournalGra = new Fm_Journal_Actions();
            panelFormShow1(fmJournalGra);

            labWrite();
        }

        //Can open any form, from the form given in params
        public void formOpening(Form newForm)
        {
            newForm.ShowDialog();
        }

        //Butt Student stats
        private void SchoolStudentStats_Click(object sender, EventArgs e)
        {
            var fmChartEvent = new Fm_chart_event();
            panelFormShow1(fmChartEvent);

            var fmEmpty = new Fm_empty();
            panelFormShow1(fmEmpty);

            labDel();
        }

        //Butt Company
        private void Butt_Company_Click(object sender, EventArgs e)
        {
            var fmCompany = new Fm_Company(Me);
            panelFormShow(fmCompany);

            var fmEmpty = new Fm_empty();
            panelFormShow1(fmEmpty);

            labDel();
        }

        //Butt Student
        private void Butt_Student_Click_1(object sender, EventArgs e)
        {
            var fmStudent = new Fm_Students(Me);
            panelFormShow(fmStudent);

            var fmEmpty = new Fm_empty();
            panelFormShow1(fmEmpty);

            labDel();
        }

        //Butt school
        private void Butt_School_Click(object sender, EventArgs e)
        {
            var fmSchool = new Fm_school_detail(Me);
            panelFormShow(fmSchool);

            var fmEmpty = new Fm_empty();
            panelFormShow1(fmEmpty);

            labDel();
        }

        //Butt event
        private void Butt_Event_Click(object sender, EventArgs e)
        {
            var fmEvent = new Fm_events(Me);
            panelFormShow(fmEvent);

            var fmChartEvent = new Fm_chart_event();
            panelFormShow1(fmChartEvent);

            labDel();
        }

        private void Butt_logout_Click(object sender, EventArgs e)
        {
            //Threading to close windows
            //TODO Use thread to open conection, with formOpening()
            this.Close();
            ThreadI = new Thread(openConnection);
            ThreadI.Start();
        }

        private void Butt_journal_Click(object sender, EventArgs e)
        {
            var fmJournal = new Fm_journal(Me);
            panelFormShow(fmJournal);

            var fmActionsJournal = new Fm_Journal_Actions();
            panelFormShow1(fmActionsJournal);
            
            labDel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = false;
            button2.BackColor = Color.Pink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Butt_close_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labDel()
        {
            labelHom.Text = "";
        }


        private void labWrite()
        {
            labelHom.Text = "Bienvenue sur Interniship Management !";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var fmHomeChart = new Fm_chart_event();
            panelFormShow(fmHomeChart);

            var fmJournalGra = new Fm_Journal_Actions();
            panelFormShow1(fmJournalGra);

            labWrite();
        }

        private void Gestion_Enter(object sender, EventArgs e)
        {

        }

        private void Butt_Company_MouseClick(object sender, MouseEventArgs e)
        {
            Butt_Company.BackColor = Color.Blue;
        }

        private void Butt_Company_Leave(object sender, EventArgs e)
        {
            Butt_Company.BackColor = Color.Black;
        }

        private void Butt_Student_MouseClick(object sender, MouseEventArgs e)
        {
            Butt_Student.BackColor = Color.Blue;
        }

        private void Butt_Student_Leave(object sender, EventArgs e)
        {
            Butt_Student.BackColor = Color.Black;
        }

        private void Butt_School_MouseClick(object sender, MouseEventArgs e)
        {
            Butt_School.BackColor = Color.Blue;
        }

        private void Butt_School_Leave(object sender, EventArgs e)
        {
            Butt_School.BackColor = Color.Black;
        }

        private void Butt_Event_MouseClick(object sender, MouseEventArgs e)
        {
            Butt_Event.BackColor = Color.Blue;
        }

        private void Butt_Event_Leave(object sender, EventArgs e)
        {
            Butt_Event.BackColor = Color.Black;
        }

        private void SchoolStudentStats_MouseClick(object sender, MouseEventArgs e)
        {
            SchoolStudentStats.BackColor = Color.Blue;
        }

        private void SchoolStudentStats_Leave(object sender, EventArgs e)
        {
            SchoolStudentStats.BackColor = Color.Black;
        }

        private void Butt_journal_MouseClick(object sender, MouseEventArgs e)
        {
            Butt_journal.BackColor = Color.Blue;
        }

        private void Butt_journal_Leave(object sender, EventArgs e)
        {
            Butt_journal.BackColor = Color.Black;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Blue;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
