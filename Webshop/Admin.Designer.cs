namespace Webshop
{
    partial class Admin
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
            this.tbxInBestallning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIpAddress = new System.Windows.Forms.TextBox();
            this.btnSendInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFraktTid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxInBestallning
            // 
            this.tbxInBestallning.Enabled = false;
            this.tbxInBestallning.Location = new System.Drawing.Point(12, 113);
            this.tbxInBestallning.Multiline = true;
            this.tbxInBestallning.Name = "tbxInBestallning";
            this.tbxInBestallning.Size = new System.Drawing.Size(150, 120);
            this.tbxInBestallning.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inkommande beställning";
            // 
            // tbxIpAddress
            // 
            this.tbxIpAddress.Enabled = false;
            this.tbxIpAddress.Location = new System.Drawing.Point(12, 257);
            this.tbxIpAddress.Name = "tbxIpAddress";
            this.tbxIpAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxIpAddress.TabIndex = 2;
            // 
            // btnSendInfo
            // 
            this.btnSendInfo.Location = new System.Drawing.Point(187, 316);
            this.btnSendInfo.Name = "btnSendInfo";
            this.btnSendInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSendInfo.TabIndex = 3;
            this.btnSendInfo.Text = "Skicka";
            this.btnSendInfo.UseVisualStyleBackColor = true;
            this.btnSendInfo.Click += new System.EventHandler(this.btnSendInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tid för frakt (timmar)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kundservice - Frakt hjälp";
            // 
            // tbxFraktTid
            // 
            this.tbxFraktTid.Location = new System.Drawing.Point(12, 319);
            this.tbxFraktTid.Name = "tbxFraktTid";
            this.tbxFraktTid.Size = new System.Drawing.Size(100, 20);
            this.tbxFraktTid.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Klients IP-adress";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxFraktTid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendInfo);
            this.Controls.Add(this.tbxIpAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxInBestallning);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInBestallning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIpAddress;
        private System.Windows.Forms.Button btnSendInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFraktTid;
        private System.Windows.Forms.Label label4;
    }
}