namespace InternshipWindowsForm
{
    partial class Fm_event_detail
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label townLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label id_schoolLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_event_detail));
            this.internship_managementDataSet = new InternshipWindowsForm.internship_managementDataSet();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new InternshipWindowsForm.internship_managementDataSetTableAdapters.eventTableAdapter();
            this.tableAdapterManager = new InternshipWindowsForm.internship_managementDataSetTableAdapters.TableAdapterManager();
            this.eventBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Butt_add = new System.Windows.Forms.Button();
            this.Butt_delete = new System.Windows.Forms.Button();
            this.id_schoolTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            townLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            id_schoolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.internship_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).BeginInit();
            this.eventBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            idLabel.Location = new System.Drawing.Point(60, 121);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(149, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id de l\'événement :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nameLabel.Location = new System.Drawing.Point(60, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(171, 20);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Nom de l\'événement :";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            descriptionLabel.Location = new System.Drawing.Point(60, 205);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(105, 20);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description :";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address1Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            address1Label.Location = new System.Drawing.Point(60, 233);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(95, 20);
            address1Label.TabIndex = 9;
            address1Label.Text = "Address 1 :";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            address2Label.Location = new System.Drawing.Point(60, 261);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(95, 20);
            address2Label.TabIndex = 11;
            address2Label.Text = "Address 2 :";
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            townLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            townLabel.Location = new System.Drawing.Point(60, 289);
            townLabel.Name = "townLabel";
            townLabel.Size = new System.Drawing.Size(51, 20);
            townLabel.TabIndex = 13;
            townLabel.Text = "Ville :";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            zipCodeLabel.Location = new System.Drawing.Point(60, 317);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(117, 20);
            zipCodeLabel.TabIndex = 15;
            zipCodeLabel.Text = "Code postale :";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            telephoneLabel.Location = new System.Drawing.Point(60, 345);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(96, 20);
            telephoneLabel.TabIndex = 17;
            telephoneLabel.Text = "Téléphone :";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            mailLabel.Location = new System.Drawing.Point(60, 373);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(61, 20);
            mailLabel.TabIndex = 19;
            mailLabel.Text = "Email :";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dateLabel.Location = new System.Drawing.Point(59, 423);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(172, 20);
            dateLabel.TabIndex = 21;
            dateLabel.Text = "Date de l\'événement :";
            // 
            // id_schoolLabel
            // 
            id_schoolLabel.AutoSize = true;
            id_schoolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_schoolLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_schoolLabel.Location = new System.Drawing.Point(60, 149);
            id_schoolLabel.Name = "id_schoolLabel";
            id_schoolLabel.Size = new System.Drawing.Size(210, 20);
            id_schoolLabel.TabIndex = 3;
            id_schoolLabel.Text = "Id de l\'école organisatrice :";
            // 
            // internship_managementDataSet
            // 
            this.internship_managementDataSet.DataSetName = "internship_managementDataSet";
            this.internship_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "event";
            this.eventBindingSource.DataSource = this.internship_managementDataSet;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.eventTableAdapter = this.eventTableAdapter;
            this.tableAdapterManager.UpdateOrder = InternshipWindowsForm.internship_managementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventBindingNavigator
            // 
            this.eventBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventBindingNavigator.BindingSource = this.eventBindingSource;
            this.eventBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventBindingNavigatorSaveItem});
            this.eventBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventBindingNavigator.Name = "eventBindingNavigator";
            this.eventBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventBindingNavigator.Size = new System.Drawing.Size(767, 27);
            this.eventBindingNavigator.TabIndex = 0;
            this.eventBindingNavigator.Text = "bindingNavigator1";
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
            // eventBindingNavigatorSaveItem
            // 
            this.eventBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventBindingNavigatorSaveItem.Image")));
            this.eventBindingNavigatorSaveItem.Name = "eventBindingNavigatorSaveItem";
            this.eventBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.eventBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.eventBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(370, 121);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 24);
            this.idTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(370, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 24);
            this.nameTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(370, 205);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 24);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // address1TextBox
            // 
            this.address1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "address1", true));
            this.address1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1TextBox.Location = new System.Drawing.Point(370, 233);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(200, 24);
            this.address1TextBox.TabIndex = 10;
            // 
            // address2TextBox
            // 
            this.address2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "address2", true));
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(370, 261);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(200, 24);
            this.address2TextBox.TabIndex = 12;
            // 
            // townTextBox
            // 
            this.townTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.townTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "town", true));
            this.townTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.townTextBox.Location = new System.Drawing.Point(370, 289);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(200, 24);
            this.townTextBox.TabIndex = 14;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "zipCode", true));
            this.zipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeTextBox.Location = new System.Drawing.Point(370, 317);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(200, 24);
            this.zipCodeTextBox.TabIndex = 16;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "telephone", true));
            this.telephoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneTextBox.Location = new System.Drawing.Point(370, 345);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(200, 24);
            this.telephoneTextBox.TabIndex = 18;
            // 
            // mailTextBox
            // 
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "mail", true));
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(370, 373);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(200, 24);
            this.mailTextBox.TabIndex = 20;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(370, 418);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dateDateTimePicker.TabIndex = 22;
            this.dateDateTimePicker.Value = new System.DateTime(2015, 5, 3, 0, 0, 0, 0);
            // 
            // Butt_add
            // 
            this.Butt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Butt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Butt_add.Location = new System.Drawing.Point(62, 485);
            this.Butt_add.Name = "Butt_add";
            this.Butt_add.Size = new System.Drawing.Size(121, 61);
            this.Butt_add.TabIndex = 23;
            this.Butt_add.Text = "Ajout ";
            this.Butt_add.UseVisualStyleBackColor = true;
            this.Butt_add.Click += new System.EventHandler(this.Butt_add_Click);
            // 
            // Butt_delete
            // 
            this.Butt_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Butt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Butt_delete.Location = new System.Drawing.Point(313, 485);
            this.Butt_delete.Name = "Butt_delete";
            this.Butt_delete.Size = new System.Drawing.Size(112, 61);
            this.Butt_delete.TabIndex = 24;
            this.Butt_delete.Text = "Supprimer";
            this.Butt_delete.UseVisualStyleBackColor = true;
            // 
            // id_schoolTextBox
            // 
            this.id_schoolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_schoolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "id_school", true));
            this.id_schoolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_schoolTextBox.Location = new System.Drawing.Point(370, 149);
            this.id_schoolTextBox.Name = "id_schoolTextBox";
            this.id_schoolTextBox.Size = new System.Drawing.Size(200, 24);
            this.id_schoolTextBox.TabIndex = 4;
            // 
            // Fm_event_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(767, 558);
            this.Controls.Add(this.Butt_delete);
            this.Controls.Add(this.Butt_add);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(id_schoolLabel);
            this.Controls.Add(this.id_schoolTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(townLabel);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.eventBindingNavigator);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Fm_event_detail";
            this.Text = "Detail évenement";
            this.Load += new System.EventHandler(this.Fm_event_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internship_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).EndInit();
            this.eventBindingNavigator.ResumeLayout(false);
            this.eventBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private internship_managementDataSet internship_managementDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private internship_managementDataSetTableAdapters.eventTableAdapter eventTableAdapter;
        private internship_managementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button Butt_add;
        private System.Windows.Forms.Button Butt_delete;
        private System.Windows.Forms.TextBox id_schoolTextBox;
    }
}