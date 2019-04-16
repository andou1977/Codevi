namespace ProjetFenetreCodevi
{
    partial class FenChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenChanger));
            this.label6 = new System.Windows.Forms.Label();
            this.txtconfirmer = new System.Windows.Forms.TextBox();
            this.lbconfirmer = new System.Windows.Forms.Label();
            this.txtmotdepasse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btannuler = new System.Windows.Forms.Button();
            this.btenregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpseudo = new System.Windows.Forms.TextBox();
            this.txtactuel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(-1, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 36);
            this.label6.TabIndex = 88;
            this.label6.Text = "Changer son compte";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtconfirmer
            // 
            this.txtconfirmer.Location = new System.Drawing.Point(135, 243);
            this.txtconfirmer.Name = "txtconfirmer";
            this.txtconfirmer.PasswordChar = '*';
            this.txtconfirmer.Size = new System.Drawing.Size(155, 20);
            this.txtconfirmer.TabIndex = 4;
            // 
            // lbconfirmer
            // 
            this.lbconfirmer.AutoSize = true;
            this.lbconfirmer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfirmer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbconfirmer.Location = new System.Drawing.Point(29, 246);
            this.lbconfirmer.Name = "lbconfirmer";
            this.lbconfirmer.Size = new System.Drawing.Size(72, 17);
            this.lbconfirmer.TabIndex = 87;
            this.lbconfirmer.Text = "Confirmer ";
            // 
            // txtmotdepasse
            // 
            this.txtmotdepasse.Location = new System.Drawing.Point(135, 205);
            this.txtmotdepasse.Name = "txtmotdepasse";
            this.txtmotdepasse.PasswordChar = '*';
            this.txtmotdepasse.Size = new System.Drawing.Size(155, 20);
            this.txtmotdepasse.TabIndex = 3;
            this.txtmotdepasse.Click += new System.EventHandler(this.txtmotdepasse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(29, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Mot de passe";
            // 
            // btannuler
            // 
            this.btannuler.BackColor = System.Drawing.Color.White;
            this.btannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btannuler.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btannuler.Location = new System.Drawing.Point(224, 283);
            this.btannuler.Margin = new System.Windows.Forms.Padding(4);
            this.btannuler.Name = "btannuler";
            this.btannuler.Size = new System.Drawing.Size(66, 32);
            this.btannuler.TabIndex = 79;
            this.btannuler.Text = "&Fermer";
            this.btannuler.UseVisualStyleBackColor = false;
            this.btannuler.Click += new System.EventHandler(this.btannuler_Click);
            // 
            // btenregistrer
            // 
            this.btenregistrer.BackColor = System.Drawing.Color.White;
            this.btenregistrer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btenregistrer.Location = new System.Drawing.Point(135, 283);
            this.btenregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btenregistrer.Name = "btenregistrer";
            this.btenregistrer.Size = new System.Drawing.Size(72, 32);
            this.btenregistrer.TabIndex = 78;
            this.btenregistrer.Text = "&Enregistrer";
            this.btenregistrer.UseVisualStyleBackColor = false;
            this.btenregistrer.Click += new System.EventHandler(this.btenregistrer_Click);
            // 
            // label1
            // 
            this.label1.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 58);
            this.label1.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(29, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Pseudo";
            // 
            // txtpseudo
            // 
            this.txtpseudo.Location = new System.Drawing.Point(134, 166);
            this.txtpseudo.Name = "txtpseudo";
            this.txtpseudo.Size = new System.Drawing.Size(155, 20);
            this.txtpseudo.TabIndex = 2;
            // 
            // txtactuel
            // 
            this.txtactuel.Location = new System.Drawing.Point(135, 111);
            this.txtactuel.Name = "txtactuel";
            this.txtactuel.PasswordChar = '*';
            this.txtactuel.Size = new System.Drawing.Size(155, 20);
            this.txtactuel.TabIndex = 1;
            this.txtactuel.TextChanged += new System.EventHandler(this.txtactuel_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "Mot de passe actuel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(297, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 26);
            this.button1.TabIndex = 91;
            this.button1.Text = "&Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(353, 330);
            this.shapeContainer1.TabIndex = 92;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 352;
            this.lineShape1.Y1 = 142;
            this.lineShape1.Y2 = 142;
            // 
            // FenChanger
            // 
            this.AcceptButton = this.btenregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtactuel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtconfirmer);
            this.Controls.Add(this.lbconfirmer);
            this.Controls.Add(this.txtmotdepasse);
            this.Controls.Add(this.txtpseudo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btannuler);
            this.Controls.Add(this.btenregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FenChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changer Connexion";
            this.Load += new System.EventHandler(this.FenChanger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtconfirmer;
        private System.Windows.Forms.Label lbconfirmer;
        private System.Windows.Forms.TextBox txtmotdepasse;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btannuler;
        internal System.Windows.Forms.Button btenregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpseudo;
        private System.Windows.Forms.TextBox txtactuel;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}