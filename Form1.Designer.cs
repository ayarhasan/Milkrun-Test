namespace MilkrunTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lstMainWareHouse = new System.Windows.Forms.ListBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstStore = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBoxAccept = new System.Windows.Forms.Button();
            this.btnSenMaintoStore = new System.Windows.Forms.Button();
            this.btnSendStoreToMain = new System.Windows.Forms.Button();
            this.lstTodoList = new System.Windows.Forms.ListBox();
            this.btnTransferAcceptByDeliveryNote = new System.Windows.Forms.Button();
            this.RefreshList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(3, 7);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(343, 23);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://ddhozel.logo.com.tr/Milkrun";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Green;
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(352, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 57);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "1-Baglan";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(3, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(159, 23);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(185, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // lstMainWareHouse
            // 
            this.lstMainWareHouse.FormattingEnabled = true;
            this.lstMainWareHouse.ItemHeight = 15;
            this.lstMainWareHouse.Location = new System.Drawing.Point(6, 104);
            this.lstMainWareHouse.Name = "lstMainWareHouse";
            this.lstMainWareHouse.Size = new System.Drawing.Size(324, 244);
            this.lstMainWareHouse.TabIndex = 4;
            this.lstMainWareHouse.DoubleClick += new System.EventHandler(this.lstMainWareHouse_DoubleClick);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(473, 7);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToken.Size = new System.Drawing.Size(315, 52);
            this.txtToken.TabIndex = 5;
            this.txtToken.Text = "Token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Merkez Depolar (duble clik )";
            // 
            // lstStore
            // 
            this.lstStore.FormattingEnabled = true;
            this.lstStore.ItemHeight = 15;
            this.lstStore.Location = new System.Drawing.Point(427, 104);
            this.lstStore.Name = "lstStore";
            this.lstStore.Size = new System.Drawing.Size(316, 244);
            this.lstStore.TabIndex = 7;
            this.lstStore.DoubleClick += new System.EventHandler(this.lstStore_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mağaza Depolar  (duble clik )";
            // 
            // btnBoxAccept
            // 
            this.btnBoxAccept.Location = new System.Drawing.Point(6, 354);
            this.btnBoxAccept.Name = "btnBoxAccept";
            this.btnBoxAccept.Size = new System.Drawing.Size(156, 27);
            this.btnBoxAccept.TabIndex = 9;
            this.btnBoxAccept.Text = "2-Ana Depoya Kutu Yükle";
            this.btnBoxAccept.UseVisualStyleBackColor = true;
            this.btnBoxAccept.Click += new System.EventHandler(this.btnBoxAccept_Click);
            // 
            // btnSenMaintoStore
            // 
            this.btnSenMaintoStore.Location = new System.Drawing.Point(336, 124);
            this.btnSenMaintoStore.Name = "btnSenMaintoStore";
            this.btnSenMaintoStore.Size = new System.Drawing.Size(87, 64);
            this.btnSenMaintoStore.TabIndex = 10;
            this.btnSenMaintoStore.Text = "3-Anadepodan Magazaya Gönder";
            this.btnSenMaintoStore.UseVisualStyleBackColor = true;
            this.btnSenMaintoStore.Click += new System.EventHandler(this.btnSenMaintoStore_Click);
            // 
            // btnSendStoreToMain
            // 
            this.btnSendStoreToMain.Location = new System.Drawing.Point(336, 264);
            this.btnSendStoreToMain.Name = "btnSendStoreToMain";
            this.btnSendStoreToMain.Size = new System.Drawing.Size(87, 64);
            this.btnSendStoreToMain.TabIndex = 11;
            this.btnSendStoreToMain.Text = "6-Magazadan Anadepoya Gönder";
            this.btnSendStoreToMain.UseVisualStyleBackColor = true;
            this.btnSendStoreToMain.Click += new System.EventHandler(this.btnSendStoreToMain_Click);
            // 
            // lstTodoList
            // 
            this.lstTodoList.FormattingEnabled = true;
            this.lstTodoList.ItemHeight = 15;
            this.lstTodoList.Location = new System.Drawing.Point(3, 427);
            this.lstTodoList.Name = "lstTodoList";
            this.lstTodoList.Size = new System.Drawing.Size(563, 214);
            this.lstTodoList.TabIndex = 12;
            // 
            // btnTransferAcceptByDeliveryNote
            // 
            this.btnTransferAcceptByDeliveryNote.Location = new System.Drawing.Point(572, 487);
            this.btnTransferAcceptByDeliveryNote.Name = "btnTransferAcceptByDeliveryNote";
            this.btnTransferAcceptByDeliveryNote.Size = new System.Drawing.Size(156, 27);
            this.btnTransferAcceptByDeliveryNote.TabIndex = 13;
            this.btnTransferAcceptByDeliveryNote.Text = "5-8-İşlem Kabülü Yap";
            this.btnTransferAcceptByDeliveryNote.UseVisualStyleBackColor = true;
            this.btnTransferAcceptByDeliveryNote.Click += new System.EventHandler(this.btnTransferAcceptByDeliveryNote_Click);
            // 
            // RefreshList
            // 
            this.RefreshList.Location = new System.Drawing.Point(572, 427);
            this.RefreshList.Name = "RefreshList";
            this.RefreshList.Size = new System.Drawing.Size(156, 23);
            this.RefreshList.TabIndex = 14;
            this.RefreshList.Text = "4-7-Güncelle";
            this.RefreshList.UseVisualStyleBackColor = true;
            this.RefreshList.Click += new System.EventHandler(this.RefreshList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kabul Bekleyem işlemler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RefreshList);
            this.Controls.Add(this.btnTransferAcceptByDeliveryNote);
            this.Controls.Add(this.lstTodoList);
            this.Controls.Add(this.btnSendStoreToMain);
            this.Controls.Add(this.btnSenMaintoStore);
            this.Controls.Add(this.btnBoxAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lstMainWareHouse);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Milkrun Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUrl;
        private Button btnConnect;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private ListBox lstMainWareHouse;
        private TextBox txtToken;
        private Label label1;
        private ListBox lstStore;
        private Label label2;
        private Button btnBoxAccept;
        private Button btnSenMaintoStore;
        private Button btnSendStoreToMain;
        private ListBox lstTodoList;
        private Button btnTransferAcceptByDeliveryNote;
        private Button RefreshList;
        private Label label3;
    }
}