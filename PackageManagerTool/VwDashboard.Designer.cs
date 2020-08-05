namespace PackageManagerTool
{
    partial class VwDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VwDashboard));
            this.pBoxBtnClose = new System.Windows.Forms.PictureBox();
            this.pBoxBtnPrint = new System.Windows.Forms.PictureBox();
            this.tBoxIMEI = new System.Windows.Forms.TextBox();
            this.pBoxMainUI = new System.Windows.Forms.PictureBox();
            this.pBoxDetailCard = new System.Windows.Forms.PictureBox();
            this.pBoxiPhoneView = new System.Windows.Forms.PictureBox();
            this.lblPhoneModel = new System.Windows.Forms.Label();
            this.lblPhoneColor = new System.Windows.Forms.Label();
            this.lblPhoneSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSerialNum = new System.Windows.Forms.Label();
            this.lblPartNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBtnPrint = new System.Windows.Forms.Label();
            this.pBoxHeadPhoneCards = new System.Windows.Forms.PictureBox();
            this.pBoxChargerCards = new System.Windows.Forms.PictureBox();
            this.pBoxCableCards = new System.Windows.Forms.PictureBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pboxbtnPackagingInstruction = new System.Windows.Forms.PictureBox();
            this.lblLcmType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBooklet = new System.Windows.Forms.Label();
            this.lblPackagingType = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblShipTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBtnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMainUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDetailCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxiPhoneView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHeadPhoneCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChargerCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCableCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxbtnPackagingInstruction)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxBtnClose
            // 
            this.pBoxBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.pBoxBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxBtnClose.Image = global::PackageManagerTool.Properties.Resources.mac_close_button;
            this.pBoxBtnClose.Location = new System.Drawing.Point(1061, 3);
            this.pBoxBtnClose.Name = "pBoxBtnClose";
            this.pBoxBtnClose.Size = new System.Drawing.Size(20, 20);
            this.pBoxBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBtnClose.TabIndex = 0;
            this.pBoxBtnClose.TabStop = false;
            this.pBoxBtnClose.Click += new System.EventHandler(this.pBoxBtnClose_Click);
            // 
            // pBoxBtnPrint
            // 
            this.pBoxBtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.pBoxBtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxBtnPrint.Image = global::PackageManagerTool.Properties.Resources.print_button_green;
            this.pBoxBtnPrint.Location = new System.Drawing.Point(657, 566);
            this.pBoxBtnPrint.Name = "pBoxBtnPrint";
            this.pBoxBtnPrint.Size = new System.Drawing.Size(73, 35);
            this.pBoxBtnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBtnPrint.TabIndex = 1;
            this.pBoxBtnPrint.TabStop = false;
            this.pBoxBtnPrint.Visible = false;
            this.pBoxBtnPrint.Click += new System.EventHandler(this.pBoxBtnPrint_Click);
            // 
            // tBoxIMEI
            // 
            this.tBoxIMEI.Location = new System.Drawing.Point(27, 50);
            this.tBoxIMEI.MaxLength = 15;
            this.tBoxIMEI.Name = "tBoxIMEI";
            this.tBoxIMEI.Size = new System.Drawing.Size(200, 20);
            this.tBoxIMEI.TabIndex = 2;
            this.tBoxIMEI.TextChanged += new System.EventHandler(this.tBoxIMEI_TextChanged);
            this.tBoxIMEI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxIMEI_KeyDown);
            // 
            // pBoxMainUI
            // 
            this.pBoxMainUI.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMainUI.Image = global::PackageManagerTool.Properties.Resources.new_main_ui_green;
            this.pBoxMainUI.Location = new System.Drawing.Point(10, 14);
            this.pBoxMainUI.Name = "pBoxMainUI";
            this.pBoxMainUI.Size = new System.Drawing.Size(245, 120);
            this.pBoxMainUI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxMainUI.TabIndex = 3;
            this.pBoxMainUI.TabStop = false;
            // 
            // pBoxDetailCard
            // 
            this.pBoxDetailCard.BackColor = System.Drawing.Color.Transparent;
            this.pBoxDetailCard.Image = global::PackageManagerTool.Properties.Resources.Minicards;
            this.pBoxDetailCard.Location = new System.Drawing.Point(8, 423);
            this.pBoxDetailCard.Name = "pBoxDetailCard";
            this.pBoxDetailCard.Size = new System.Drawing.Size(260, 97);
            this.pBoxDetailCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDetailCard.TabIndex = 4;
            this.pBoxDetailCard.TabStop = false;
            // 
            // pBoxiPhoneView
            // 
            this.pBoxiPhoneView.BackColor = System.Drawing.Color.Transparent;
            this.pBoxiPhoneView.Image = global::PackageManagerTool.Properties.Resources.iPhone_7_Silver;
            this.pBoxiPhoneView.Location = new System.Drawing.Point(27, 205);
            this.pBoxiPhoneView.Name = "pBoxiPhoneView";
            this.pBoxiPhoneView.Size = new System.Drawing.Size(84, 144);
            this.pBoxiPhoneView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxiPhoneView.TabIndex = 5;
            this.pBoxiPhoneView.TabStop = false;
            // 
            // lblPhoneModel
            // 
            this.lblPhoneModel.AutoSize = true;
            this.lblPhoneModel.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneModel.Location = new System.Drawing.Point(62, 170);
            this.lblPhoneModel.Name = "lblPhoneModel";
            this.lblPhoneModel.Size = new System.Drawing.Size(0, 29);
            this.lblPhoneModel.TabIndex = 6;
            // 
            // lblPhoneColor
            // 
            this.lblPhoneColor.AutoSize = true;
            this.lblPhoneColor.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneColor.Location = new System.Drawing.Point(117, 244);
            this.lblPhoneColor.Name = "lblPhoneColor";
            this.lblPhoneColor.Size = new System.Drawing.Size(66, 25);
            this.lblPhoneColor.TabIndex = 7;
            this.lblPhoneColor.Text = "Silver";
            // 
            // lblPhoneSize
            // 
            this.lblPhoneSize.AutoSize = true;
            this.lblPhoneSize.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhoneSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneSize.Location = new System.Drawing.Point(118, 279);
            this.lblPhoneSize.Name = "lblPhoneSize";
            this.lblPhoneSize.Size = new System.Drawing.Size(53, 22);
            this.lblPhoneSize.TabIndex = 8;
            this.lblPhoneSize.Text = "64GB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(23, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "S/N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(16, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Part No";
            // 
            // lblSerialNum
            // 
            this.lblSerialNum.AutoSize = true;
            this.lblSerialNum.BackColor = System.Drawing.Color.White;
            this.lblSerialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSerialNum.Location = new System.Drawing.Point(90, 439);
            this.lblSerialNum.Name = "lblSerialNum";
            this.lblSerialNum.Size = new System.Drawing.Size(0, 16);
            this.lblSerialNum.TabIndex = 11;
            // 
            // lblPartNo
            // 
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.BackColor = System.Drawing.Color.White;
            this.lblPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPartNo.Location = new System.Drawing.Point(100, 473);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(0, 16);
            this.lblPartNo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(316, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "What\'s in the Box";
            // 
            // lblBtnPrint
            // 
            this.lblBtnPrint.AutoSize = true;
            this.lblBtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnPrint.ForeColor = System.Drawing.Color.Green;
            this.lblBtnPrint.Location = new System.Drawing.Point(657, 601);
            this.lblBtnPrint.Name = "lblBtnPrint";
            this.lblBtnPrint.Size = new System.Drawing.Size(76, 16);
            this.lblBtnPrint.TabIndex = 14;
            this.lblBtnPrint.Text = "Alt + Space";
            this.lblBtnPrint.Visible = false;
            // 
            // pBoxHeadPhoneCards
            // 
            this.pBoxHeadPhoneCards.BackColor = System.Drawing.Color.Transparent;
            this.pBoxHeadPhoneCards.Image = global::PackageManagerTool.Properties.Resources.NO_HeadphoneCards;
            this.pBoxHeadPhoneCards.Location = new System.Drawing.Point(321, 102);
            this.pBoxHeadPhoneCards.Name = "pBoxHeadPhoneCards";
            this.pBoxHeadPhoneCards.Size = new System.Drawing.Size(447, 123);
            this.pBoxHeadPhoneCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxHeadPhoneCards.TabIndex = 15;
            this.pBoxHeadPhoneCards.TabStop = false;
            // 
            // pBoxChargerCards
            // 
            this.pBoxChargerCards.BackColor = System.Drawing.Color.Transparent;
            this.pBoxChargerCards.Image = global::PackageManagerTool.Properties.Resources.no_adapter;
            this.pBoxChargerCards.Location = new System.Drawing.Point(319, 241);
            this.pBoxChargerCards.Name = "pBoxChargerCards";
            this.pBoxChargerCards.Size = new System.Drawing.Size(447, 141);
            this.pBoxChargerCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxChargerCards.TabIndex = 16;
            this.pBoxChargerCards.TabStop = false;
            // 
            // pBoxCableCards
            // 
            this.pBoxCableCards.BackColor = System.Drawing.Color.Transparent;
            this.pBoxCableCards.Image = global::PackageManagerTool.Properties.Resources.CableCards;
            this.pBoxCableCards.Location = new System.Drawing.Point(319, 397);
            this.pBoxCableCards.Name = "pBoxCableCards";
            this.pBoxCableCards.Size = new System.Drawing.Size(447, 123);
            this.pBoxCableCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCableCards.TabIndex = 17;
            this.pBoxCableCards.TabStop = false;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(27, 49);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(192, 25);
            this.lblBarcode.TabIndex = 18;
            this.lblBarcode.Text = "355907865494532";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBarcode.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(38, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Package Manager Tool";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(185, 601);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(49, 16);
            this.lblVersion.TabIndex = 21;
            this.lblVersion.Text = "v1.0.21";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pboxbtnPackagingInstruction
            // 
            this.pboxbtnPackagingInstruction.BackColor = System.Drawing.Color.Transparent;
            this.pboxbtnPackagingInstruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxbtnPackagingInstruction.Image = global::PackageManagerTool.Properties.Resources.new_packaging_instruction_green;
            this.pboxbtnPackagingInstruction.Location = new System.Drawing.Point(1049, 88);
            this.pboxbtnPackagingInstruction.Name = "pboxbtnPackagingInstruction";
            this.pboxbtnPackagingInstruction.Size = new System.Drawing.Size(37, 465);
            this.pboxbtnPackagingInstruction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxbtnPackagingInstruction.TabIndex = 22;
            this.pboxbtnPackagingInstruction.TabStop = false;
            this.pboxbtnPackagingInstruction.Click += new System.EventHandler(this.pboxbtnPackagingInstruction_Click);
            // 
            // lblLcmType
            // 
            this.lblLcmType.AutoSize = true;
            this.lblLcmType.BackColor = System.Drawing.Color.Transparent;
            this.lblLcmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLcmType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLcmType.Location = new System.Drawing.Point(99, 529);
            this.lblLcmType.Name = "lblLcmType";
            this.lblLcmType.Size = new System.Drawing.Size(59, 25);
            this.lblLcmType.TabIndex = 23;
            this.lblLcmType.Text = "OQC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(114, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "LCM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBooklet
            // 
            this.lblBooklet.AutoSize = true;
            this.lblBooklet.BackColor = System.Drawing.Color.Transparent;
            this.lblBooklet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooklet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBooklet.Location = new System.Drawing.Point(326, 523);
            this.lblBooklet.Name = "lblBooklet";
            this.lblBooklet.Size = new System.Drawing.Size(131, 16);
            this.lblBooklet.TabIndex = 25;
            this.lblBooklet.Text = "+ Booklet w/ Writings";
            this.lblBooklet.Visible = false;
            // 
            // lblPackagingType
            // 
            this.lblPackagingType.BackColor = System.Drawing.Color.Transparent;
            this.lblPackagingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackagingType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPackagingType.Location = new System.Drawing.Point(555, 60);
            this.lblPackagingType.Name = "lblPackagingType";
            this.lblPackagingType.Size = new System.Drawing.Size(522, 23);
            this.lblPackagingType.TabIndex = 26;
            this.lblPackagingType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClient.Location = new System.Drawing.Point(119, 308);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(40, 9);
            this.lblClient.TabIndex = 27;
            this.lblClient.Text = "ECO - UK";
            this.lblClient.Click += new System.EventHandler(this.lblClient_Click);
            // 
            // lblShipTo
            // 
            this.lblShipTo.AutoSize = true;
            this.lblShipTo.BackColor = System.Drawing.Color.Transparent;
            this.lblShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShipTo.Location = new System.Drawing.Point(120, 340);
            this.lblShipTo.Name = "lblShipTo";
            this.lblShipTo.Size = new System.Drawing.Size(0, 9);
            this.lblShipTo.TabIndex = 28;
            // 
            // VwDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(197)))), ((int)(((byte)(91)))));
            this.BackgroundImage = global::PackageManagerTool.Properties.Resources.bg_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 620);
            this.Controls.Add(this.lblShipTo);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblPackagingType);
            this.Controls.Add(this.lblBooklet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLcmType);
            this.Controls.Add(this.pboxbtnPackagingInstruction);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.pBoxCableCards);
            this.Controls.Add(this.pBoxChargerCards);
            this.Controls.Add(this.pBoxHeadPhoneCards);
            this.Controls.Add(this.lblBtnPrint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPartNo);
            this.Controls.Add(this.lblSerialNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhoneSize);
            this.Controls.Add(this.lblPhoneColor);
            this.Controls.Add(this.lblPhoneModel);
            this.Controls.Add(this.pBoxiPhoneView);
            this.Controls.Add(this.pBoxDetailCard);
            this.Controls.Add(this.pBoxMainUI);
            this.Controls.Add(this.tBoxIMEI);
            this.Controls.Add(this.pBoxBtnPrint);
            this.Controls.Add(this.pBoxBtnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VwDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package Manager Tool";
            this.Load += new System.EventHandler(this.VwDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBtnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMainUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDetailCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxiPhoneView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHeadPhoneCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChargerCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCableCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxbtnPackagingInstruction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxBtnClose;
        private System.Windows.Forms.PictureBox pBoxBtnPrint;
        private System.Windows.Forms.TextBox tBoxIMEI;
        private System.Windows.Forms.PictureBox pBoxMainUI;
        private System.Windows.Forms.PictureBox pBoxDetailCard;
        private System.Windows.Forms.PictureBox pBoxiPhoneView;
        private System.Windows.Forms.Label lblPhoneModel;
        private System.Windows.Forms.Label lblPhoneColor;
        private System.Windows.Forms.Label lblPhoneSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSerialNum;
        private System.Windows.Forms.Label lblPartNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBtnPrint;
        private System.Windows.Forms.PictureBox pBoxHeadPhoneCards;
        private System.Windows.Forms.PictureBox pBoxChargerCards;
        private System.Windows.Forms.PictureBox pBoxCableCards;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pboxbtnPackagingInstruction;
        private System.Windows.Forms.Label lblLcmType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBooklet;
        private System.Windows.Forms.Label lblPackagingType;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblShipTo;
    }
}

