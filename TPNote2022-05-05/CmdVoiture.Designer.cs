namespace TPNote2022_05_05
{
    partial class CmdVoiture
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Modèle = new System.Windows.Forms.ComboBox();
            this.lbl_Modele = new System.Windows.Forms.Label();
            this.Couleur = new System.Windows.Forms.Label();
            this.cmb_Couleur = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.rb_prenium = new System.Windows.Forms.RadioButton();
            this.lbl_fini = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cmb_Modèle
            // 
            this.cmb_Modèle.FormattingEnabled = true;
            this.cmb_Modèle.Location = new System.Drawing.Point(217, 43);
            this.cmb_Modèle.Name = "cmb_Modèle";
            this.cmb_Modèle.Size = new System.Drawing.Size(177, 21);
            this.cmb_Modèle.TabIndex = 2;
            // 
            // lbl_Modele
            // 
            this.lbl_Modele.AutoSize = true;
            this.lbl_Modele.Location = new System.Drawing.Point(131, 43);
            this.lbl_Modele.Name = "lbl_Modele";
            this.lbl_Modele.Size = new System.Drawing.Size(42, 13);
            this.lbl_Modele.TabIndex = 3;
            this.lbl_Modele.Text = "Modèle";
            // 
            // Couleur
            // 
            this.Couleur.AutoSize = true;
            this.Couleur.Location = new System.Drawing.Point(131, 81);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(43, 13);
            this.Couleur.TabIndex = 5;
            this.Couleur.Text = "Couleur";
            // 
            // cmb_Couleur
            // 
            this.cmb_Couleur.FormattingEnabled = true;
            this.cmb_Couleur.Location = new System.Drawing.Point(217, 81);
            this.cmb_Couleur.Name = "cmb_Couleur";
            this.cmb_Couleur.Size = new System.Drawing.Size(177, 21);
            this.cmb_Couleur.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(471, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 347);
            this.panel1.TabIndex = 6;
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Location = new System.Drawing.Point(217, 131);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(58, 17);
            this.rb_normal.TabIndex = 7;
            this.rb_normal.TabStop = true;
            this.rb_normal.Text = "Normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            // 
            // rb_prenium
            // 
            this.rb_prenium.AutoSize = true;
            this.rb_prenium.Location = new System.Drawing.Point(309, 131);
            this.rb_prenium.Name = "rb_prenium";
            this.rb_prenium.Size = new System.Drawing.Size(63, 17);
            this.rb_prenium.TabIndex = 8;
            this.rb_prenium.TabStop = true;
            this.rb_prenium.Text = "Prenium";
            this.rb_prenium.UseVisualStyleBackColor = false;
            // 
            // lbl_fini
            // 
            this.lbl_fini.AutoSize = true;
            this.lbl_fini.Location = new System.Drawing.Point(131, 131);
            this.lbl_fini.Name = "lbl_fini";
            this.lbl_fini.Size = new System.Drawing.Size(47, 13);
            this.lbl_fini.TabIndex = 9;
            this.lbl_fini.Text = "Finission";
            // 
            // CmdVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 438);
            this.Controls.Add(this.lbl_fini);
            this.Controls.Add(this.rb_prenium);
            this.Controls.Add(this.rb_normal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Couleur);
            this.Controls.Add(this.cmb_Couleur);
            this.Controls.Add(this.lbl_Modele);
            this.Controls.Add(this.cmb_Modèle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CmdVoiture";
            this.Text = "CmdVoiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Modèle;
        private System.Windows.Forms.Label lbl_Modele;
        private System.Windows.Forms.Label Couleur;
        private System.Windows.Forms.ComboBox cmb_Couleur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.RadioButton rb_prenium;
        private System.Windows.Forms.Label lbl_fini;
    }
}