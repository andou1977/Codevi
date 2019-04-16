namespace ProjetFenetreCodevi
{
    partial class FenEnregistrerClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenEnregistrerClient));
            this.cmbsexe = new System.Windows.Forms.ComboBox();
            this.lbsexe = new System.Windows.Forms.Label();
            this.btannuler = new System.Windows.Forms.Button();
            this.btsuivant = new System.Windows.Forms.Button();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lbtelepone = new System.Windows.Forms.Label();
            this.lbprenom = new System.Windows.Forms.Label();
            this.lbnom = new System.Windows.Forms.Label();
            this.lbadresse = new System.Windows.Forms.Label();
            this.rtbadresse = new System.Windows.Forms.RichTextBox();
            this.mskidentite = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCin = new System.Windows.Forms.RadioButton();
            this.rdNif = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelephone = new System.Windows.Forms.MaskedTextBox();
            this.LBPHOTO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbsexe
            // 
            this.cmbsexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbsexe.FormattingEnabled = true;
            this.cmbsexe.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cmbsexe.Location = new System.Drawing.Point(91, 245);
            this.cmbsexe.Margin = new System.Windows.Forms.Padding(4);
            this.cmbsexe.Name = "cmbsexe";
            this.cmbsexe.Size = new System.Drawing.Size(124, 25);
            this.cmbsexe.TabIndex = 3;
            // 
            // lbsexe
            // 
            this.lbsexe.AutoSize = true;
            this.lbsexe.BackColor = System.Drawing.Color.Transparent;
            this.lbsexe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsexe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbsexe.Location = new System.Drawing.Point(15, 249);
            this.lbsexe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsexe.Name = "lbsexe";
            this.lbsexe.Size = new System.Drawing.Size(37, 17);
            this.lbsexe.TabIndex = 48;
            this.lbsexe.Text = "Sexe";
            this.lbsexe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btannuler
            // 
            this.btannuler.BackColor = System.Drawing.Color.White;
            this.btannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btannuler.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btannuler.Location = new System.Drawing.Point(225, 476);
            this.btannuler.Margin = new System.Windows.Forms.Padding(4);
            this.btannuler.Name = "btannuler";
            this.btannuler.Size = new System.Drawing.Size(101, 32);
            this.btannuler.TabIndex = 11;
            this.btannuler.Text = "&Fermer";
            this.btannuler.UseVisualStyleBackColor = false;
            this.btannuler.Click += new System.EventHandler(this.btannuler_Click);
            // 
            // btsuivant
            // 
            this.btsuivant.BackColor = System.Drawing.Color.White;
            this.btsuivant.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btsuivant.Location = new System.Drawing.Point(91, 476);
            this.btsuivant.Margin = new System.Windows.Forms.Padding(4);
            this.btsuivant.Name = "btsuivant";
            this.btsuivant.Size = new System.Drawing.Size(105, 32);
            this.btsuivant.TabIndex = 10;
            this.btsuivant.Text = "&Enregistrer";
            this.btsuivant.UseVisualStyleBackColor = false;
            this.btsuivant.Click += new System.EventHandler(this.btsuivant_Click);
            // 
            // txtprenom
            // 
            this.txtprenom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtprenom.Location = new System.Drawing.Point(91, 212);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(232, 25);
            this.txtprenom.TabIndex = 2;
            this.txtprenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprenom_KeyPress);
            // 
            // txtnom
            // 
            this.txtnom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtnom.Location = new System.Drawing.Point(91, 177);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(232, 25);
            this.txtnom.TabIndex = 1;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // lbtelepone
            // 
            this.lbtelepone.AutoSize = true;
            this.lbtelepone.BackColor = System.Drawing.Color.Transparent;
            this.lbtelepone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelepone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbtelepone.Location = new System.Drawing.Point(15, 284);
            this.lbtelepone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtelepone.Name = "lbtelepone";
            this.lbtelepone.Size = new System.Drawing.Size(68, 17);
            this.lbtelepone.TabIndex = 44;
            this.lbtelepone.Text = "Telephone";
            this.lbtelepone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbprenom
            // 
            this.lbprenom.AutoSize = true;
            this.lbprenom.BackColor = System.Drawing.Color.Transparent;
            this.lbprenom.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprenom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbprenom.Location = new System.Drawing.Point(15, 220);
            this.lbprenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbprenom.Name = "lbprenom";
            this.lbprenom.Size = new System.Drawing.Size(54, 17);
            this.lbprenom.TabIndex = 43;
            this.lbprenom.Text = "Prenom";
            this.lbprenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.BackColor = System.Drawing.Color.Transparent;
            this.lbnom.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbnom.Location = new System.Drawing.Point(15, 185);
            this.lbnom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(37, 17);
            this.lbnom.TabIndex = 42;
            this.lbnom.Text = "Nom";
            this.lbnom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbadresse
            // 
            this.lbadresse.AutoSize = true;
            this.lbadresse.BackColor = System.Drawing.Color.Transparent;
            this.lbadresse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadresse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbadresse.Location = new System.Drawing.Point(15, 314);
            this.lbadresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbadresse.Name = "lbadresse";
            this.lbadresse.Size = new System.Drawing.Size(57, 34);
            this.lbadresse.TabIndex = 45;
            this.lbadresse.Text = "Adresse\r\n\r\n";
            this.lbadresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbadresse
            // 
            this.rtbadresse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbadresse.Location = new System.Drawing.Point(91, 311);
            this.rtbadresse.Margin = new System.Windows.Forms.Padding(4);
            this.rtbadresse.Name = "rtbadresse";
            this.rtbadresse.Size = new System.Drawing.Size(232, 47);
            this.rtbadresse.TabIndex = 5;
            this.rtbadresse.Text = "";
            this.rtbadresse.SelectionChanged += new System.EventHandler(this.rtbadresse_SelectionChanged);
            this.rtbadresse.TextChanged += new System.EventHandler(this.rtbadresse_TextChanged);
            // 
            // mskidentite
            // 
            this.mskidentite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskidentite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskidentite.Location = new System.Drawing.Point(91, 397);
            this.mskidentite.Name = "mskidentite";
            this.mskidentite.Size = new System.Drawing.Size(235, 22);
            this.mskidentite.TabIndex = 8;
            this.mskidentite.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskidentite_MaskInputRejected);
            this.mskidentite.TextChanged += new System.EventHandler(this.mskidentite_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCin);
            this.groupBox1.Controls.Add(this.rdNif);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(91, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 34);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // rdCin
            // 
            this.rdCin.AutoSize = true;
            this.rdCin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCin.Location = new System.Drawing.Point(63, 14);
            this.rdCin.Name = "rdCin";
            this.rdCin.Size = new System.Drawing.Size(43, 17);
            this.rdCin.TabIndex = 7;
            this.rdCin.TabStop = true;
            this.rdCin.Text = "CIN";
            this.rdCin.UseVisualStyleBackColor = true;
            this.rdCin.CheckedChanged += new System.EventHandler(this.rdCin_CheckedChanged_1);
            // 
            // rdNif
            // 
            this.rdNif.AutoSize = true;
            this.rdNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNif.Location = new System.Drawing.Point(15, 14);
            this.rdNif.Name = "rdNif";
            this.rdNif.Size = new System.Drawing.Size(42, 17);
            this.rdNif.TabIndex = 6;
            this.rdNif.TabStop = true;
            this.rdNif.Text = "NIF";
            this.rdNif.UseVisualStyleBackColor = true;
            this.rdNif.CheckedChanged += new System.EventHandler(this.rdNif_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(15, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Identite";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttelephone
            // 
            this.txttelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelephone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txttelephone.Location = new System.Drawing.Point(88, 279);
            this.txttelephone.Mask = "(5\\0\\9)0000-0000";
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(235, 22);
            this.txttelephone.TabIndex = 4;
            this.txttelephone.TextChanged += new System.EventHandler(this.txttelephone_TextChanged);
            this.txttelephone.MouseLeave += new System.EventHandler(this.txttelephone_MouseLeave);
            // 
            // LBPHOTO
            // 
            this.LBPHOTO.Location = new System.Drawing.Point(1, 41);
            this.LBPHOTO.Name = "LBPHOTO";
            this.LBPHOTO.Size = new System.Drawing.Size(100, 23);
            this.LBPHOTO.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 52);
            this.label4.TabIndex = 56;
            this.label4.Text = "Enregistrer client";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 70);
            this.label2.TabIndex = 57;
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcode.Location = new System.Drawing.Point(90, 144);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(232, 25);
            this.txtcode.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(14, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtemail.Location = new System.Drawing.Point(91, 430);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(232, 25);
            this.txtemail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(15, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FenEnregistrerClient
            // 
            this.AcceptButton = this.btsuivant;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 520);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBPHOTO);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.mskidentite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbsexe);
            this.Controls.Add(this.lbsexe);
            this.Controls.Add(this.btannuler);
            this.Controls.Add(this.btsuivant);
            this.Controls.Add(this.rtbadresse);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lbadresse);
            this.Controls.Add(this.lbtelepone);
            this.Controls.Add(this.lbprenom);
            this.Controls.Add(this.lbnom);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FenEnregistrerClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrer Client";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FenEnregistrerClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbsexe;
        internal System.Windows.Forms.Label lbsexe;
        internal System.Windows.Forms.Button btannuler;
        internal System.Windows.Forms.Button btsuivant;
        internal System.Windows.Forms.TextBox txtprenom;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.Label lbtelepone;
        internal System.Windows.Forms.Label lbprenom;
        internal System.Windows.Forms.Label lbnom;
        internal System.Windows.Forms.Label lbadresse;
        internal System.Windows.Forms.RichTextBox rtbadresse;
        private System.Windows.Forms.MaskedTextBox mskidentite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCin;
        private System.Windows.Forms.RadioButton rdNif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txttelephone;
        private System.Windows.Forms.Label LBPHOTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtcode;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.Label label3;
    }
}