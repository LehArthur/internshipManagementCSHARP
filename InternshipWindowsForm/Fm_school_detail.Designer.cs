namespace InternshipWindowsForm
{
    partial class Fm_school_detail
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
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label townLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_school_detail));
            this.schoolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.schoolBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            townLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingNavigator)).BeginInit();
            this.schoolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address1Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            address1Label.Location = new System.Drawing.Point(71, 109);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(82, 18);
            address1Label.TabIndex = 1;
            address1Label.Text = "Address 1 :";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            address2Label.Location = new System.Drawing.Point(71, 169);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(82, 18);
            address2Label.TabIndex = 3;
            address2Label.Text = "Address 2 :";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            idLabel.Location = new System.Drawing.Point(71, 226);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(93, 18);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id de l\'école :";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            mailLabel.Location = new System.Drawing.Point(626, 59);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(53, 18);
            mailLabel.TabIndex = 9;
            mailLabel.Text = "Email :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nameLabel.Location = new System.Drawing.Point(71, 56);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(111, 18);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Nom de l\'école:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            telephoneLabel.Location = new System.Drawing.Point(626, 112);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(85, 18);
            telephoneLabel.TabIndex = 13;
            telephoneLabel.Text = "Téléphone :";
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            townLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            townLabel.Location = new System.Drawing.Point(626, 172);
            townLabel.Name = "townLabel";
            townLabel.Size = new System.Drawing.Size(42, 18);
            townLabel.TabIndex = 15;
            townLabel.Text = "Ville :";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            zipCodeLabel.Location = new System.Drawing.Point(626, 229);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(104, 18);
            zipCodeLabel.TabIndex = 17;
            zipCodeLabel.Text = "Code postale :";
            // 
            // schoolBindingNavigator
            // 
            this.schoolBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.schoolBindingNavigator.BindingSource = this.schoolBindingSource;
            this.schoolBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.schoolBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.schoolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.schoolBindingNavigatorSaveItem});
            this.schoolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.schoolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.schoolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.schoolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.schoolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.schoolBindingNavigator.Name = "schoolBindingNavigator";
            this.schoolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.schoolBindingNavigator.Size = new System.Drawing.Size(1510, 27);
            this.schoolBindingNavigator.TabIndex = 0;
            this.schoolBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // schoolBindingNavigatorSaveItem
            // 
            this.schoolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.schoolBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("schoolBindingNavigatorSaveItem.Image")));
            this.schoolBindingNavigatorSaveItem.Name = "schoolBindingNavigatorSaveItem";
            this.schoolBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.schoolBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.schoolBindingNavigatorSaveItem.Click += new System.EventHandler(this.schoolBindingNavigatorSaveItem_Click);
            // 
            // address1TextBox
            // 
            this.address1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "address1", true));
            this.address1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1TextBox.Location = new System.Drawing.Point(266, 106);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(240, 24);
            this.address1TextBox.TabIndex = 2;
            // 
            // address2TextBox
            // 
            this.address2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "address2", true));
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(266, 166);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(240, 24);
            this.address2TextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(266, 223);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(240, 24);
            this.idTextBox.TabIndex = 6;
            // 
            // mailTextBox
            // 
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "mail", true));
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(821, 56);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(240, 24);
            this.mailTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(266, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 24);
            this.nameTextBox.TabIndex = 12;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "telephone", true));
            this.telephoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneTextBox.Location = new System.Drawing.Point(821, 109);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(240, 24);
            this.telephoneTextBox.TabIndex = 14;
            // 
            // townTextBox
            // 
            this.townTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.townTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "town", true));
            this.townTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.townTextBox.Location = new System.Drawing.Point(821, 169);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(240, 24);
            this.townTextBox.TabIndex = 16;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "zipCode", true));
            this.zipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeTextBox.Location = new System.Drawing.Point(821, 226);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(240, 24);
            this.zipCodeTextBox.TabIndex = 18;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataSource = typeof(InternshipWindowsForm.school);
            // 
            // Fm_school_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1510, 715);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(townLabel);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.schoolBindingNavigator);
            this.Name = "Fm_school_detail";
            this.Text = "Détail école";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fm_school_detail_FormClosing);
            this.Load += new System.EventHandler(this.Fm_school_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingNavigator)).EndInit();
            this.schoolBindingNavigator.ResumeLayout(false);
            this.schoolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource schoolBindingSource;
        private System.Windows.Forms.BindingNavigator schoolBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton schoolBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
    }
}