namespace ProjetFenetreCodevi
{
    partial class FenlisterClientCritere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenlisterClientCritere));
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.btnlister = new System.Windows.Forms.Button();
            this.txtcritere = new System.Windows.Forms.TextBox();
            this.lblcritere = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnannuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvliste
            // 
            this.dgvliste.AllowUserToAddRows = false;
            this.dgvliste.AllowUserToDeleteRows = false;
            this.dgvliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvliste.Location = new System.Drawing.Point(15, 175);
            this.dgvliste.Name = "dgvliste";
            this.dgvliste.ReadOnly = true;
            this.dgvliste.Size = new System.Drawing.Size(768, 366);
            this.dgvliste.TabIndex = 9;
            // 
            // btnlister
            // 
            this.btnlister.BackColor = System.Drawing.Color.White;
            this.btnlister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnlister.Location = new System.Drawing.Point(537, 138);
            this.btnlister.Name = "btnlister";
            this.btnlister.Size = new System.Drawing.Size(108, 31);
            this.btnlister.TabIndex = 8;
            this.btnlister.Text = "&Lister ";
            this.btnlister.UseVisualStyleBackColor = false;
            this.btnlister.Click += new System.EventHandler(this.btnlister_Click);
            // 
            // txtcritere
            // 
            this.txtcritere.Location = new System.Drawing.Point(286, 141);
            this.txtcritere.Name = "txtcritere";
            this.txtcritere.Size = new System.Drawing.Size(233, 20);
            this.txtcritere.TabIndex = 10;
            this.txtcritere.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcritere_MouseClick);
            // 
            // lblcritere
            // 
            this.lblcritere.AutoSize = true;
            this.lblcritere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcritere.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblcritere.Location = new System.Drawing.Point(213, 148);
            this.lblcritere.Name = "lblcritere";
            this.lblcritere.Size = new System.Drawing.Size(47, 16);
            this.lblcritere.TabIndex = 11;
            this.lblcritere.Text = "Critere";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 89);
            this.label1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-1, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(798, 52);
            this.label4.TabIndex = 59;
            this.label4.Text = "Lister clients par critere";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(768, 70);
            this.label2.TabIndex = 56;
            // 
            // btnannuler
            // 
            this.btnannuler.BackColor = System.Drawing.Color.White;
            this.btnannuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnannuler.Location = new System.Drawing.Point(672, 138);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(108, 31);
            this.btnannuler.TabIndex = 60;
            this.btnannuler.Text = "&Annuler";
            this.btnannuler.UseVisualStyleBackColor = false;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // FenlisterClientCritere
            // 
            this.AcceptButton = this.btnlister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 554);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcritere);
            this.Controls.Add(this.txtcritere);
            this.Controls.Add(this.dgvliste);
            this.Controls.Add(this.btnlister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FenlisterClientCritere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lister client par critere";
            this.Load += new System.EventHandler(this.FenlisterClientCritere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvliste;
        internal System.Windows.Forms.Button btnlister;
        private System.Windows.Forms.TextBox txtcritere;
        private System.Windows.Forms.Label lblcritere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnannuler;
    }
}