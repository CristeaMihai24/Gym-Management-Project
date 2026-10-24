namespace Proiect_Sala_de_Fitness.forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvTabel = new System.Windows.Forms.DataGridView();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnSubscription = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnNrPersoane = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnConfirmaStergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabel)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabel
            // 
            this.dgvTabel.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabel.GridColor = System.Drawing.Color.White;
            this.dgvTabel.Location = new System.Drawing.Point(285, 13);
            this.dgvTabel.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabel.Name = "dgvTabel";
            this.dgvTabel.RowHeadersWidth = 51;
            this.dgvTabel.Size = new System.Drawing.Size(770, 515);
            this.dgvTabel.TabIndex = 4;
            this.dgvTabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMember.Location = new System.Drawing.Point(4, 74);
            this.btnMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(267, 58);
            this.btnMember.TabIndex = 5;
            this.btnMember.Text = "Vezi Membri";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubscription
            // 
            this.btnSubscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSubscription.Location = new System.Drawing.Point(4, 140);
            this.btnSubscription.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubscription.Name = "btnSubscription";
            this.btnSubscription.Size = new System.Drawing.Size(267, 58);
            this.btnSubscription.TabIndex = 6;
            this.btnSubscription.Text = "Vezi Abonamente";
            this.btnSubscription.UseVisualStyleBackColor = false;
            this.btnSubscription.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLog.Location = new System.Drawing.Point(4, 206);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(267, 58);
            this.btnLog.TabIndex = 7;
            this.btnLog.Text = "Vezi Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCheckIn.Location = new System.Drawing.Point(4, 272);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(267, 58);
            this.btnCheckIn.TabIndex = 8;
            this.btnCheckIn.Text = "Check-In Check-Out";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInregistrare.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnInregistrare.Location = new System.Drawing.Point(4, 338);
            this.btnInregistrare.Margin = new System.Windows.Forms.Padding(4);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(267, 58);
            this.btnInregistrare.TabIndex = 10;
            this.btnInregistrare.Text = "Inregistreaza Abonament";
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.btnSterge);
            this.pnlSideBar.Controls.Add(this.btnNrPersoane);
            this.pnlSideBar.Controls.Add(this.picLogo);
            this.pnlSideBar.Controls.Add(this.btnMember);
            this.pnlSideBar.Controls.Add(this.btnSubscription);
            this.pnlSideBar.Controls.Add(this.btnInregistrare);
            this.pnlSideBar.Controls.Add(this.btnLog);
            this.pnlSideBar.Controls.Add(this.btnCheckIn);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(277, 554);
            this.pnlSideBar.TabIndex = 13;
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSterge.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSterge.Location = new System.Drawing.Point(4, 470);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(4);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(267, 58);
            this.btnSterge.TabIndex = 12;
            this.btnSterge.Text = "Sterge abonament";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnNrPersoane
            // 
            this.btnNrPersoane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(0)))));
            this.btnNrPersoane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNrPersoane.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNrPersoane.Location = new System.Drawing.Point(4, 404);
            this.btnNrPersoane.Margin = new System.Windows.Forms.Padding(4);
            this.btnNrPersoane.Name = "btnNrPersoane";
            this.btnNrPersoane.Size = new System.Drawing.Size(267, 58);
            this.btnNrPersoane.TabIndex = 11;
            this.btnNrPersoane.Text = "Persoane in sala";
            this.btnNrPersoane.UseVisualStyleBackColor = false;
            this.btnNrPersoane.Click += new System.EventHandler(this.button6_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = global::Proiect_Sala_de_Fitness.Properties.Resources.Gemini_Generated_Image_ln878vln878vln87;
            this.picLogo.Location = new System.Drawing.Point(4, 4);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(267, 66);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnConfirmaStergere
            // 
            this.btnConfirmaStergere.BackColor = System.Drawing.Color.White;
            this.btnConfirmaStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaStergere.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnConfirmaStergere.Location = new System.Drawing.Point(891, 272);
            this.btnConfirmaStergere.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmaStergere.Name = "btnConfirmaStergere";
            this.btnConfirmaStergere.Size = new System.Drawing.Size(83, 36);
            this.btnConfirmaStergere.TabIndex = 13;
            this.btnConfirmaStergere.Text = "Sterge";
            this.btnConfirmaStergere.UseVisualStyleBackColor = false;
            this.btnConfirmaStergere.Click += new System.EventHandler(this.button9_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnConfirmaStergere);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.dgvTabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "GymManagement";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabel)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView dgvTabel;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnSubscription;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnNrPersoane;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnConfirmaStergere;
    }
}