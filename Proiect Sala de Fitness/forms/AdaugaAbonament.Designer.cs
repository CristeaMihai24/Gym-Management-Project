namespace Proiect_Sala_de_Fitness
{
    partial class AdaugaAbonament
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
            this.grpTipInreg = new System.Windows.Forms.GroupBox();
            this.MembruNou = new System.Windows.Forms.RadioButton();
            this.MembruExistent = new System.Windows.Forms.RadioButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMembruExistent = new System.Windows.Forms.Panel();
            this.NumeMembru = new System.Windows.Forms.ComboBox();
            this.lblSlelecteazaMembru = new System.Windows.Forms.Label();
            this.pnlMembruNou = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.pnlTipAbonament = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataInceput = new System.Windows.Forms.DateTimePicker();
            this.cmbTipAbonament = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpTipInreg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMembruExistent.SuspendLayout();
            this.pnlMembruNou.SuspendLayout();
            this.pnlTipAbonament.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipInreg
            // 
            this.grpTipInreg.Controls.Add(this.MembruNou);
            this.grpTipInreg.Controls.Add(this.MembruExistent);
            this.grpTipInreg.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.grpTipInreg.Location = new System.Drawing.Point(83, 91);
            this.grpTipInreg.Margin = new System.Windows.Forms.Padding(4);
            this.grpTipInreg.Name = "grpTipInreg";
            this.grpTipInreg.Padding = new System.Windows.Forms.Padding(4);
            this.grpTipInreg.Size = new System.Drawing.Size(272, 52);
            this.grpTipInreg.TabIndex = 0;
            this.grpTipInreg.TabStop = false;
            this.grpTipInreg.Text = "Tip Inregistrare";
            this.grpTipInreg.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MembruNou
            // 
            this.MembruNou.AutoSize = true;
            this.MembruNou.Location = new System.Drawing.Point(151, 23);
            this.MembruNou.Margin = new System.Windows.Forms.Padding(4);
            this.MembruNou.Name = "MembruNou";
            this.MembruNou.Size = new System.Drawing.Size(108, 21);
            this.MembruNou.TabIndex = 1;
            this.MembruNou.TabStop = true;
            this.MembruNou.Text = "Membru Nou";
            this.MembruNou.UseVisualStyleBackColor = true;
            this.MembruNou.CheckedChanged += new System.EventHandler(this.MebruNou_CheckedChanged);
            // 
            // MembruExistent
            // 
            this.MembruExistent.AutoSize = true;
            this.MembruExistent.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.MembruExistent.Location = new System.Drawing.Point(8, 23);
            this.MembruExistent.Margin = new System.Windows.Forms.Padding(4);
            this.MembruExistent.Name = "MembruExistent";
            this.MembruExistent.Size = new System.Drawing.Size(127, 21);
            this.MembruExistent.TabIndex = 0;
            this.MembruExistent.TabStop = true;
            this.MembruExistent.Text = "Membru Existent";
            this.MembruExistent.UseVisualStyleBackColor = true;
            this.MembruExistent.CheckedChanged += new System.EventHandler(this.MembruExistent_CheckedChanged);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Proiect_Sala_de_Fitness.Properties.Resources.Gemini_Generated_Image_ln878vln878vln87;
            this.picLogo.Location = new System.Drawing.Point(0, -2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(133, 62);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlMembruExistent
            // 
            this.pnlMembruExistent.Controls.Add(this.NumeMembru);
            this.pnlMembruExistent.Controls.Add(this.lblSlelecteazaMembru);
            this.pnlMembruExistent.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.pnlMembruExistent.Location = new System.Drawing.Point(83, 151);
            this.pnlMembruExistent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMembruExistent.Name = "pnlMembruExistent";
            this.pnlMembruExistent.Size = new System.Drawing.Size(341, 176);
            this.pnlMembruExistent.TabIndex = 2;
            // 
            // NumeMembru
            // 
            this.NumeMembru.FormattingEnabled = true;
            this.NumeMembru.Location = new System.Drawing.Point(21, 34);
            this.NumeMembru.Margin = new System.Windows.Forms.Padding(4);
            this.NumeMembru.Name = "NumeMembru";
            this.NumeMembru.Size = new System.Drawing.Size(160, 25);
            this.NumeMembru.TabIndex = 1;
            // 
            // lblSlelecteazaMembru
            // 
            this.lblSlelecteazaMembru.AutoSize = true;
            this.lblSlelecteazaMembru.Location = new System.Drawing.Point(17, 15);
            this.lblSlelecteazaMembru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlelecteazaMembru.Name = "lblSlelecteazaMembru";
            this.lblSlelecteazaMembru.Size = new System.Drawing.Size(123, 17);
            this.lblSlelecteazaMembru.TabIndex = 0;
            this.lblSlelecteazaMembru.Text = "Selecteaza Membru";
            // 
            // pnlMembruNou
            // 
            this.pnlMembruNou.Controls.Add(this.txtEmail);
            this.pnlMembruNou.Controls.Add(this.txtTelefon);
            this.pnlMembruNou.Controls.Add(this.txtNume);
            this.pnlMembruNou.Controls.Add(this.label3);
            this.pnlMembruNou.Controls.Add(this.label2);
            this.pnlMembruNou.Controls.Add(this.Nume);
            this.pnlMembruNou.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.pnlMembruNou.Location = new System.Drawing.Point(83, 151);
            this.pnlMembruNou.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMembruNou.Name = "pnlMembruNou";
            this.pnlMembruNou.Size = new System.Drawing.Size(341, 138);
            this.pnlMembruNou.TabIndex = 3;
            this.pnlMembruNou.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMembruNou_Paint);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 80);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(116, 47);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(132, 25);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(116, 11);
            this.txtNume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(132, 25);
            this.txtNume.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(21, 15);
            this.Nume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(46, 17);
            this.Nume.TabIndex = 0;
            this.Nume.Text = "Nume:";
            // 
            // pnlTipAbonament
            // 
            this.pnlTipAbonament.Controls.Add(this.label5);
            this.pnlTipAbonament.Controls.Add(this.dtpDataInceput);
            this.pnlTipAbonament.Controls.Add(this.cmbTipAbonament);
            this.pnlTipAbonament.Controls.Add(this.label1);
            this.pnlTipAbonament.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.pnlTipAbonament.Location = new System.Drawing.Point(589, 151);
            this.pnlTipAbonament.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTipAbonament.Name = "pnlTipAbonament";
            this.pnlTipAbonament.Size = new System.Drawing.Size(421, 176);
            this.pnlTipAbonament.TabIndex = 2;
            this.pnlTipAbonament.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data Incepere:";
            // 
            // dtpDataInceput
            // 
            this.dtpDataInceput.Location = new System.Drawing.Point(145, 75);
            this.dtpDataInceput.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataInceput.Name = "dtpDataInceput";
            this.dtpDataInceput.Size = new System.Drawing.Size(265, 25);
            this.dtpDataInceput.TabIndex = 2;
            // 
            // cmbTipAbonament
            // 
            this.cmbTipAbonament.FormattingEnabled = true;
            this.cmbTipAbonament.Location = new System.Drawing.Point(145, 11);
            this.cmbTipAbonament.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipAbonament.Name = "cmbTipAbonament";
            this.cmbTipAbonament.Size = new System.Drawing.Size(160, 25);
            this.cmbTipAbonament.TabIndex = 1;
            this.cmbTipAbonament.SelectedIndexChanged += new System.EventHandler(this.cmbTipAbonament_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip Abonament:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnConfirm.Location = new System.Drawing.Point(482, 416);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 28);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirma";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdaugaAbonament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlTipAbonament);
            this.Controls.Add(this.pnlMembruNou);
            this.Controls.Add(this.pnlMembruExistent);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpTipInreg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdaugaAbonament";
            this.Text = "AdaugaAbonament";
            this.Load += new System.EventHandler(this.AdaugaAbonament_Load);
            this.grpTipInreg.ResumeLayout(false);
            this.grpTipInreg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMembruExistent.ResumeLayout(false);
            this.pnlMembruExistent.PerformLayout();
            this.pnlMembruNou.ResumeLayout(false);
            this.pnlMembruNou.PerformLayout();
            this.pnlTipAbonament.ResumeLayout(false);
            this.pnlTipAbonament.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipInreg;
        private System.Windows.Forms.RadioButton MembruExistent;
        private System.Windows.Forms.RadioButton MembruNou;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlMembruExistent;
        private System.Windows.Forms.ComboBox NumeMembru;
        private System.Windows.Forms.Label lblSlelecteazaMembru;
        private System.Windows.Forms.Panel pnlMembruNou;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Panel pnlTipAbonament;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataInceput;
        private System.Windows.Forms.ComboBox cmbTipAbonament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
    }
}