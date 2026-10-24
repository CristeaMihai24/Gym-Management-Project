using System;
using System.Windows.Forms;
using Proiect_Sala_de_Fitness.services;
using Proiect_Sala_de_Fitness;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Diagnostics.Eventing.Reader;

namespace Proiect_Sala_de_Fitness.forms
{
    public partial class MainForm : Form
    {
        private AppDbContext db = new AppDbContext();
        private LogSalaService logService;
        public MainForm()
        {
            InitializeComponent();
            logService = new LogSalaService(db);
            dgvTabel.Rows.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvTabel.DataSource = null;
            dgvTabel.Columns.Clear();
            dgvTabel.Rows.Clear();
            btnConfirmaStergere.Visible = false;
            dgvTabel.DataSource = db.Membri.Select(m => new {m.Id, m.Nume, m.Email, m.NumarTelefon}).ToList();
            dgvTabel.Columns["NumarTelefon"].HeaderText = "Telefon";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dgvTabel.DataSource = null;
            dgvTabel.Columns.Clear();
            dgvTabel.Rows.Clear();
            btnConfirmaStergere.Visible = false;
            dgvTabel.DataSource = db.Abonamente.Include(m => m.Membru).Select(m => new { m.Membru.Nume, m.Tip,
            m.Pret,m.EsteActiv, m.DataStart, m.DataExpirare}).ToList();
            dgvTabel.Columns["DataStart"].HeaderText = "Activ de la:";
            dgvTabel.Columns["DataExpirare"].HeaderText = "Activ pana la:";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            dgvTabel.DataSource = null;
            dgvTabel.Columns.Clear();
            dgvTabel.Rows.Clear();
            btnConfirmaStergere.Visible = false;
            dgvTabel.DataSource = db.LogSala.Include(m => m.Membru).Select(m => new { m.Id, m.Membru.Nume, m.TipEveniment, m.DataOra}).ToList();
            dgvTabel.Columns["TipEveniment"].HeaderText = "In->1 Out->2";
            dgvTabel.Columns["DataOra"].HeaderText = "Ora";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CheckInCheckOut formularNou = new CheckInCheckOut();
            formularNou.StartPosition = FormStartPosition.CenterParent;
            formularNou.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AdaugaAbonament formularNou = new AdaugaAbonament();
            formularNou.StartPosition = FormStartPosition.CenterParent;
            formularNou.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnConfirmaStergere.Visible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            int numarPersoane = logService.NumarPersoaneInSala();
            MessageBox.Show($"In sala se afla {numarPersoane} persoane","Numar persoane", MessageBoxButtons.OK);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            dgvTabel.DataSource = null;
            dgvTabel.Columns.Clear();
            dgvTabel.Rows.Clear();
            btnConfirmaStergere.Visible = false;
            dgvTabel.DataSource = db.Abonamente.Include(m => m.Membru).Select(m => new {m.Membru.Nume,m.Tip, m.Id}).ToList();
            DataGridViewCheckBoxColumn chkSterge = new DataGridViewCheckBoxColumn();
            chkSterge.Name = "Selectat";
            chkSterge.HeaderText = "Selectie";
            dgvTabel.Columns.Add(chkSterge);
            dgvTabel.Columns["Selectat"].DisplayIndex = 0;
            btnConfirmaStergere.Visible = true;
            
        }
        private void button9_Click(object sender, EventArgs e)
        {           
            bool ok = false;
            foreach (DataGridViewRow rand in dgvTabel.Rows)
            {
                if (rand.Cells["Selectat"].Value != null && (bool)rand.Cells["Selectat"].Value == true)
                {
                    ok = true; 
                    break;
                }
            }
            var confirmare = DialogResult;
            if (ok)
                confirmare = MessageBox.Show("Esti sigur ca vrei sa stergi abonamentele selectate?", "Confirmare",
                MessageBoxButtons.YesNo);
            else
                confirmare = MessageBox.Show("Selectati minim un abonament de sters!", "Atentie", MessageBoxButtons.OK);


            if (confirmare == DialogResult.Yes)
            {
                {
                    foreach (DataGridViewRow rand in dgvTabel.Rows)
                    {
                        if (rand.Cells["Selectat"].Value != null && (bool)rand.Cells["Selectat"].Value == true)
                        {
                            int id = (int)rand.Cells["Id"].Value;
                            var abonament = db.Abonamente.FirstOrDefault(a => a.Id == id);
                            if (abonament != null)
                            db.Abonamente.Remove(abonament);
                        }
                    }
                    db.SaveChanges();
                    MessageBox.Show("Abonamentele selectate au fost sterse!", "Succes", MessageBoxButtons.OK);
                    button2_Click(sender, e);
                }
            }

        }
    }
}