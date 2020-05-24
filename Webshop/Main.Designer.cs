namespace Webshop
{
    partial class Main
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
            this.btnNyBestallning = new System.Windows.Forms.Button();
            this.btnMinaBestallningar = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnÄndraBestallning = new System.Windows.Forms.Button();
            this.lblKundID = new System.Windows.Forms.Label();
            this.tbxBestallningar = new System.Windows.Forms.TextBox();
            this.lbxBest = new System.Windows.Forms.ListBox();
            this.btnCheckShipping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mina Beställningar";
            // 
            // btnNyBestallning
            // 
            this.btnNyBestallning.Location = new System.Drawing.Point(46, 199);
            this.btnNyBestallning.Name = "btnNyBestallning";
            this.btnNyBestallning.Size = new System.Drawing.Size(150, 23);
            this.btnNyBestallning.TabIndex = 2;
            this.btnNyBestallning.Text = "Ny beställning";
            this.btnNyBestallning.UseVisualStyleBackColor = true;
            this.btnNyBestallning.Click += new System.EventHandler(this.btnNyBestallning_Click);
            // 
            // btnMinaBestallningar
            // 
            this.btnMinaBestallningar.Location = new System.Drawing.Point(46, 237);
            this.btnMinaBestallningar.Name = "btnMinaBestallningar";
            this.btnMinaBestallningar.Size = new System.Drawing.Size(150, 23);
            this.btnMinaBestallningar.TabIndex = 3;
            this.btnMinaBestallningar.Text = "Mina beställningar";
            this.btnMinaBestallningar.UseVisualStyleBackColor = true;
            this.btnMinaBestallningar.Click += new System.EventHandler(this.btnMinaBestallningar_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(456, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Namn";
            // 
            // btnÄndraBestallning
            // 
            this.btnÄndraBestallning.Location = new System.Drawing.Point(46, 276);
            this.btnÄndraBestallning.Name = "btnÄndraBestallning";
            this.btnÄndraBestallning.Size = new System.Drawing.Size(150, 23);
            this.btnÄndraBestallning.TabIndex = 5;
            this.btnÄndraBestallning.Text = "Ändra beställning";
            this.btnÄndraBestallning.UseVisualStyleBackColor = true;
            this.btnÄndraBestallning.Click += new System.EventHandler(this.btnÄndraBestallning_Click);
            // 
            // lblKundID
            // 
            this.lblKundID.AutoSize = true;
            this.lblKundID.Location = new System.Drawing.Point(456, 23);
            this.lblKundID.Name = "lblKundID";
            this.lblKundID.Size = new System.Drawing.Size(49, 13);
            this.lblKundID.TabIndex = 6;
            this.lblKundID.Text = "Kund ID:";
            // 
            // tbxBestallningar
            // 
            this.tbxBestallningar.Location = new System.Drawing.Point(260, 100);
            this.tbxBestallningar.Multiline = true;
            this.tbxBestallningar.Name = "tbxBestallningar";
            this.tbxBestallningar.ReadOnly = true;
            this.tbxBestallningar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxBestallningar.Size = new System.Drawing.Size(245, 160);
            this.tbxBestallningar.TabIndex = 7;
            // 
            // lbxBest
            // 
            this.lbxBest.FormattingEnabled = true;
            this.lbxBest.HorizontalScrollbar = true;
            this.lbxBest.Location = new System.Drawing.Point(46, 67);
            this.lbxBest.Name = "lbxBest";
            this.lbxBest.Size = new System.Drawing.Size(150, 108);
            this.lbxBest.TabIndex = 8;
            this.lbxBest.SelectedIndexChanged += new System.EventHandler(this.lbxBest_SelectedIndexChanged);
            // 
            // btnCheckShipping
            // 
            this.btnCheckShipping.Location = new System.Drawing.Point(355, 276);
            this.btnCheckShipping.Name = "btnCheckShipping";
            this.btnCheckShipping.Size = new System.Drawing.Size(150, 23);
            this.btnCheckShipping.TabIndex = 9;
            this.btnCheckShipping.Text = "Kolla frakt på beställning";
            this.btnCheckShipping.UseVisualStyleBackColor = true;
            this.btnCheckShipping.Click += new System.EventHandler(this.btnCheckShipping_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 340);
            this.Controls.Add(this.btnCheckShipping);
            this.Controls.Add(this.lbxBest);
            this.Controls.Add(this.tbxBestallningar);
            this.Controls.Add(this.lblKundID);
            this.Controls.Add(this.btnÄndraBestallning);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnMinaBestallningar);
            this.Controls.Add(this.btnNyBestallning);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNyBestallning;
        private System.Windows.Forms.Button btnMinaBestallningar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnÄndraBestallning;
        private System.Windows.Forms.Label lblKundID;
        private System.Windows.Forms.TextBox tbxBestallningar;
        private System.Windows.Forms.ListBox lbxBest;
        private System.Windows.Forms.Button btnCheckShipping;
    }
}