namespace ProjetFenetreCodevi
{
    partial class fenlistertracabilitecritere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fenlistertracabilitecritere));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcritere = new System.Windows.Forms.Label();
            this.txtcritere = new System.Windows.Forms.TextBox();
            this.dgvliste = new System.Windows.Forms.DataGridView();
            this.btnlister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-1, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(791, 52);
            this.label4.TabIndex = 73;
            this.label4.Text = "Lister tracabilite par critere";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 89);
            this.label1.TabIndex = 71;
            // 
            // lblcritere
            // 
            this.lblcritere.AutoSize = true;
            this.lblcritere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcritere.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblcritere.Location = new System.Drawing.Point(183, 138);
            this.lblcritere.Name = "lblcritere";
            this.lblcritere.Size = new System.Drawing.Size(47, 16);
            this.lblcritere.TabIndex = 70;
            this.lblcritere.Text = "Critere";
            // 
            // txtcritere
            // 
            this.txtcritere.Location = new System.Drawing.Point(255, 141);
            this.txtcritere.Name = "txtcritere";
            this.txtcritere.Size = new System.Drawing.Size(233, 20);
            this.txtcritere.TabIndex = 69;
            this.txtcritere.Click += new System.EventHandler(this.txtcritere_Click);
            this.txtcritere.TextChanged += new System.EventHandler(this.txtcritere_TextChanged);
            // 
            // dgvliste
            // 
            this.dgvliste.AllowUserToAddRows = false;
            this.dgvliste.AllowUserToDeleteRows = false;
            this.dgvliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvliste.Location = new System.Drawing.Point(12, 175);
            this.dgvliste.Name = "dgvliste";
            this.dgvliste.ReadOnly = true;
            this.dgvliste.Size = new System.Drawing.Size(768, 366);
            this.dgvliste.TabIndex = 68;
            // 
            // btnlister
            // 
            this.btnlister.BackColor = System.Drawing.Color.White;
            this.btnlister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnlister.Location = new System.Drawing.Point(505, 130);
            this.btnlister.Name = "btnlister";
            this.btnlister.Size = new System.Drawing.Size(108, 31);
            this.btnlister.TabIndex = 67;
            this.btnlister.Text = "&Lister ";
            this.btnlister.UseVisualStyleBackColor = false;
            this.btnlister.Click += new System.EventHandler(this.btnlister_Click);
            // 
            // label2
            // 
            this.label2.Image = global::ProjetFenetreCodevi.Properties.Resources.codevilogo;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(768, 70);
            this.label2.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(669, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 74;
            this.button1.Text = "&Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fenlistertracabilitecritere
            // 
            this.AcceptButton = this.btnlister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 549);
            this.Controls.Add(this.button1);
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
            this.Name = "fenlistertracabilitecritere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lister tracabilite par critere";
            this.Load += new System.EventHandler(this.fenlistertracabilitecritere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcritere;
        private System.Windows.Forms.TextBox txtcritere;
        internal System.Windows.Forms.DataGridView dgvliste;
        internal System.Windows.Forms.Button btnlister;
        internal System.Windows.Forms.Button button1;
    }
}