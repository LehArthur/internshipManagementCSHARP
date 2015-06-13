namespace InternshipWindowsForm
{
    partial class Fm_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Butt_Company = new System.Windows.Forms.Button();
            this.Butt_Student = new System.Windows.Forms.Button();
            this.Butt_School = new System.Windows.Forms.Button();
            this.Butt_Event = new System.Windows.Forms.Button();
            this.Gestion = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Butt_journal = new System.Windows.Forms.Button();
            this.SchoolStudentStats = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Butt_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Butt_close = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelHom = new System.Windows.Forms.Label();
            this.Gestion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Butt_Company
            // 
            this.Butt_Company.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Butt_Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Company.Location = new System.Drawing.Point(35, 26);
            this.Butt_Company.Name = "Butt_Company";
            this.Butt_Company.Size = new System.Drawing.Size(192, 43);
            this.Butt_Company.TabIndex = 0;
            this.Butt_Company.Text = "Entreprise";
            this.Butt_Company.UseVisualStyleBackColor = true;
            this.Butt_Company.Click += new System.EventHandler(this.Butt_Company_Click);
            this.Butt_Company.Leave += new System.EventHandler(this.Butt_Company_Leave);
            this.Butt_Company.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Butt_Company_MouseClick);
            // 
            // Butt_Student
            // 
            this.Butt_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Butt_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Student.Location = new System.Drawing.Point(233, 26);
            this.Butt_Student.Name = "Butt_Student";
            this.Butt_Student.Size = new System.Drawing.Size(196, 43);
            this.Butt_Student.TabIndex = 1;
            this.Butt_Student.Text = "Etudiant";
            this.Butt_Student.UseVisualStyleBackColor = true;
            this.Butt_Student.Click += new System.EventHandler(this.Butt_Student_Click_1);
            this.Butt_Student.Leave += new System.EventHandler(this.Butt_Student_Leave);
            this.Butt_Student.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Butt_Student_MouseClick);
            // 
            // Butt_School
            // 
            this.Butt_School.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Butt_School.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_School.Location = new System.Drawing.Point(435, 26);
            this.Butt_School.Name = "Butt_School";
            this.Butt_School.Size = new System.Drawing.Size(196, 43);
            this.Butt_School.TabIndex = 2;
            this.Butt_School.Text = "Ecole";
            this.Butt_School.UseVisualStyleBackColor = true;
            this.Butt_School.Click += new System.EventHandler(this.Butt_School_Click);
            this.Butt_School.Leave += new System.EventHandler(this.Butt_School_Leave);
            this.Butt_School.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Butt_School_MouseClick);
            // 
            // Butt_Event
            // 
            this.Butt_Event.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Butt_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Event.Location = new System.Drawing.Point(637, 26);
            this.Butt_Event.Name = "Butt_Event";
            this.Butt_Event.Size = new System.Drawing.Size(196, 43);
            this.Butt_Event.TabIndex = 3;
            this.Butt_Event.Text = "Evenement";
            this.Butt_Event.UseVisualStyleBackColor = true;
            this.Butt_Event.Click += new System.EventHandler(this.Butt_Event_Click);
            this.Butt_Event.Leave += new System.EventHandler(this.Butt_Event_Leave);
            this.Butt_Event.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Butt_Event_MouseClick);
            // 
            // Gestion
            // 
            this.Gestion.Controls.Add(this.Butt_Company);
            this.Gestion.Controls.Add(this.Butt_School);
            this.Gestion.Controls.Add(this.Butt_Event);
            this.Gestion.Controls.Add(this.Butt_Student);
            this.Gestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Gestion.Location = new System.Drawing.Point(12, 42);
            this.Gestion.Name = "Gestion";
            this.Gestion.Size = new System.Drawing.Size(854, 92);
            this.Gestion.TabIndex = 4;
            this.Gestion.TabStop = false;
            this.Gestion.Text = "Gestion";
            this.Gestion.Enter += new System.EventHandler(this.Gestion_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Butt_journal);
            this.groupBox1.Controls.Add(this.SchoolStudentStats);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(902, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistique";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Butt_journal
            // 
            this.Butt_journal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Butt_journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_journal.Location = new System.Drawing.Point(237, 26);
            this.Butt_journal.Name = "Butt_journal";
            this.Butt_journal.Size = new System.Drawing.Size(196, 43);
            this.Butt_journal.TabIndex = 1;
            this.Butt_journal.Text = "Journal";
            this.Butt_journal.UseVisualStyleBackColor = true;
            this.Butt_journal.Click += new System.EventHandler(this.Butt_journal_Click);
            this.Butt_journal.Leave += new System.EventHandler(this.Butt_journal_Leave);
            this.Butt_journal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Butt_journal_MouseClick);
            // 
            // SchoolStudentStats
            // 
            this.SchoolStudentStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SchoolStudentStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SchoolStudentStats.Location = new System.Drawing.Point(35, 26);
            this.SchoolStudentStats.Name = "SchoolStudentStats";
            this.SchoolStudentStats.Size = new System.Drawing.Size(196, 43);
            this.SchoolStudentStats.TabIndex = 0;
            this.SchoolStudentStats.Text = "Toutes les statistiques";
            this.SchoolStudentStats.UseVisualStyleBackColor = true;
            this.SchoolStudentStats.Click += new System.EventHandler(this.SchoolStudentStats_Click);
            this.SchoolStudentStats.Leave += new System.EventHandler(this.SchoolStudentStats_Leave);
            this.SchoolStudentStats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SchoolStudentStats_MouseClick);
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.Location = new System.Drawing.Point(39, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 440);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(39, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1508, 370);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Butt_logout
            // 
            this.Butt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Butt_logout.Location = new System.Drawing.Point(1665, 71);
            this.Butt_logout.Name = "Butt_logout";
            this.Butt_logout.Size = new System.Drawing.Size(122, 38);
            this.Butt_logout.TabIndex = 8;
            this.Butt_logout.Text = "Déconnexion";
            this.Butt_logout.UseVisualStyleBackColor = true;
            this.Butt_logout.Click += new System.EventHandler(this.Butt_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(726, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insternship Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::InternshipWindowsForm.Properties.Resources.Capture;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::InternshipWindowsForm.Properties.Resources.butt_close4;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(1, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 29);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::InternshipWindowsForm.Properties.Resources.Capture;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::InternshipWindowsForm.Properties.Resources.butt_reduce1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(36, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 38);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Butt_close
            // 
            this.Butt_close.BackgroundImage = global::InternshipWindowsForm.Properties.Resources.Capture;
            this.Butt_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Butt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_close.Image = global::InternshipWindowsForm.Properties.Resources.butt_fullscreen8;
            this.Butt_close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Butt_close.Location = new System.Drawing.Point(75, -2);
            this.Butt_close.Name = "Butt_close";
            this.Butt_close.Size = new System.Drawing.Size(40, 38);
            this.Butt_close.TabIndex = 0;
            this.Butt_close.UseVisualStyleBackColor = true;
            this.Butt_close.Click += new System.EventHandler(this.Butt_close_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(1527, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Accueil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Leave += new System.EventHandler(this.button3_Leave);
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // labelHom
            // 
            this.labelHom.AutoSize = true;
            this.labelHom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHom.Location = new System.Drawing.Point(42, 137);
            this.labelHom.Name = "labelHom";
            this.labelHom.Size = new System.Drawing.Size(362, 25);
            this.labelHom.TabIndex = 0;
            this.labelHom.Text = "Bienvenue sur Interniship Management !";
            // 
            // Fm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1799, 927);
            this.Controls.Add(this.labelHom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gestion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Butt_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Butt_logout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Fm_Home";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Fm_Home_Load);
            this.Gestion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butt_Company;
        private System.Windows.Forms.Button Butt_Student;
        private System.Windows.Forms.Button Butt_School;
        private System.Windows.Forms.Button Butt_Event;
        private System.Windows.Forms.GroupBox Gestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SchoolStudentStats;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Butt_logout;
        private System.Windows.Forms.Button Butt_journal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Butt_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelHom;
    }
}