﻿namespace Webshop
{
    partial class Frakt
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIPAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSendInfo = new System.Windows.Forms.Button();
            this.tbxFraktInfo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP-adress";
            // 
            // tbxIPAddress
            // 
            this.tbxIPAddress.Location = new System.Drawing.Point(12, 45);
            this.tbxIPAddress.Name = "tbxIPAddress";
            this.tbxIPAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxIPAddress.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(187, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Anslut";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSendInfo
            // 
            this.btnSendInfo.Location = new System.Drawing.Point(12, 260);
            this.btnSendInfo.Name = "btnSendInfo";
            this.btnSendInfo.Size = new System.Drawing.Size(150, 23);
            this.btnSendInfo.TabIndex = 3;
            this.btnSendInfo.Text = "Skicka förfrågan";
            this.btnSendInfo.UseVisualStyleBackColor = true;
            this.btnSendInfo.Click += new System.EventHandler(this.btnSendInfo_Click);
            // 
            // tbxFraktInfo
            // 
            this.tbxFraktInfo.Location = new System.Drawing.Point(12, 289);
            this.tbxFraktInfo.Multiline = true;
            this.tbxFraktInfo.Name = "tbxFraktInfo";
            this.tbxFraktInfo.Size = new System.Drawing.Size(200, 100);
            this.tbxFraktInfo.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Egna IP-adress";
            // 
            // Frakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbxFraktInfo);
            this.Controls.Add(this.btnSendInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxIPAddress);
            this.Controls.Add(this.label1);
            this.Name = "Frakt";
            this.Text = "Frakt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIPAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendInfo;
        private System.Windows.Forms.TextBox tbxFraktInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}