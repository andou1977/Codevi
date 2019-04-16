namespace ProjetFenetreCodevi
{
    partial class FenModifierClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenModifierClient));
            this.label6 = new System.Windows.Forms.Label();
            this.lbsexe = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btannuler = new System.Windows.Forms.Button();
            this.btrechercher = new System.Windows.Forms.Button();
            this.rtbadresse = new System.Windows.Forms.RichTextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lbadresse = new System.Windows.Forms.Label();
            this.lbtelepone = new System.Windows.Forms.Label();
            this.lbprenom = new System.Windows.Forms.Label();
            this.lbnom = new System.Windows.Forms.Label();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.cmbsexe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCin = new System.Windows.Forms.RadioButton();
            this.rdNif = new System.Windows.Forms.RadioButton();
            this.msktelephone = new System.Windows.Forms.MaskedTextBox();
            this.mskidentite = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnnom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(12, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "Identite";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbsexe
            // 
            this.lbsexe.AutoSize = true;
            this.lbsexe.BackColor = System.Drawing.Color.Transparent;
            this.lbsexe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsexe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbsexe.Location = new System.Drawing.Point(12, 294);
            this.lbsexe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsexe.Name = "lbsexe";
            this.lbsexe.Size = new System.Drawing.Size(37, 17);
            this.lbsexe.TabIndex = 84;
            this.lbsexe.Text = "Sexe";
            this.lbsexe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtid.Location = new System.Drawing.Point(88, 119);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(232, 20);
            this.txtid.TabIndex = 83;
            this.txtid.Click += new System.EventHandler(this.txtid_Click);
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblid.Location = new System.Drawing.Point(12, 123);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(39, 17);
            this.lblid.TabIndex = 82;
            this.lblid.Text = "Code";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btannuler
            // 
            this.btannuler.BackColor = System.Drawing.Color.White;
            this.btannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btannuler.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btannuler.Location = new System.Drawing.Point(219, 147);
            this.btannuler.Margin = new System.Windows.Forms.Padding(4);
            this.btannuler.Name = "btannuler";
            this.btannuler.Size = new System.Drawing.Size(101, 32);
            this.btannuler.TabIndex = 77;
            this.btannuler.Text = "&Fermer";
            this.btannuler.UseVisualStyleBackColor = false;
            this.btannuler.Click += new System.EventHandler(this.btannuler_Click);
            // 
            // btrechercher
            // 
            this.btrechercher.BackColor = System.Drawing.Color.White;
            this.btrechercher.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btrechercher.Location = new System.Drawing.Point(85, 147);
            this.btrechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btrechercher.Name = "btrechercher";
            this.btrechercher.Size = new System.Drawing.Size(105, 32);
            this.btrechercher.TabIndex = 76;
            this.btrechercher.Text = "&Rechercher";
            this.btrechercher.UseVisualStyleBackColor = false;
            this.btrechercher.Click += new System.EventHandler(this.btrechercher_Click);
            // 
            // rtbadresse
            // 
            this.rtbadresse.Enabled = false;
            this.rtbadresse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtbadresse.Location = new System.Drawing.Point(88, 349);
            this.rtbadresse.Margin = new System.Windows.Forms.Padding(4);
            this.rtbadresse.Name = "rtbadresse";
            this.rtbadresse.Size = new System.Drawing.Size(232, 47);
            this.rtbadresse.TabIndex = 75;
            this.rtbadresse.Text = "";
            // 
            // txtprenom
            // 
            this.txtprenom.Enabled = false;
            this.txtprenom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtprenom.Location = new System.Drawing.Point(88, 265);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(232, 20);
            this.txtprenom.TabIndex = 74;
            this.txtprenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprenom_KeyPress);
            // 
            // txtnom
            // 
            this.txtnom.Enabled = false;
            this.txtnom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnom.Location = new System.Drawing.Point(88, 237);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(232, 20);
            this.txtnom.TabIndex = 73;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // lbadresse
            // 
            this.lbadresse.AutoSize = true;
            this.lbadresse.BackColor = System.Drawing.Color.Transparent;
            this.lbadresse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadresse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbadresse.Location = new System.Drawing.Point(12, 358);
            this.lbadresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbadresse.Name = "lbadresse";
            this.lbadresse.Size = new System.Drawing.Size(57, 34);
            this.lbadresse.TabIndex = 81;
            this.lbadresse.Text = "Adresse\r\n\r\n";
            this.lbadresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbtelepone
            // 
            this.lbtelepone.AutoSize = true;
            this.lbtelepone.BackColor = System.Drawing.Color.Transparent;
            this.lbtelepone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelepone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbtelepone.Location = new System.Drawing.Point(11, 322);
            this.lbtelepone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtelepone.Name = "lbtelepone";
            this.lbtelepone.Size = new System.Drawing.Size(68, 17);
            this.lbtelepone.TabIndex = 80;
            this.lbtelepone.Text = "Telephone";
            this.lbtelepone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbprenom
            // 
            this.lbprenom.AutoSize = true;
            this.lbprenom.BackColor = System.Drawing.Color.Transparent;
            this.lbprenom.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprenom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbprenom.Location = new System.Drawing.Point(12, 266);
            this.lbprenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbprenom.Name = "lbprenom";
            this.lbprenom.Size = new System.Drawing.Size(54, 17);
            this.lbprenom.TabIndex = 79;
            this.lbprenom.Text = "Prenom";
            this.lbprenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbnom
            // 
            this.lbnom.AutoSize = true;
            this.lbnom.BackColor = System.Drawing.Color.Transparent;
            this.lbnom.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbnom.Location = new System.Drawing.Point(12, 238);
            this.lbnom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(37, 17);
            this.lbnom.TabIndex = 78;
            this.lbnom.Text = "Nom";
            this.lbnom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.White;
            this.btnmodifier.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnmodifier.Location = new System.Drawing.Point(88, 503);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(105, 30);
            this.btnmodifier.TabIndex = 89;
            this.btnmodifier.Text = "&Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(219, 503);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 30);
            this.button2.TabIndex = 90;
            this.button2.Text = "&Annuler";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 379;
            this.lineShape1.Y1 = 192;
            this.lineShape1.Y2 = 193;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(383, 538);
            this.shapeContainer1.TabIndex = 91;
            this.shapeContainer1.TabStop = false;
            // 
            // cmbsexe
            // 
            this.cmbsexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexe.Enabled = false;
            this.cmbsexe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbsexe.FormattingEnabled = true;
            this.cmbsexe.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cmbsexe.Location = new System.Drawing.Point(88, 294);
            this.cmbsexe.Margin = new System.Windows.Forms.Padding(4);
            this.cmbsexe.Name = "cmbsexe";
            this.cmbsexe.Size = new System.Drawing.Size(232, 21);
            this.cmbsexe.TabIndex = 98;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdCin);
            this.groupBox1.Controls.Add(this.rdNif);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(88, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 33);
            this.groupBox1.TabIndex = 99;
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
            this.rdCin.CheckedChanged += new System.EventHandler(this.rdCin_CheckedChanged);
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
            this.rdNif.CheckedChanged += new System.EventHandler(this.rdNif_CheckedChanged);
            // 
            // msktelephone
            // 
            this.msktelephone.Enabled = false;
            this.msktelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktelephone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.msktelephone.Location = new System.Drawing.Point(88, 319);
            this.msktelephone.Mask = "(5\\0\\9)0000-0000";
            this.msktelephone.Name = "msktelephone";
            this.msktelephone.Size = new System.Drawing.Size(232, 22);
            this.msktelephone.TabIndex = 100;
            this.msktelephone.TextChanged += new System.EventHandler(this.msktelephone_TextChanged);
            // 
            // mskidentite
            // 
            this.mskidentite.Enabled = false;
            this.mskidentite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskidentite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mskidentite.Location = new System.Drawing.Point(88, 428);
            this.mskidentite.Name = "mskidentite";
            this.mskidentite.Size = new System.Drawing.Size(232, 22);
            this.mskidentite.TabIndex = 101;
            this.mskidentite.TextChanged += new System.EventHandler(this.mskidentite_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 38);
            this.label4.TabIndex = 103;
            this.label4.Text = "Modifier client";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 67);
            this.label1.TabIndex = 102;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(348, 263);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 23);
            this.button7.TabIndex = 97;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(348, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 96;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(348, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 95;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(348, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 94;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(348, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 93;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnnom
            // 
            this.btnnom.BackColor = System.Drawing.Color.Transparent;
            this.btnnom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnom.BackgroundImage")));
            this.btnnom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnom.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnnom.FlatAppearance.BorderSize = 2;
            this.btnnom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnom.ForeColor = System.Drawing.Color.White;
            this.btnnom.Location = new System.Drawing.Point(348, 235);
            this.btnnom.Name = "btnnom";
            this.btnnom.Size = new System.Drawing.Size(25, 23);
            this.btnnom.TabIndex = 92;
            this.btnnom.UseVisualStyleBackColor = false;
            this.btnnom.Click += new System.EventHandler(this.btnnom_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(348, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 106;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtemail.Location = new System.Drawing.Point(87, 464);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(232, 20);
            this.txtemail.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(9, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FenModifierClient
            // 
            this.AcceptButton = this.btrechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskidentite);
            this.Controls.Add(this.msktelephone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbsexe);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnnom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbsexe);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btannuler);
            this.Controls.Add(this.btrechercher);
            this.Controls.Add(this.rtbadresse);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lbadresse);
            this.Controls.Add(this.lbtelepone);
            this.Controls.Add(this.lbprenom);
            this.Controls.Add(this.lbnom);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FenModifierClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier Client";
            this.Load += new System.EventHandler(this.FenModifierClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lbsexe;
        internal System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.Label lblid;
        internal System.Windows.Forms.Button btannuler;
        internal System.Windows.Forms.Button btrechercher;
        internal System.Windows.Forms.RichTextBox rtbadresse;
        internal System.Windows.Forms.TextBox txtprenom;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.Label lbadresse;
        internal System.Windows.Forms.Label lbtelepone;
        internal System.Windows.Forms.Label lbprenom;
        internal System.Windows.Forms.Label lbnom;
        internal System.Windows.Forms.Button btnmodifier;
        internal System.Windows.Forms.Button button2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnnom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        internal System.Windows.Forms.ComboBox cmbsexe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCin;
        private System.Windows.Forms.RadioButton rdNif;
        private System.Windows.Forms.MaskedTextBox msktelephone;
        private System.Windows.Forms.MaskedTextBox mskidentite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.Label label2;
    }
}