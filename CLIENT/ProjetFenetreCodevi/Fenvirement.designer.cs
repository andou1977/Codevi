namespace ProjetFenetreCodevi
{
    partial class Fenvirement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fenvirement));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodecompte1 = new System.Windows.Forms.TextBox();
            this.txtcodecompte2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lberrorcp1 = new System.Windows.Forms.Label();
            this.lberrorcp2 = new System.Windows.Forms.Label();
            this.lbdevise = new System.Windows.Forms.Label();
            this.lbtaux = new System.Windows.Forms.Label();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.txttaux = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lberror2 = new System.Windows.Forms.Label();
            this.lberror1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(0, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Virement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(15, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = " Compte debiteur";
            // 
            // txtcodecompte1
            // 
            this.txtcodecompte1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodecompte1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcodecompte1.Location = new System.Drawing.Point(159, 120);
            this.txtcodecompte1.Name = "txtcodecompte1";
            this.txtcodecompte1.Size = new System.Drawing.Size(185, 25);
            this.txtcodecompte1.TabIndex = 16;
            this.txtcodecompte1.Click += new System.EventHandler(this.txtcodecompte1_Click);
            this.txtcodecompte1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcodecompte1_MouseClick);
            this.txtcodecompte1.TextChanged += new System.EventHandler(this.txtcodecompte1_TextChanged);
            // 
            // txtcodecompte2
            // 
            this.txtcodecompte2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodecompte2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcodecompte2.Location = new System.Drawing.Point(159, 167);
            this.txtcodecompte2.Name = "txtcodecompte2";
            this.txtcodecompte2.Size = new System.Drawing.Size(185, 25);
            this.txtcodecompte2.TabIndex = 18;
            this.txtcodecompte2.Click += new System.EventHandler(this.textBox1_Click);
            this.txtcodecompte2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcodecompte2_MouseClick);
            this.txtcodecompte2.TextChanged += new System.EventHandler(this.txtcodecompte2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(15, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = " Compte crediteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(15, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Montant";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lberrorcp1
            // 
            this.lberrorcp1.AutoSize = true;
            this.lberrorcp1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorcp1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lberrorcp1.Location = new System.Drawing.Point(378, 124);
            this.lberrorcp1.Name = "lberrorcp1";
            this.lberrorcp1.Size = new System.Drawing.Size(69, 15);
            this.lberrorcp1.TabIndex = 28;
            this.lberrorcp1.Text = "Introuvable";
            this.lberrorcp1.Visible = false;
            this.lberrorcp1.Click += new System.EventHandler(this.label7_Click);
            // 
            // lberrorcp2
            // 
            this.lberrorcp2.AutoSize = true;
            this.lberrorcp2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberrorcp2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lberrorcp2.Location = new System.Drawing.Point(378, 171);
            this.lberrorcp2.Name = "lberrorcp2";
            this.lberrorcp2.Size = new System.Drawing.Size(69, 15);
            this.lberrorcp2.TabIndex = 29;
            this.lberrorcp2.Text = "Introuvable";
            this.lberrorcp2.Visible = false;
            // 
            // lbdevise
            // 
            this.lbdevise.AutoSize = true;
            this.lbdevise.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdevise.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbdevise.Location = new System.Drawing.Point(264, 232);
            this.lbdevise.Name = "lbdevise";
            this.lbdevise.Size = new System.Drawing.Size(115, 17);
            this.lbdevise.TabIndex = 30;
            this.lbdevise.Text = "Valeur Numerique";
            this.lbdevise.Visible = false;
            // 
            // lbtaux
            // 
            this.lbtaux.AutoSize = true;
            this.lbtaux.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaux.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbtaux.Location = new System.Drawing.Point(15, 278);
            this.lbtaux.Name = "lbtaux";
            this.lbtaux.Size = new System.Drawing.Size(110, 17);
            this.lbtaux.TabIndex = 31;
            this.lbtaux.Text = "Taux d\'echange";
            this.lbtaux.Visible = false;
            // 
            // txtmontant
            // 
            this.txtmontant.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmontant.Location = new System.Drawing.Point(159, 222);
            this.txtmontant.MaxLength = 12;
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(105, 25);
            this.txtmontant.TabIndex = 34;
            this.txtmontant.Click += new System.EventHandler(this.textBox2_Click_1);
            this.txtmontant.TextChanged += new System.EventHandler(this.txtmontant_TextChanged);
            // 
            // txttaux
            // 
            this.txttaux.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaux.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txttaux.Location = new System.Drawing.Point(159, 276);
            this.txttaux.MaxLength = 3;
            this.txttaux.Name = "txttaux";
            this.txttaux.Size = new System.Drawing.Size(105, 25);
            this.txttaux.TabIndex = 35;
            this.txttaux.Click += new System.EventHandler(this.txttaux_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(231, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 36;
            this.button1.Text = "Effectuer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(350, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 26);
            this.button2.TabIndex = 37;
            this.button2.Text = "&Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lberror2
            // 
            this.lberror2.Location = new System.Drawing.Point(345, 167);
            this.lberror2.Name = "lberror2";
            this.lberror2.Size = new System.Drawing.Size(27, 23);
            this.lberror2.TabIndex = 26;
            this.lberror2.Visible = false;
            // 
            // lberror1
            // 
            this.lberror1.Location = new System.Drawing.Point(348, 120);
            this.lberror1.Name = "lberror1";
            this.lberror1.Size = new System.Drawing.Size(24, 23);
            this.lberror1.TabIndex = 25;
            this.lberror1.Visible = false;
            // 
            // label7
            // 
            this.label7.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(490, 58);
            this.label7.TabIndex = 62;
            // 
            // Fenvirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 346);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttaux);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.lbtaux);
            this.Controls.Add(this.lbdevise);
            this.Controls.Add(this.lberrorcp2);
            this.Controls.Add(this.lberrorcp1);
            this.Controls.Add(this.lberror2);
            this.Controls.Add(this.lberror1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodecompte2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodecompte1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fenvirement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virement";
            this.Load += new System.EventHandler(this.Fenvirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodecompte1;
        private System.Windows.Forms.TextBox txtcodecompte2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lberror1;
        private System.Windows.Forms.Label lberror2;
        private System.Windows.Forms.Label lberrorcp1;
        private System.Windows.Forms.Label lberrorcp2;
        private System.Windows.Forms.Label lbdevise;
        private System.Windows.Forms.Label lbtaux;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.TextBox txttaux;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}