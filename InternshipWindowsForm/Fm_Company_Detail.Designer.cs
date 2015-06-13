namespace InternshipWindowsForm
{
    partial class Fm_Company_Detail
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label townLabel;
            System.Windows.Forms.Label validateLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label nbEmployeeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_Company_Detail));
            this.companyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.companyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.validateCheckBox = new System.Windows.Forms.CheckBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.Butt_add = new System.Windows.Forms.Button();
            this.Butt_delete = new System.Windows.Forms.Button();
            this.nbEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            townLabel = new System.Windows.Forms.Label();
            validateLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            nbEmployeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).BeginInit();
            this.companyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address1Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            address1Label.Location = new System.Drawing.Point(87, 89);
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
            address2Label.Location = new System.Drawing.Point(87, 117);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(82, 18);
            address2Label.TabIndex = 3;
            address2Label.Text = "Address 2 :";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            descriptionLabel.Location = new System.Drawing.Point(87, 177);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(91, 18);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description :";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            idLabel.Location = new System.Drawing.Point(87, 205);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(122, 18);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id de l\'entreprise :";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            mailLabel.Location = new System.Drawing.Point(87, 233);
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
            nameLabel.Location = new System.Drawing.Point(87, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 18);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Nom :";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            telephoneLabel.Location = new System.Drawing.Point(87, 261);
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
            townLabel.Location = new System.Drawing.Point(87, 289);
            townLabel.Name = "townLabel";
            townLabel.Size = new System.Drawing.Size(42, 18);
            townLabel.TabIndex = 15;
            townLabel.Text = "Ville :";
            // 
            // validateLabel
            // 
            validateLabel.AutoSize = true;
            validateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            validateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            validateLabel.Location = new System.Drawing.Point(87, 319);
            validateLabel.Name = "validateLabel";
            validateLabel.Size = new System.Drawing.Size(72, 18);
            validateLabel.TabIndex = 17;
            validateLabel.Text = "Valider ? :";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            zipCodeLabel.Location = new System.Drawing.Point(87, 347);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(104, 18);
            zipCodeLabel.TabIndex = 19;
            zipCodeLabel.Text = "Code postale :";
            // 
            // nbEmployeeLabel
            // 
            nbEmployeeLabel.AutoSize = true;
            nbEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nbEmployeeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nbEmployeeLabel.Location = new System.Drawing.Point(87, 149);
            nbEmployeeLabel.Name = "nbEmployeeLabel";
            nbEmployeeLabel.Size = new System.Drawing.Size(141, 18);
            nbEmployeeLabel.TabIndex = 23;
            nbEmployeeLabel.Text = "Nombre d\'employé :";
            // 
            // companyBindingNavigator
            // 
            this.companyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.companyBindingNavigator.BindingSource = this.companyBindingSource;
            this.companyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.companyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.companyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.companyBindingNavigatorSaveItem});
            this.companyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.companyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.companyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.companyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.companyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.companyBindingNavigator.Name = "companyBindingNavigator";
            this.companyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.companyBindingNavigator.Size = new System.Drawing.Size(588, 27);
            this.companyBindingNavigator.TabIndex = 0;
            this.companyBindingNavigator.Text = "bindingNavigator1";
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
            // companyBindingNavigatorSaveItem
            // 
            this.companyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companyBindingNavigatorSaveItem.Image")));
            this.companyBindingNavigatorSaveItem.Name = "companyBindingNavigatorSaveItem";
            this.companyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.companyBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.companyBindingNavigatorSaveItem.Click += new System.EventHandler(this.companyBindingNavigatorSaveItem_Click);
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(255, 89);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(171, 22);
            this.address1TextBox.TabIndex = 2;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(255, 117);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(171, 22);
            this.address2TextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(255, 177);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(171, 22);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(255, 205);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(171, 22);
            this.idTextBox.TabIndex = 8;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(255, 233);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(171, 22);
            this.mailTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(255, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 22);
            this.nameTextBox.TabIndex = 12;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(255, 261);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(171, 22);
            this.telephoneTextBox.TabIndex = 14;
            // 
            // townTextBox
            // 
            this.townTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "town", true));
            this.townTextBox.Location = new System.Drawing.Point(255, 289);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(171, 22);
            this.townTextBox.TabIndex = 16;
            // 
            // validateCheckBox
            // 
            this.validateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.companyBindingSource, "validate", true));
            this.validateCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.validateCheckBox.Location = new System.Drawing.Point(255, 317);
            this.validateCheckBox.Name = "validateCheckBox";
            this.validateCheckBox.Size = new System.Drawing.Size(104, 24);
            this.validateCheckBox.TabIndex = 18;
            this.validateCheckBox.Text = "oui/non";
            this.validateCheckBox.UseVisualStyleBackColor = true;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "zipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(255, 347);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(171, 22);
            this.zipCodeTextBox.TabIndex = 20;
            // 
            // Butt_add
            // 
            this.Butt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Butt_add.Location = new System.Drawing.Point(90, 405);
            this.Butt_add.Name = "Butt_add";
            this.Butt_add.Size = new System.Drawing.Size(88, 39);
            this.Butt_add.TabIndex = 21;
            this.Butt_add.Text = "Ajouter";
            this.Butt_add.UseVisualStyleBackColor = true;
            this.Butt_add.Click += new System.EventHandler(this.Butt_add_Click);
            // 
            // Butt_delete
            // 
            this.Butt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Butt_delete.Location = new System.Drawing.Point(283, 405);
            this.Butt_delete.Name = "Butt_delete";
            this.Butt_delete.Size = new System.Drawing.Size(96, 39);
            this.Butt_delete.TabIndex = 22;
            this.Butt_delete.Text = "Supprimer";
            this.Butt_delete.UseVisualStyleBackColor = true;
            this.Butt_delete.Click += new System.EventHandler(this.Butt_delete_Click);
            // 
            // nbEmployeeTextBox
            // 
            this.nbEmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "nbEmployee", true));
            this.nbEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbEmployeeTextBox.Location = new System.Drawing.Point(255, 147);
            this.nbEmployeeTextBox.Name = "nbEmployeeTextBox";
            this.nbEmployeeTextBox.Size = new System.Drawing.Size(171, 24);
            this.nbEmployeeTextBox.TabIndex = 24;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(InternshipWindowsForm.company);
            // 
            // Fm_Company_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(588, 496);
            this.Controls.Add(nbEmployeeLabel);
            this.Controls.Add(this.nbEmployeeTextBox);
            this.Controls.Add(this.Butt_delete);
            this.Controls.Add(this.Butt_add);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
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
            this.Controls.Add(validateLabel);
            this.Controls.Add(this.validateCheckBox);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.companyBindingNavigator);
            this.Name = "Fm_Company_Detail";
            this.Text = "Détail de l\'entreprise";
            this.Load += new System.EventHandler(this.Fm_Company_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).EndInit();
            this.companyBindingNavigator.ResumeLayout(false);
            this.companyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingNavigator companyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton companyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.CheckBox validateCheckBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Button Butt_add;
        private System.Windows.Forms.Button Butt_delete;
        private System.Windows.Forms.TextBox nbEmployeeTextBox;
    }
}