namespace ProjetFenetreCodevi
{
    partial class FenRemboursement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenRemboursement));
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btannuler = new System.Windows.Forms.Button();
            this.btrechercher = new System.Windows.Forms.Button();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btneffetuer = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lbpenalite = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdifference = new System.Windows.Forms.TextBox();
            this.lbldifference = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldevise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnumero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnumero.Location = new System.Drawing.Point(115, 106);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(218, 20);
            this.txtnumero.TabIndex = 65;
            this.txtnumero.Click += new System.EventHandler(this.txtnumero_Click);
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblid.Location = new System.Drawing.Point(4, 110);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(103, 17);
            this.lblid.TabIndex = 68;
            this.lblid.Text = "Numero compte";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btannuler
            // 
            this.btannuler.BackColor = System.Drawing.Color.White;
            this.btannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btannuler.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btannuler.Location = new System.Drawing.Point(253, 134);
            this.btannuler.Margin = new System.Windows.Forms.Padding(4);
            this.btannuler.Name = "btannuler";
            this.btannuler.Size = new System.Drawing.Size(80, 28);
            this.btannuler.TabIndex = 67;
            this.btannuler.Text = "&Fermer";
            this.btannuler.UseVisualStyleBackColor = false;
            this.btannuler.Click += new System.EventHandler(this.btannuler_Click);
            // 
            // btrechercher
            // 
            this.btrechercher.BackColor = System.Drawing.Color.White;
            this.btrechercher.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btrechercher.Location = new System.Drawing.Point(115, 134);
            this.btrechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btrechercher.Name = "btrechercher";
            this.btrechercher.Size = new System.Drawing.Size(80, 28);
            this.btrechercher.TabIndex = 66;
            this.btrechercher.Text = "&Rechercher";
            this.btrechercher.UseVisualStyleBackColor = false;
            this.btrechercher.Click += new System.EventHandler(this.btrechercher_Click);
            // 
            // txtmontant
            // 
            this.txtmontant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmontant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmontant.Location = new System.Drawing.Point(115, 188);
            this.txtmontant.Margin = new System.Windows.Forms.Padding(4);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(115, 20);
            this.txtmontant.TabIndex = 69;
            this.txtmontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontant_KeyPress);
            this.txtmontant.MouseLeave += new System.EventHandler(this.txtmontant_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(4, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Montant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btneffetuer
            // 
            this.btneffetuer.BackColor = System.Drawing.Color.White;
            this.btneffetuer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btneffetuer.Location = new System.Drawing.Point(253, 264);
            this.btneffetuer.Margin = new System.Windows.Forms.Padding(4);
            this.btneffetuer.Name = "btneffetuer";
            this.btneffetuer.Size = new System.Drawing.Size(80, 30);
            this.btneffetuer.TabIndex = 71;
            this.btneffetuer.Text = "&Effectuer";
            this.btneffetuer.UseVisualStyleBackColor = false;
            this.btneffetuer.Click += new System.EventHandler(this.btneffetuer_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblinfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblinfo.Location = new System.Drawing.Point(362, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(218, 209);
            this.lblinfo.TabIndex = 72;
            // 
            // lbpenalite
            // 
            this.lbpenalite.BackColor = System.Drawing.SystemColors.Control;
            this.lbpenalite.ForeColor = System.Drawing.Color.DarkRed;
            this.lbpenalite.Location = new System.Drawing.Point(361, 229);
            this.lbpenalite.Name = "lbpenalite";
            this.lbpenalite.Size = new System.Drawing.Size(219, 56);
            this.lbpenalite.TabIndex = 73;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(598, 298);
            this.shapeContainer1.TabIndex = 107;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 582;
            this.lineShape2.X2 = 582;
            this.lineShape2.Y1 = 7;
            this.lineShape2.Y2 = 299;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 359;
            this.lineShape1.X2 = 359;
            this.lineShape1.Y1 = 7;
            this.lineShape1.Y2 = 299;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 32);
            this.label4.TabIndex = 108;
            this.label4.Text = "Rembourser pret";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdifference
            // 
            this.txtdifference.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdifference.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdifference.Location = new System.Drawing.Point(115, 238);
            this.txtdifference.Margin = new System.Windows.Forms.Padding(4);
            this.txtdifference.MaxLength = 12;
            this.txtdifference.Name = "txtdifference";
            this.txtdifference.Size = new System.Drawing.Size(218, 20);
            this.txtdifference.TabIndex = 109;
            this.txtdifference.TextChanged += new System.EventHandler(this.txtdifference_TextChanged);
            // 
            // lbldifference
            // 
            this.lbldifference.AutoSize = true;
            this.lbldifference.BackColor = System.Drawing.Color.Transparent;
            this.lbldifference.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldifference.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbldifference.Location = new System.Drawing.Point(4, 239);
            this.lbldifference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldifference.Name = "lbldifference";
            this.lbldifference.Size = new System.Drawing.Size(0, 17);
            this.lbldifference.TabIndex = 110;
            this.lbldifference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(7, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 56);
            this.label2.TabIndex = 104;
            // 
            // lbldevise
            // 
            this.lbldevise.AutoSize = true;
            this.lbldevise.BackColor = System.Drawing.Color.Transparent;
            this.lbldevise.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldevise.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbldevise.Location = new System.Drawing.Point(250, 188);
            this.lbldevise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldevise.Name = "lbldevise";
            this.lbldevise.Size = new System.Drawing.Size(0, 17);
            this.lbldevise.TabIndex = 111;
            this.lbldevise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FenRemboursement
            // 
            this.AcceptButton = this.btrechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 298);
            this.Controls.Add(this.lbldevise);
            this.Controls.Add(this.txtdifference);
            this.Controls.Add(this.lbldifference);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbpenalite);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btneffetuer);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btannuler);
            this.Controls.Add(this.btrechercher);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FenRemboursement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rembourser pret";
            this.Load += new System.EventHandler(this.FenRemboursement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtnumero;
        internal System.Windows.Forms.Label lblid;
        internal System.Windows.Forms.Button btannuler;
        internal System.Windows.Forms.Button btrechercher;
        internal System.Windows.Forms.TextBox txtmontant;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btneffetuer;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lbpenalite;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtdifference;
        internal System.Windows.Forms.Label lbldifference;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        internal System.Windows.Forms.Label lbldevise;
    }
}