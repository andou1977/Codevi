namespace ProjetFenetreCodevi
{
    partial class Fenretrait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fenretrait));
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcodecompte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.bteffectuer = new System.Windows.Forms.Button();
            this.btannuler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdepot = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(0, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Effectuer retrait";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(314, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcodecompte
            // 
            this.txtcodecompte.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodecompte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcodecompte.Location = new System.Drawing.Point(150, 108);
            this.txtcodecompte.Name = "txtcodecompte";
            this.txtcodecompte.Size = new System.Drawing.Size(159, 25);
            this.txtcodecompte.TabIndex = 14;
            this.txtcodecompte.Click += new System.EventHandler(this.txtcodecompte_Click);
            this.txtcodecompte.TextChanged += new System.EventHandler(this.txtcodecompte_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Code Compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(22, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Montant  compte";
            // 
            // txtmontant
            // 
            this.txtmontant.Enabled = false;
            this.txtmontant.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmontant.HideSelection = false;
            this.txtmontant.Location = new System.Drawing.Point(150, 177);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.ReadOnly = true;
            this.txtmontant.Size = new System.Drawing.Size(159, 25);
            this.txtmontant.TabIndex = 17;
            // 
            // bteffectuer
            // 
            this.bteffectuer.Enabled = false;
            this.bteffectuer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteffectuer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bteffectuer.Location = new System.Drawing.Point(150, 259);
            this.bteffectuer.Name = "bteffectuer";
            this.bteffectuer.Size = new System.Drawing.Size(74, 25);
            this.bteffectuer.TabIndex = 18;
            this.bteffectuer.Text = "&Effectuer";
            this.bteffectuer.UseVisualStyleBackColor = true;
            this.bteffectuer.Click += new System.EventHandler(this.bteffectuer_Click);
            this.bteffectuer.MouseHover += new System.EventHandler(this.bteffectuer_MouseHover);
            // 
            // btannuler
            // 
            this.btannuler.Enabled = false;
            this.btannuler.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btannuler.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btannuler.Location = new System.Drawing.Point(243, 259);
            this.btannuler.Name = "btannuler";
            this.btannuler.Size = new System.Drawing.Size(66, 25);
            this.btannuler.TabIndex = 19;
            this.btannuler.Text = "&Fermer";
            this.btannuler.UseVisualStyleBackColor = true;
            this.btannuler.Click += new System.EventHandler(this.btannuler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(22, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Montant retrait";
            // 
            // txtdepot
            // 
            this.txtdepot.Enabled = false;
            this.txtdepot.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdepot.HideSelection = false;
            this.txtdepot.Location = new System.Drawing.Point(150, 208);
            this.txtdepot.MaxLength = 12;
            this.txtdepot.Name = "txtdepot";
            this.txtdepot.Size = new System.Drawing.Size(159, 25);
            this.txtdepot.TabIndex = 21;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(415, 291);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 418;
            this.lineShape1.Y1 = 144;
            this.lineShape1.Y2 = 144;
            // 
            // label6
            // 
            this.label6.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 70);
            this.label6.TabIndex = 59;
            // 
            // Fenretrait
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 291);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdepot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btannuler);
            this.Controls.Add(this.bteffectuer);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcodecompte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fenretrait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Effectuer retrait";
            this.Load += new System.EventHandler(this.Fendepot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcodecompte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Button bteffectuer;
        private System.Windows.Forms.Button btannuler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdepot;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label6;
    }
}