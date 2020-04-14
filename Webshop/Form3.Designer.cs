namespace Webshop
{
    partial class Form3
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
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.cbxSpeModel = new System.Windows.Forms.ComboBox();
            this.cbxPatterns = new System.Windows.Forms.ComboBox();
            this.cbxColors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSparaKöp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Items.AddRange(new object[] {
            "Mössa",
            "Keps",
            "Hatt"});
            this.cbxModel.Location = new System.Drawing.Point(76, 108);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(121, 21);
            this.cbxModel.TabIndex = 0;
            // 
            // cbxSpeModel
            // 
            this.cbxSpeModel.FormattingEnabled = true;
            this.cbxSpeModel.Location = new System.Drawing.Point(76, 171);
            this.cbxSpeModel.Name = "cbxSpeModel";
            this.cbxSpeModel.Size = new System.Drawing.Size(121, 21);
            this.cbxSpeModel.TabIndex = 1;
            // 
            // cbxPatterns
            // 
            this.cbxPatterns.FormattingEnabled = true;
            this.cbxPatterns.Location = new System.Drawing.Point(76, 233);
            this.cbxPatterns.Name = "cbxPatterns";
            this.cbxPatterns.Size = new System.Drawing.Size(121, 21);
            this.cbxPatterns.TabIndex = 2;
            // 
            // cbxColors
            // 
            this.cbxColors.FormattingEnabled = true;
            this.cbxColors.Location = new System.Drawing.Point(76, 295);
            this.cbxColors.Name = "cbxColors";
            this.cbxColors.Size = new System.Drawing.Size(121, 21);
            this.cbxColors.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ny beställning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Specifik model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mönster";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Färg";
            // 
            // btnSparaKöp
            // 
            this.btnSparaKöp.Location = new System.Drawing.Point(76, 340);
            this.btnSparaKöp.Name = "btnSparaKöp";
            this.btnSparaKöp.Size = new System.Drawing.Size(112, 23);
            this.btnSparaKöp.TabIndex = 9;
            this.btnSparaKöp.Text = "Spara beställning";
            this.btnSparaKöp.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 401);
            this.Controls.Add(this.btnSparaKöp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxColors);
            this.Controls.Add(this.cbxPatterns);
            this.Controls.Add(this.cbxSpeModel);
            this.Controls.Add(this.cbxModel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxSpeModel;
        private System.Windows.Forms.ComboBox cbxPatterns;
        private System.Windows.Forms.ComboBox cbxColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSparaKöp;
    }
}