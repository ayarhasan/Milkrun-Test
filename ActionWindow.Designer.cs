namespace MilkrunTest
{
    partial class ActionWindow
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
            this.txtDeliveriNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerateDeliveryNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeliveriNote
            // 
            this.txtDeliveriNote.Location = new System.Drawing.Point(12, 27);
            this.txtDeliveriNote.Name = "txtDeliveriNote";
            this.txtDeliveriNote.Size = new System.Drawing.Size(349, 23);
            this.txtDeliveriNote.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İrsaliye Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(12, 81);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtQuantity.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(335, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerateDeliveryNote
            // 
            this.btnGenerateDeliveryNote.Location = new System.Drawing.Point(367, 27);
            this.btnGenerateDeliveryNote.Name = "btnGenerateDeliveryNote";
            this.btnGenerateDeliveryNote.Size = new System.Drawing.Size(48, 23);
            this.btnGenerateDeliveryNote.TabIndex = 5;
            this.btnGenerateDeliveryNote.Text = "...";
            this.btnGenerateDeliveryNote.UseVisualStyleBackColor = true;
            this.btnGenerateDeliveryNote.Click += new System.EventHandler(this.btnGenerateDeliveryNote_Click);
            // 
            // ActionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 149);
            this.Controls.Add(this.btnGenerateDeliveryNote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeliveriNote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionWindow";
            this.Text = "İrsaliye Numarası ve Miktarı Giriniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDeliveriNote;
        private Label label1;
        private Label label2;
        private TextBox txtQuantity;
        private Button button1;
        private Button btnGenerateDeliveryNote;
    }
}