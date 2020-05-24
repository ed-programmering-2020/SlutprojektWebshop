namespace Webshop
{
    partial class Registrera
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
            this.tbxFornamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxAnvandarnamn = new System.Windows.Forms.TextBox();
            this.tbxLosenord1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxLosenord2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxFornamn
            // 
            this.tbxFornamn.Location = new System.Drawing.Point(118, 94);
            this.tbxFornamn.Name = "tbxFornamn";
            this.tbxFornamn.Size = new System.Drawing.Size(100, 20);
            this.tbxFornamn.TabIndex = 0;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(118, 133);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(100, 20);
            this.tbxEfternamn.TabIndex = 1;
            // 
            // tbxAnvandarnamn
            // 
            this.tbxAnvandarnamn.Location = new System.Drawing.Point(118, 171);
            this.tbxAnvandarnamn.Name = "tbxAnvandarnamn";
            this.tbxAnvandarnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxAnvandarnamn.TabIndex = 2;
            // 
            // tbxLosenord1
            // 
            this.tbxLosenord1.Location = new System.Drawing.Point(118, 206);
            this.tbxLosenord1.Name = "tbxLosenord1";
            this.tbxLosenord1.Size = new System.Drawing.Size(100, 20);
            this.tbxLosenord1.TabIndex = 3;
            this.tbxLosenord1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Användarnamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lösenord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Registrera ny användare";
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(81, 289);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(112, 23);
            this.btnRegistrera.TabIndex = 15;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bekräfta lösenord";
            // 
            // tbxLosenord2
            // 
            this.tbxLosenord2.Location = new System.Drawing.Point(118, 242);
            this.tbxLosenord2.Name = "tbxLosenord2";
            this.tbxLosenord2.Size = new System.Drawing.Size(100, 20);
            this.tbxLosenord2.TabIndex = 16;
            this.tbxLosenord2.UseSystemPasswordChar = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 341);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxLosenord2);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxLosenord1);
            this.Controls.Add(this.tbxAnvandarnamn);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFornamn);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFornamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxAnvandarnamn;
        private System.Windows.Forms.TextBox tbxLosenord1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxLosenord2;
    }
}