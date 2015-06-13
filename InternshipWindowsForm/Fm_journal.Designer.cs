namespace InternshipWindowsForm
{
    partial class Fm_journal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.journalDataGridView = new System.Windows.Forms.DataGridView();
            this.person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // journalDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.journalDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.journalDataGridView.AutoGenerateColumns = false;
            this.journalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.person,
            this.idDataGridViewTextBoxColumn,
            this.idpersonDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn,
            this.muNameDataGridViewTextBoxColumn});
            this.journalDataGridView.DataSource = this.journalBindingSource;
            this.journalDataGridView.Location = new System.Drawing.Point(12, 57);
            this.journalDataGridView.Name = "journalDataGridView";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.journalDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.journalDataGridView.RowTemplate.Height = 24;
            this.journalDataGridView.Size = new System.Drawing.Size(650, 463);
            this.journalDataGridView.TabIndex = 1;
            this.journalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.journalDataGridView_CellContentClick);
            // 
            // person
            // 
            this.person.DataPropertyName = "muName";
            this.person.HeaderText = "Personne";
            this.person.Name = "person";
            this.person.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id de l\'action";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idpersonDataGridViewTextBoxColumn
            // 
            this.idpersonDataGridViewTextBoxColumn.DataPropertyName = "id_person";
            this.idpersonDataGridViewTextBoxColumn.HeaderText = "Id de l\'action";
            this.idpersonDataGridViewTextBoxColumn.Name = "idpersonDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action réalisé";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date de l\'action";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "muName";
            this.personDataGridViewTextBoxColumn.HeaderText = "Personne";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.ReadOnly = true;
            this.personDataGridViewTextBoxColumn.Visible = false;
            // 
            // muNameDataGridViewTextBoxColumn
            // 
            this.muNameDataGridViewTextBoxColumn.DataPropertyName = "muName";
            this.muNameDataGridViewTextBoxColumn.HeaderText = "muName";
            this.muNameDataGridViewTextBoxColumn.Name = "muNameDataGridViewTextBoxColumn";
            this.muNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.muNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // journalBindingSource
            // 
            this.journalBindingSource.DataSource = typeof(InternshipWindowsForm.journal);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(InternshipWindowsForm.person);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Journal de modifications";
            // 
            // Fm_journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1556, 893);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.journalDataGridView);
            this.Name = "Fm_journal";
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.Fm_journal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.journalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource journalBindingSource;
        private System.Windows.Forms.DataGridView journalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn person;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muNameDataGridViewTextBoxColumn;
    }
}