namespace ProjetFenetreCodevi
{
    partial class Fenrechercher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fenrechercher));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodecompte = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtetat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdatecreation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdevise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodeclient = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txttype = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-27, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rechercher Compte";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Code Compte";
            // 
            // txtcodecompte
            // 
            this.txtcodecompte.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodecompte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcodecompte.Location = new System.Drawing.Point(153, 88);
            this.txtcodecompte.Name = "txtcodecompte";
            this.txtcodecompte.Size = new System.Drawing.Size(188, 25);
            this.txtcodecompte.TabIndex = 11;
            this.txtcodecompte.Click += new System.EventHandler(this.txtcodecompte_Click);
            this.txtcodecompte.ModifiedChanged += new System.EventHandler(this.txtcodecompte_ModifiedChanged);
            this.txtcodecompte.TextChanged += new System.EventHandler(this.txtcodecompte_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(153, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(12, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 52);
            this.label8.TabIndex = 104;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(250, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 25);
            this.button2.TabIndex = 105;
            this.button2.Text = "&Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtetat
            // 
            this.txtetat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtetat.Enabled = false;
            this.txtetat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtetat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtetat.Location = new System.Drawing.Point(153, 335);
            this.txtetat.Name = "txtetat";
            this.txtetat.ReadOnly = true;
            this.txtetat.Size = new System.Drawing.Size(188, 25);
            this.txtetat.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(38, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 114;
            this.label7.Text = "Etat";
            // 
            // txtdatecreation
            // 
            this.txtdatecreation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtdatecreation.Enabled = false;
            this.txtdatecreation.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatecreation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdatecreation.Location = new System.Drawing.Point(153, 304);
            this.txtdatecreation.Name = "txtdatecreation";
            this.txtdatecreation.ReadOnly = true;
            this.txtdatecreation.Size = new System.Drawing.Size(188, 25);
            this.txtdatecreation.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(38, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Date creation";
            // 
            // txtdevise
            // 
            this.txtdevise.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtdevise.Enabled = false;
            this.txtdevise.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdevise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdevise.Location = new System.Drawing.Point(153, 273);
            this.txtdevise.Name = "txtdevise";
            this.txtdevise.ReadOnly = true;
            this.txtdevise.Size = new System.Drawing.Size(188, 25);
            this.txtdevise.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(38, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 110;
            this.label5.Text = "Devise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(38, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Montant";
            // 
            // txtmontant
            // 
            this.txtmontant.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtmontant.Enabled = false;
            this.txtmontant.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmontant.Location = new System.Drawing.Point(153, 209);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.ReadOnly = true;
            this.txtmontant.Size = new System.Drawing.Size(188, 25);
            this.txtmontant.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(38, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "Code Client";
            // 
            // txtcodeclient
            // 
            this.txtcodeclient.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtcodeclient.Enabled = false;
            this.txtcodeclient.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodeclient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcodeclient.Location = new System.Drawing.Point(153, 178);
            this.txtcodeclient.Name = "txtcodeclient";
            this.txtcodeclient.ReadOnly = true;
            this.txtcodeclient.Size = new System.Drawing.Size(188, 25);
            this.txtcodeclient.TabIndex = 107;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(413, 369);
            this.shapeContainer1.TabIndex = 116;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 412;
            this.lineShape1.Y1 = 154;
            this.lineShape1.Y2 = 154;
            // 
            // txttype
            // 
            this.txttype.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txttype.Enabled = false;
            this.txttype.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txttype.Location = new System.Drawing.Point(153, 240);
            this.txttype.Name = "txttype";
            this.txttype.ReadOnly = true;
            this.txttype.Size = new System.Drawing.Size(188, 25);
            this.txttype.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(38, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 117;
            this.label9.Text = "Type";
            // 
            // Fenrechercher
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 369);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtetat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdatecreation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdevise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodeclient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcodecompte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fenrechercher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher Compte";
            this.Load += new System.EventHandler(this.Fenrechercher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodecompte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtetat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdatecreation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdevise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodeclient;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label label9;
    }
}