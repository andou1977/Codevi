namespace ProjetFenetreCodevi
{
    partial class fenConnection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fenConnection));
            this.btnconnexion = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.eperreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.LBPHOTO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eperreur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconnexion
            // 
            this.btnconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconnexion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnconnexion.Location = new System.Drawing.Point(162, 163);
            this.btnconnexion.Name = "btnconnexion";
            this.btnconnexion.Size = new System.Drawing.Size(100, 33);
            this.btnconnexion.TabIndex = 15;
            this.btnconnexion.Text = "&Connexion";
            this.btnconnexion.UseVisualStyleBackColor = true;
            this.btnconnexion.Click += new System.EventHandler(this.btnconnexion_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnannuler.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnannuler.Location = new System.Drawing.Point(303, 160);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(100, 36);
            this.btnannuler.TabIndex = 16;
            this.btnannuler.Text = "&Fermer";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.Location = new System.Drawing.Point(162, 121);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(241, 20);
            this.txtpassword.TabIndex = 14;
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtusername.Location = new System.Drawing.Point(162, 95);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(241, 20);
            this.txtusername.TabIndex = 12;
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblpassword.Location = new System.Drawing.Point(12, 120);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(95, 19);
            this.lblpassword.TabIndex = 13;
            this.lblpassword.Text = "Mot de Passe";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblusername.Location = new System.Drawing.Point(11, 94);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(130, 19);
            this.lblusername.TabIndex = 11;
            this.lblusername.Text = "Nom d\'Utilisateur";
            this.lblusername.Click += new System.EventHandler(this.lblusername_Click);
            // 
            // eperreur
            // 
            this.eperreur.ContainerControl = this;
            // 
            // LBPHOTO
            // 
            this.LBPHOTO.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.LBPHOTO.Location = new System.Drawing.Point(12, -10);
            this.LBPHOTO.Name = "LBPHOTO";
            this.LBPHOTO.Size = new System.Drawing.Size(401, 102);
            this.LBPHOTO.TabIndex = 54;
            // 
            // fenConnection
            // 
            this.AcceptButton = this.btnconnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 213);
            this.Controls.Add(this.LBPHOTO);
            this.Controls.Add(this.btnconnexion);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fenConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fenConnection_FormClosed);
            this.Load += new System.EventHandler(this.fenConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eperreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnconnexion;
        internal System.Windows.Forms.Button btnannuler;
        internal System.Windows.Forms.TextBox txtpassword;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Label lblpassword;
        internal System.Windows.Forms.Label lblusername;
        internal System.Windows.Forms.ErrorProvider eperreur;
        private System.Windows.Forms.Label LBPHOTO;
    }
}