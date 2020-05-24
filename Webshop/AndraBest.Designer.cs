namespace Webshop
{
    partial class AndraBest
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxColors = new System.Windows.Forms.ComboBox();
            this.cbxPatterns = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.btnRadera = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Färg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mönster";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Märke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ändra beställning";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxColors
            // 
            this.cbxColors.FormattingEnabled = true;
            this.cbxColors.Items.AddRange(new object[] {
            "Svart",
            "Vit",
            "Röd",
            "Rosa",
            "Magneta",
            "Violett",
            "Blå",
            "Azur",
            "Cyan",
            "Spring green",
            "Grön",
            "Chartreuse",
            "Gul",
            "Orange",
            "Brun"});
            this.cbxColors.Location = new System.Drawing.Point(74, 285);
            this.cbxColors.Name = "cbxColors";
            this.cbxColors.Size = new System.Drawing.Size(121, 21);
            this.cbxColors.TabIndex = 12;
            // 
            // cbxPatterns
            // 
            this.cbxPatterns.FormattingEnabled = true;
            this.cbxPatterns.Items.AddRange(new object[] {
            "Inget",
            "Fläckig",
            "Rutig",
            "Randig"});
            this.cbxPatterns.Location = new System.Drawing.Point(74, 220);
            this.cbxPatterns.Name = "cbxPatterns";
            this.cbxPatterns.Size = new System.Drawing.Size(121, 21);
            this.cbxPatterns.TabIndex = 11;
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Items.AddRange(new object[] {
            "Bailey",
            "Goorin",
            "Christys\' Of London",
            "New Era",
            "Lock & Co",
            "Past Present",
            "Borsalino"});
            this.cbxBrand.Location = new System.Drawing.Point(74, 152);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(121, 21);
            this.cbxBrand.TabIndex = 10;
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Items.AddRange(new object[] {
            "Mössa",
            "Keps",
            "Hatt"});
            this.cbxModel.Location = new System.Drawing.Point(74, 88);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(121, 21);
            this.cbxModel.TabIndex = 9;
            // 
            // btnRadera
            // 
            this.btnRadera.Location = new System.Drawing.Point(22, 335);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(112, 23);
            this.btnRadera.TabIndex = 18;
            this.btnRadera.Text = "Radera";
            this.btnRadera.UseVisualStyleBackColor = true;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(140, 335);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(112, 23);
            this.btnSpara.TabIndex = 19;
            this.btnSpara.Text = "Spara ändringar";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // AndraBest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 401);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnRadera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxColors);
            this.Controls.Add(this.cbxPatterns);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.cbxModel);
            this.Name = "AndraBest";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxColors;
        private System.Windows.Forms.ComboBox cbxPatterns;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.Button btnRadera;
        private System.Windows.Forms.Button btnSpara;
    }
}