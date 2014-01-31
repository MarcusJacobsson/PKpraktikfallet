﻿namespace praktikfall
{
    partial class EmployeeFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFrame));
            this.tabPageVisning = new System.Windows.Forms.TabPage();
            this.groupBoxVisning = new System.Windows.Forms.GroupBox();
            this.lblSpekulantVisning = new System.Windows.Forms.Label();
            this.btnAddShowing = new System.Windows.Forms.Button();
            this.btnDeleteShowing = new System.Windows.Forms.Button();
            this.lblDatumVisning = new System.Windows.Forms.Label();
            this.lblObjektVisning = new System.Windows.Forms.Label();
            this.dtpVisningsdatumVisning = new System.Windows.Forms.DateTimePicker();
            this.dgvProspectiveBuyerShowing = new System.Windows.Forms.DataGridView();
            this.dgvObjectShowing = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelBuyerSsn = new System.Windows.Forms.Label();
            this.labelBuyerName = new System.Windows.Forms.Label();
            this.labelBuyerTel = new System.Windows.Forms.Label();
            this.tbBuyerSsn = new System.Windows.Forms.TextBox();
            this.tbBuyerName = new System.Windows.Forms.TextBox();
            this.tbBuyerTel = new System.Windows.Forms.TextBox();
            this.labelBuyerContact = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProspectiveBuyer = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbProspectiveBuyerEmail = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picBoxShowObj = new System.Windows.Forms.PictureBox();
            this.lblObjAddress = new System.Windows.Forms.Label();
            this.lblPricePerKvm = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumberOfRooms = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblUniType = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbNrOfRooms = new System.Windows.Forms.TextBox();
            this.tbUnitType = new System.Windows.Forms.TextBox();
            this.tbObjectArea = new System.Windows.Forms.TextBox();
            this.tbPricePerKvm = new System.Windows.Forms.TextBox();
            this.dgvObject = new System.Windows.Forms.DataGridView();
            this.tbObjSearch = new System.Windows.Forms.TextBox();
            this.btnObjectSearch = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblObjCity = new System.Windows.Forms.Label();
            this.btnUpdateSelectedObj = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelShowMyObjects = new System.Windows.Forms.Label();
            this.labelMyShowings = new System.Windows.Forms.Label();
            this.imageStartLogotype = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVisning.SuspendLayout();
            this.groupBoxVisning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProspectiveBuyerShowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectShowing)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObject)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageStartLogotype)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageVisning
            // 
            this.tabPageVisning.Controls.Add(this.groupBoxVisning);
            this.tabPageVisning.Location = new System.Drawing.Point(4, 22);
            this.tabPageVisning.Name = "tabPageVisning";
            this.tabPageVisning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisning.Size = new System.Drawing.Size(817, 627);
            this.tabPageVisning.TabIndex = 6;
            this.tabPageVisning.Text = "Visnig";
            this.tabPageVisning.UseVisualStyleBackColor = true;
            // 
            // groupBoxVisning
            // 
            this.groupBoxVisning.Controls.Add(this.dgvObjectShowing);
            this.groupBoxVisning.Controls.Add(this.dgvProspectiveBuyerShowing);
            this.groupBoxVisning.Controls.Add(this.dtpVisningsdatumVisning);
            this.groupBoxVisning.Controls.Add(this.lblObjektVisning);
            this.groupBoxVisning.Controls.Add(this.lblDatumVisning);
            this.groupBoxVisning.Controls.Add(this.btnDeleteShowing);
            this.groupBoxVisning.Controls.Add(this.btnAddShowing);
            this.groupBoxVisning.Controls.Add(this.lblSpekulantVisning);
            this.groupBoxVisning.Location = new System.Drawing.Point(11, 7);
            this.groupBoxVisning.Name = "groupBoxVisning";
            this.groupBoxVisning.Size = new System.Drawing.Size(791, 333);
            this.groupBoxVisning.TabIndex = 10;
            this.groupBoxVisning.TabStop = false;
            this.groupBoxVisning.Text = "Administrera visning";
            // 
            // lblSpekulantVisning
            // 
            this.lblSpekulantVisning.AutoSize = true;
            this.lblSpekulantVisning.Location = new System.Drawing.Point(251, 31);
            this.lblSpekulantVisning.Name = "lblSpekulantVisning";
            this.lblSpekulantVisning.Size = new System.Drawing.Size(87, 13);
            this.lblSpekulantVisning.TabIndex = 6;
            this.lblSpekulantVisning.Text = "Välj spekulant";
            // 
            // btnAddShowing
            // 
            this.btnAddShowing.Location = new System.Drawing.Point(710, 304);
            this.btnAddShowing.Name = "btnAddShowing";
            this.btnAddShowing.Size = new System.Drawing.Size(75, 23);
            this.btnAddShowing.TabIndex = 0;
            this.btnAddShowing.Text = "Spara";
            this.btnAddShowing.UseVisualStyleBackColor = true;
            this.btnAddShowing.Click += new System.EventHandler(this.btnAddShowing_Click);
            // 
            // btnDeleteShowing
            // 
            this.btnDeleteShowing.Location = new System.Drawing.Point(629, 304);
            this.btnDeleteShowing.Name = "btnDeleteShowing";
            this.btnDeleteShowing.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteShowing.TabIndex = 1;
            this.btnDeleteShowing.Text = "Ta bort";
            this.btnDeleteShowing.UseVisualStyleBackColor = true;
            // 
            // lblDatumVisning
            // 
            this.lblDatumVisning.AutoSize = true;
            this.lblDatumVisning.Location = new System.Drawing.Point(497, 31);
            this.lblDatumVisning.Name = "lblDatumVisning";
            this.lblDatumVisning.Size = new System.Drawing.Size(66, 13);
            this.lblDatumVisning.TabIndex = 7;
            this.lblDatumVisning.Text = "Välj datum";
            // 
            // lblObjektVisning
            // 
            this.lblObjektVisning.AutoSize = true;
            this.lblObjektVisning.Location = new System.Drawing.Point(3, 30);
            this.lblObjektVisning.Name = "lblObjektVisning";
            this.lblObjektVisning.Size = new System.Drawing.Size(67, 13);
            this.lblObjektVisning.TabIndex = 5;
            this.lblObjektVisning.Text = "Välj objekt";
            // 
            // dtpVisningsdatumVisning
            // 
            this.dtpVisningsdatumVisning.Location = new System.Drawing.Point(500, 47);
            this.dtpVisningsdatumVisning.Name = "dtpVisningsdatumVisning";
            this.dtpVisningsdatumVisning.Size = new System.Drawing.Size(200, 20);
            this.dtpVisningsdatumVisning.TabIndex = 2;
            // 
            // dgvProspectiveBuyerShowing
            // 
            this.dgvProspectiveBuyerShowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProspectiveBuyerShowing.Location = new System.Drawing.Point(254, 48);
            this.dgvProspectiveBuyerShowing.Name = "dgvProspectiveBuyerShowing";
            this.dgvProspectiveBuyerShowing.Size = new System.Drawing.Size(240, 279);
            this.dgvProspectiveBuyerShowing.TabIndex = 9;
            // 
            // dgvObjectShowing
            // 
            this.dgvObjectShowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectShowing.Location = new System.Drawing.Point(6, 47);
            this.dgvObjectShowing.Name = "dgvObjectShowing";
            this.dgvObjectShowing.Size = new System.Drawing.Size(240, 280);
            this.dgvObjectShowing.TabIndex = 8;
            this.dgvObjectShowing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjectShowing_CellClicked);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbProspectiveBuyerEmail);
            this.tabPage5.Controls.Add(this.tbBuyerTel);
            this.tabPage5.Controls.Add(this.tbBuyerName);
            this.tabPage5.Controls.Add(this.tbBuyerSsn);
            this.tabPage5.Controls.Add(this.lblEmail);
            this.tabPage5.Controls.Add(this.btnAddProspectiveBuyer);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.dateTimePicker1);
            this.tabPage5.Controls.Add(this.labelBuyerContact);
            this.tabPage5.Controls.Add(this.labelBuyerTel);
            this.tabPage5.Controls.Add(this.labelBuyerName);
            this.tabPage5.Controls.Add(this.labelBuyerSsn);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(817, 627);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Spekulant";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelBuyerSsn
            // 
            this.labelBuyerSsn.AutoSize = true;
            this.labelBuyerSsn.Location = new System.Drawing.Point(57, 107);
            this.labelBuyerSsn.Name = "labelBuyerSsn";
            this.labelBuyerSsn.Size = new System.Drawing.Size(93, 13);
            this.labelBuyerSsn.TabIndex = 11;
            this.labelBuyerSsn.Text = "Personnummer:";
            // 
            // labelBuyerName
            // 
            this.labelBuyerName.AutoSize = true;
            this.labelBuyerName.Location = new System.Drawing.Point(57, 144);
            this.labelBuyerName.Name = "labelBuyerName";
            this.labelBuyerName.Size = new System.Drawing.Size(43, 13);
            this.labelBuyerName.TabIndex = 12;
            this.labelBuyerName.Text = "Namn:";
            // 
            // labelBuyerTel
            // 
            this.labelBuyerTel.AutoSize = true;
            this.labelBuyerTel.Location = new System.Drawing.Point(57, 181);
            this.labelBuyerTel.Name = "labelBuyerTel";
            this.labelBuyerTel.Size = new System.Drawing.Size(54, 13);
            this.labelBuyerTel.TabIndex = 13;
            this.labelBuyerTel.Text = "Telefon:";
            // 
            // tbBuyerSsn
            // 
            this.tbBuyerSsn.Location = new System.Drawing.Point(191, 107);
            this.tbBuyerSsn.Name = "tbBuyerSsn";
            this.tbBuyerSsn.Size = new System.Drawing.Size(131, 20);
            this.tbBuyerSsn.TabIndex = 14;
            // 
            // tbBuyerName
            // 
            this.tbBuyerName.Location = new System.Drawing.Point(191, 141);
            this.tbBuyerName.Name = "tbBuyerName";
            this.tbBuyerName.Size = new System.Drawing.Size(131, 20);
            this.tbBuyerName.TabIndex = 15;
            // 
            // tbBuyerTel
            // 
            this.tbBuyerTel.Location = new System.Drawing.Point(191, 175);
            this.tbBuyerTel.Name = "tbBuyerTel";
            this.tbBuyerTel.Size = new System.Drawing.Size(131, 20);
            this.tbBuyerTel.TabIndex = 16;
            // 
            // labelBuyerContact
            // 
            this.labelBuyerContact.AutoSize = true;
            this.labelBuyerContact.Location = new System.Drawing.Point(57, 263);
            this.labelBuyerContact.Name = "labelBuyerContact";
            this.labelBuyerContact.Size = new System.Drawing.Size(69, 13);
            this.labelBuyerContact.TabIndex = 17;
            this.labelBuyerContact.Text = "Kontaktad:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Registrera spekulant";
            // 
            // btnAddProspectiveBuyer
            // 
            this.btnAddProspectiveBuyer.Location = new System.Drawing.Point(60, 299);
            this.btnAddProspectiveBuyer.Name = "btnAddProspectiveBuyer";
            this.btnAddProspectiveBuyer.Size = new System.Drawing.Size(75, 23);
            this.btnAddProspectiveBuyer.TabIndex = 20;
            this.btnAddProspectiveBuyer.Text = "Lägg till";
            this.btnAddProspectiveBuyer.UseVisualStyleBackColor = true;
            this.btnAddProspectiveBuyer.Click += new System.EventHandler(this.btnAddProspectiveBuyer_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // tbProspectiveBuyerEmail
            // 
            this.tbProspectiveBuyerEmail.Location = new System.Drawing.Point(191, 205);
            this.tbProspectiveBuyerEmail.Name = "tbProspectiveBuyerEmail";
            this.tbProspectiveBuyerEmail.Size = new System.Drawing.Size(131, 20);
            this.tbProspectiveBuyerEmail.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateSelectedObj);
            this.tabPage2.Controls.Add(this.lblObjCity);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.btnObjectSearch);
            this.tabPage2.Controls.Add(this.tbObjSearch);
            this.tabPage2.Controls.Add(this.tbPricePerKvm);
            this.tabPage2.Controls.Add(this.tbObjectArea);
            this.tabPage2.Controls.Add(this.tbUnitType);
            this.tabPage2.Controls.Add(this.tbNrOfRooms);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.dgvObject);
            this.tabPage2.Controls.Add(this.lblUniType);
            this.tabPage2.Controls.Add(this.lblArea);
            this.tabPage2.Controls.Add(this.lblNumberOfRooms);
            this.tabPage2.Controls.Add(this.lblPrice);
            this.tabPage2.Controls.Add(this.lblPricePerKvm);
            this.tabPage2.Controls.Add(this.lblObjAddress);
            this.tabPage2.Controls.Add(this.picBoxShowObj);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Objekt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // picBoxShowObj
            // 
            this.picBoxShowObj.ErrorImage = null;
            this.picBoxShowObj.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShowObj.Image")));
            this.picBoxShowObj.Location = new System.Drawing.Point(12, 15);
            this.picBoxShowObj.Name = "picBoxShowObj";
            this.picBoxShowObj.Size = new System.Drawing.Size(610, 341);
            this.picBoxShowObj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxShowObj.TabIndex = 0;
            this.picBoxShowObj.TabStop = false;
            // 
            // lblObjAddress
            // 
            this.lblObjAddress.AutoSize = true;
            this.lblObjAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjAddress.Location = new System.Drawing.Point(9, 372);
            this.lblObjAddress.Name = "lblObjAddress";
            this.lblObjAddress.Size = new System.Drawing.Size(105, 31);
            this.lblObjAddress.TabIndex = 1;
            this.lblObjAddress.Text = "Adress";
            this.lblObjAddress.Click += new System.EventHandler(this.lblObjAddress_Click);
            // 
            // lblPricePerKvm
            // 
            this.lblPricePerKvm.AutoSize = true;
            this.lblPricePerKvm.Location = new System.Drawing.Point(473, 540);
            this.lblPricePerKvm.Name = "lblPricePerKvm";
            this.lblPricePerKvm.Size = new System.Drawing.Size(81, 13);
            this.lblPricePerKvm.TabIndex = 2;
            this.lblPricePerKvm.Text = "Pris per kvm:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(258, 372);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 25);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Pris";
            // 
            // lblNumberOfRooms
            // 
            this.lblNumberOfRooms.AutoSize = true;
            this.lblNumberOfRooms.Location = new System.Drawing.Point(474, 479);
            this.lblNumberOfRooms.Name = "lblNumberOfRooms";
            this.lblNumberOfRooms.Size = new System.Drawing.Size(64, 13);
            this.lblNumberOfRooms.TabIndex = 4;
            this.lblNumberOfRooms.Text = "Antal rum:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(473, 451);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(51, 13);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Boarea:";
            // 
            // lblUniType
            // 
            this.lblUniType.AutoSize = true;
            this.lblUniType.Location = new System.Drawing.Point(474, 509);
            this.lblUniType.Name = "lblUniType";
            this.lblUniType.Size = new System.Drawing.Size(73, 13);
            this.lblUniType.TabIndex = 6;
            this.lblUniType.Text = "Bostadstyp:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 451);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 169);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // tbNrOfRooms
            // 
            this.tbNrOfRooms.Location = new System.Drawing.Point(568, 477);
            this.tbNrOfRooms.Name = "tbNrOfRooms";
            this.tbNrOfRooms.Size = new System.Drawing.Size(100, 20);
            this.tbNrOfRooms.TabIndex = 11;
            // 
            // tbUnitType
            // 
            this.tbUnitType.Location = new System.Drawing.Point(568, 506);
            this.tbUnitType.Name = "tbUnitType";
            this.tbUnitType.Size = new System.Drawing.Size(100, 20);
            this.tbUnitType.TabIndex = 12;
            // 
            // tbObjectArea
            // 
            this.tbObjectArea.Location = new System.Drawing.Point(568, 448);
            this.tbObjectArea.Name = "tbObjectArea";
            this.tbObjectArea.Size = new System.Drawing.Size(100, 20);
            this.tbObjectArea.TabIndex = 13;
            // 
            // tbPricePerKvm
            // 
            this.tbPricePerKvm.Location = new System.Drawing.Point(568, 535);
            this.tbPricePerKvm.Name = "tbPricePerKvm";
            this.tbPricePerKvm.Size = new System.Drawing.Size(100, 20);
            this.tbPricePerKvm.TabIndex = 14;
            // 
            // dgvObject
            // 
            this.dgvObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObject.Location = new System.Drawing.Point(658, 15);
            this.dgvObject.Name = "dgvObject";
            this.dgvObject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvObject.Size = new System.Drawing.Size(156, 341);
            this.dgvObject.TabIndex = 16;
            this.dgvObject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObject_CellClick);
            // 
            // tbObjSearch
            // 
            this.tbObjSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.tbObjSearch.Location = new System.Drawing.Point(658, 372);
            this.tbObjSearch.Name = "tbObjSearch";
            this.tbObjSearch.Size = new System.Drawing.Size(101, 20);
            this.tbObjSearch.TabIndex = 17;
            this.tbObjSearch.Text = "Sökord";
            this.tbObjSearch.Click += new System.EventHandler(this.tbObjSearchClick);
            this.tbObjSearch.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // btnObjectSearch
            // 
            this.btnObjectSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnObjectSearch.Image")));
            this.btnObjectSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnObjectSearch.Location = new System.Drawing.Point(774, 370);
            this.btnObjectSearch.Name = "btnObjectSearch";
            this.btnObjectSearch.Size = new System.Drawing.Size(40, 23);
            this.btnObjectSearch.TabIndex = 18;
            this.btnObjectSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObjectSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObjectSearch.UseVisualStyleBackColor = true;
            this.btnObjectSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(568, 566);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Visningsdatum";
            // 
            // lblObjCity
            // 
            this.lblObjCity.AutoSize = true;
            this.lblObjCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjCity.Location = new System.Drawing.Point(11, 418);
            this.lblObjCity.Name = "lblObjCity";
            this.lblObjCity.Size = new System.Drawing.Size(47, 20);
            this.lblObjCity.TabIndex = 21;
            this.lblObjCity.Text = "Stad";
            // 
            // btnUpdateSelectedObj
            // 
            this.btnUpdateSelectedObj.Location = new System.Drawing.Point(476, 598);
            this.btnUpdateSelectedObj.Name = "btnUpdateSelectedObj";
            this.btnUpdateSelectedObj.Size = new System.Drawing.Size(157, 22);
            this.btnUpdateSelectedObj.TabIndex = 22;
            this.btnUpdateSelectedObj.Text = "Uppdatera valt objekt";
            this.btnUpdateSelectedObj.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedObj.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.imageStartLogotype);
            this.tabPage1.Controls.Add(this.labelMyShowings);
            this.tabPage1.Controls.Add(this.labelShowMyObjects);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.labelEmpName);
            this.tabPage1.Controls.Add(this.labelWelcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(234, 144);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(170, 33);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Välkommen";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.BackColor = System.Drawing.Color.Transparent;
            this.labelEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.Location = new System.Drawing.Point(410, 144);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(211, 31);
            this.labelEmpName.TabIndex = 1;
            this.labelEmpName.Text = "GetEmpName();";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 402);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(416, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(393, 402);
            this.dataGridView2.TabIndex = 3;
            // 
            // labelShowMyObjects
            // 
            this.labelShowMyObjects.AutoSize = true;
            this.labelShowMyObjects.Location = new System.Drawing.Point(135, 192);
            this.labelShowMyObjects.Name = "labelShowMyObjects";
            this.labelShowMyObjects.Size = new System.Drawing.Size(72, 13);
            this.labelShowMyObjects.TabIndex = 4;
            this.labelShowMyObjects.Text = "Dina objekt";
            // 
            // labelMyShowings
            // 
            this.labelMyShowings.AutoSize = true;
            this.labelMyShowings.Location = new System.Drawing.Point(551, 192);
            this.labelMyShowings.Name = "labelMyShowings";
            this.labelMyShowings.Size = new System.Drawing.Size(123, 13);
            this.labelMyShowings.TabIndex = 5;
            this.labelMyShowings.Text = "Kommande visningar";
            // 
            // imageStartLogotype
            // 
            this.imageStartLogotype.BackColor = System.Drawing.Color.Transparent;
            this.imageStartLogotype.Image = ((System.Drawing.Image)(resources.GetObject("imageStartLogotype.Image")));
            this.imageStartLogotype.Location = new System.Drawing.Point(250, 0);
            this.imageStartLogotype.Name = "imageStartLogotype";
            this.imageStartLogotype.Size = new System.Drawing.Size(333, 138);
            this.imageStartLogotype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageStartLogotype.TabIndex = 6;
            this.imageStartLogotype.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPageVisning);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-2, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(825, 653);
            this.tabControl.TabIndex = 0;
            // 
            // EmployeeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 664);
            this.Controls.Add(this.tabControl);
            this.Name = "EmployeeFrame";
            this.Text = "EmployeeFrame";
            this.tabPageVisning.ResumeLayout(false);
            this.groupBoxVisning.ResumeLayout(false);
            this.groupBoxVisning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProspectiveBuyerShowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectShowing)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObject)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageStartLogotype)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageVisning;
        private System.Windows.Forms.GroupBox groupBoxVisning;
        private System.Windows.Forms.DataGridView dgvObjectShowing;
        private System.Windows.Forms.DataGridView dgvProspectiveBuyerShowing;
        private System.Windows.Forms.DateTimePicker dtpVisningsdatumVisning;
        private System.Windows.Forms.Label lblObjektVisning;
        private System.Windows.Forms.Label lblDatumVisning;
        private System.Windows.Forms.Button btnDeleteShowing;
        private System.Windows.Forms.Button btnAddShowing;
        private System.Windows.Forms.Label lblSpekulantVisning;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbProspectiveBuyerEmail;
        private System.Windows.Forms.TextBox tbBuyerTel;
        private System.Windows.Forms.TextBox tbBuyerName;
        private System.Windows.Forms.TextBox tbBuyerSsn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddProspectiveBuyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelBuyerContact;
        private System.Windows.Forms.Label labelBuyerTel;
        private System.Windows.Forms.Label labelBuyerName;
        private System.Windows.Forms.Label labelBuyerSsn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdateSelectedObj;
        private System.Windows.Forms.Label lblObjCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnObjectSearch;
        private System.Windows.Forms.TextBox tbObjSearch;
        private System.Windows.Forms.TextBox tbPricePerKvm;
        private System.Windows.Forms.TextBox tbObjectArea;
        private System.Windows.Forms.TextBox tbUnitType;
        private System.Windows.Forms.TextBox tbNrOfRooms;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dgvObject;
        private System.Windows.Forms.Label lblUniType;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblNumberOfRooms;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPricePerKvm;
        private System.Windows.Forms.Label lblObjAddress;
        private System.Windows.Forms.PictureBox picBoxShowObj;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox imageStartLogotype;
        private System.Windows.Forms.Label labelMyShowings;
        private System.Windows.Forms.Label labelShowMyObjects;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.TabControl tabControl;

    }
}