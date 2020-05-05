namespace Webshop
{
    partial class Form2
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
            this.lbxBestallningar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNyBestallning = new System.Windows.Forms.Button();
            this.btnMinaBestallningar = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnÄndraBestallning = new System.Windows.Forms.Button();
            this.kundID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxBestallningar
            // 
            this.lbxBestallningar.FormattingEnabled = true;
            this.lbxBestallningar.Location = new System.Drawing.Point(260, 100);
            this.lbxBestallningar.Name = "lbxBestallningar";
            this.lbxBestallningar.Size = new System.Drawing.Size(200, 199);
            this.lbxBestallningar.TabIndex = 0;
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
            this.btnNyBestallning.Location = new System.Drawing.Point(39, 100);
            this.btnNyBestallning.Name = "btnNyBestallning";
            this.btnNyBestallning.Size = new System.Drawing.Size(150, 23);
            this.btnNyBestallning.TabIndex = 2;
            this.btnNyBestallning.Text = "Ny beställning";
            this.btnNyBestallning.UseVisualStyleBackColor = true;
            this.btnNyBestallning.Click += new System.EventHandler(this.btnNyBestallning_Click);
            // 
            // btnMinaBestallningar
            // 
            this.btnMinaBestallningar.Location = new System.Drawing.Point(39, 138);
            this.btnMinaBestallningar.Name = "btnMinaBestallningar";
            this.btnMinaBestallningar.Size = new System.Drawing.Size(150, 23);
            this.btnMinaBestallningar.TabIndex = 3;
            this.btnMinaBestallningar.Text = "Mina beställningar";
            this.btnMinaBestallningar.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(405, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Användarnamn";
            // 
            // btnÄndraBestallning
            // 
            this.btnÄndraBestallning.Location = new System.Drawing.Point(39, 177);
            this.btnÄndraBestallning.Name = "btnÄndraBestallning";
            this.btnÄndraBestallning.Size = new System.Drawing.Size(150, 23);
            this.btnÄndraBestallning.TabIndex = 5;
            this.btnÄndraBestallning.Text = "Ändra beställning";
            this.btnÄndraBestallning.UseVisualStyleBackColor = true;
            this.btnÄndraBestallning.Click += new System.EventHandler(this.btnÄndraBestallning_Click);
            // 
            // kundID
            // 
            this.kundID.AutoSize = true;
            this.kundID.Location = new System.Drawing.Point(405, 22);
            this.kundID.Name = "kundID";
            this.kundID.Size = new System.Drawing.Size(49, 13);
            this.kundID.TabIndex = 6;
            this.kundID.Text = "Kund ID:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.kundID);
            this.Controls.Add(this.btnÄndraBestallning);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnMinaBestallningar);
            this.Controls.Add(this.btnNyBestallning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxBestallningar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBestallningar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNyBestallning;
        private System.Windows.Forms.Button btnMinaBestallningar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnÄndraBestallning;
        private System.Windows.Forms.Label kundID;
    }
}