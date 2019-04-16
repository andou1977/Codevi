namespace ProjetFenetreCodevi
{
    partial class Fenpret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fenpret));
            this.button1 = new System.Windows.Forms.Button();
            this.txtcodecompte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bteffectuer = new System.Windows.Forms.Button();
            this.btannuler = new System.Windows.Forms.Button();
            this.lbsolde = new System.Windows.Forms.Label();
            this.txtsolde = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdevise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttaux = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(300, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "&Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcodecompte
            // 
            this.txtcodecompte.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodecompte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcodecompte.Location = new System.Drawing.Point(137, 107);
            this.txtcodecompte.Name = "txtcodecompte";
            this.txtcodecompte.Size = new System.Drawing.Size(145, 25);
            this.txtcodecompte.TabIndex = 19;
            this.txtcodecompte.Click += new System.EventHandler(this.txtcodecompte_Click);
            this.txtcodecompte.TextChanged += new System.EventHandler(this.txtcodecompte_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(18, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Code Compte";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Enregistrer  pret\r\n\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bteffectuer
            // 
            this.bteffectuer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteffectuer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bteffectuer.Location = new System.Drawing.Point(209, 332);
            this.bteffectuer.Name = "bteffectuer";
            this.bteffectuer.Size = new System.Drawing.Size(91, 25);
            this.bteffectuer.TabIndex = 21;
            this.bteffectuer.Text = "&Effectuer";
            this.bteffectuer.UseVisualStyleBackColor = true;
            this.bteffectuer.Click += new System.EventHandler(this.bteffectuer_Click);
            // 
            // btannuler
            // 
            this.btannuler.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btannuler.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btannuler.Location = new System.Drawing.Point(329, 332);
            this.btannuler.Name = "btannuler";
            this.btannuler.Size = new System.Drawing.Size(91, 25);
            this.btannuler.TabIndex = 22;
            this.btannuler.Text = "&Fermer";
            this.btannuler.UseVisualStyleBackColor = true;
            this.btannuler.Click += new System.EventHandler(this.btannuler_Click);
            // 
            // lbsolde
            // 
            this.lbsolde.AutoSize = true;
            this.lbsolde.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsolde.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbsolde.Location = new System.Drawing.Point(14, 163);
            this.lbsolde.Name = "lbsolde";
            this.lbsolde.Size = new System.Drawing.Size(96, 17);
            this.lbsolde.TabIndex = 23;
            this.lbsolde.Text = "Solde compte";
            this.lbsolde.Click += new System.EventHandler(this.lbsolde_Click);
            // 
            // txtsolde
            // 
            this.txtsolde.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsolde.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsolde.Location = new System.Drawing.Point(137, 159);
            this.txtsolde.Name = "txtsolde";
            this.txtsolde.ReadOnly = true;
            this.txtsolde.Size = new System.Drawing.Size(145, 26);
            this.txtsolde.TabIndex = 24;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb.Location = new System.Drawing.Point(14, 246);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(96, 17);
            this.lb.TabIndex = 25;
            this.lb.Text = "Montant Pret";
            // 
            // txtmontant
            // 
            this.txtmontant.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmontant.Location = new System.Drawing.Point(137, 244);
            this.txtmontant.MaxLength = 12;
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(145, 25);
            this.txtmontant.TabIndex = 26;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(466, 369);
            this.shapeContainer1.TabIndex = 61;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 471;
            this.lineShape1.Y1 = 146;
            this.lineShape1.Y2 = 146;
            // 
            // label6
            // 
            this.label6.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label6.Location = new System.Drawing.Point(-1, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 68);
            this.label6.TabIndex = 60;
            // 
            // txtdevise
            // 
            this.txtdevise.Enabled = false;
            this.txtdevise.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdevise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdevise.Location = new System.Drawing.Point(137, 204);
            this.txtdevise.Name = "txtdevise";
            this.txtdevise.Size = new System.Drawing.Size(145, 25);
            this.txtdevise.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(14, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Devise";
            // 
            // txttaux
            // 
            this.txttaux.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaux.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txttaux.Location = new System.Drawing.Point(137, 286);
            this.txttaux.Name = "txttaux";
            this.txttaux.Size = new System.Drawing.Size(145, 25);
            this.txttaux.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(14, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Interet (%)";
            // 
            // Fenpret
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 369);
            this.Controls.Add(this.txttaux);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdevise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtsolde);
            this.Controls.Add(this.lbsolde);
            this.Controls.Add(this.btannuler);
            this.Controls.Add(this.bteffectuer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcodecompte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fenpret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrer pret";
            this.Load += new System.EventHandler(this.Fenpret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcodecompte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bteffectuer;
        private System.Windows.Forms.Button btannuler;
        private System.Windows.Forms.Label lbsolde;
        private System.Windows.Forms.TextBox txtsolde;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtdevise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttaux;
        private System.Windows.Forms.Label label5;
    }
}