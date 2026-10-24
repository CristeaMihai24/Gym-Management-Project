using Proiect_Sala_de_Fitness.dataModels;
using Proiect_Sala_de_Fitness.forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_Sala_de_Fitness
{
    public partial class AdaugaAbonament : Form
    {
        public AdaugaAbonament()
        {
            InitializeComponent();
        }
        private void AdaugaAbonament_Load(object sender, EventArgs e)
        {            
            
            cmbTipAbonament.DataSource = Enum.GetValues(typeof(TipAbonament));
            IncarcaMembriExistenti();
        }
        private void IncarcaMembriExistenti()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var listaMembri = db.Membri.OrderBy(m => m.Nume).ToList();
                    NumeMembru.DataSource = listaMembri;
                    NumeMembru.DisplayMember = "Nume";
                    NumeMembru.ValueMember = "Id";
                    NumeMembru.SelectedIndex = -1;
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încarcarea membrilor: {ex.Message}", "Eroare", MessageBoxButtons.OK);
            }
        }
        private void MembruExistent_CheckedChanged(object sender, EventArgs e)
        {
            if (MembruExistent.Checked)
            {
                pnlMembruExistent.Visible = true;
                pnlMembruNou.Visible = false;
            }
        }
        private void MebruNou_CheckedChanged(object sender, EventArgs e)
        {
            if (MembruNou.Checked)
            {
                pnlMembruExistent.Visible = false;
                pnlMembruNou.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                int idMembruFinal = 0;
                
                if (MembruExistent.Checked)
                {
                    if (NumeMembru.SelectedItem == null)
                    {
                        MessageBox.Show("Va rugam sa selectati un membru din lista!", "Atentie", MessageBoxButtons.OK);
                        return;
                    }
                    idMembruFinal = (int)NumeMembru.SelectedValue;
                    bool areAbonamentActiv = db.Abonamente.Any(a => a.MembruId == idMembruFinal && dtpDataInceput.Value < a.DataExpirare);
                    if (areAbonamentActiv)
                    {
                        MessageBox.Show("Membrul are deja un abonament activ!", "Atentie", MessageBoxButtons.OK);
                        return;
                    }
                }
                else if (MembruNou.Checked)
                {
                    if (txtNume.Text == "")
                    {
                        MessageBox.Show("Numele este obligatoriu pentru un membru nou!", "Atentie", MessageBoxButtons.OK);
                        return;
                    }
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                    {
                        MessageBox.Show("Introduceti o adresa de e-mail valid!", "Atentie");
                        return;
                    }
                    bool emailExistent = db.Membri.Any(m => m.Email == txtEmail.Text.Trim());

                    if (emailExistent)
                    {
                        MessageBox.Show("Acest e-mail exista deja in baza de date!", "Atentie", MessageBoxButtons.OK);
                        return;
                    }
                    if (txtTelefon.Text.Length != 10 || !txtTelefon.Text.StartsWith("07"))
                    {
                        MessageBox.Show("Introduceti un numar de telefon valid!", "Atentie", MessageBoxButtons.OK);
                        return;
                    }
                    bool ok1 = false;
                    bool ok2 = false;
                    ok1 = txtNume.Text.Any(c => char.IsWhiteSpace(c));
                    ok2 = txtNume.Text.Any(c => char.IsLetter(c));
                    if (!ok1 || !ok2)
                    {
                        MessageBox.Show("Introduceti un nume valid!", "Atentie", MessageBoxButtons.OK);
                        return;
                    } 
                    Membru membruNou = new Membru
                {
                    Nume = txtNume.Text.Trim(),
                    NumarTelefon = txtTelefon.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DataInscriere = DateTime.Now
                };
                db.Membri.Add(membruNou);
                db.SaveChanges();
                idMembruFinal = membruNou.Id;
                }
              
                TipAbonament tipSelectat = (TipAbonament)cmbTipAbonament.SelectedItem;
                decimal pretCalculat = 0;
                switch (tipSelectat)
                {
                    case TipAbonament.Starter:
                        pretCalculat = 80.00m;
                        break;
                    case TipAbonament.Basic:
                        pretCalculat = 150.00m;
                        break;
                    case TipAbonament.Premium:
                        pretCalculat = 250.00m;
                        break;
                }
                DateTime dataInceput = dtpDataInceput.Value;
                DateTime dataExpirare = dataInceput.AddMonths(1);
                Abonament abonamentNou = new Abonament
                {
                    MembruId = idMembruFinal,
                    Tip = tipSelectat,
                    Pret = pretCalculat,
                    DataStart = dataInceput,
                    DataExpirare = dataExpirare
                };
                db.Abonamente.Add(abonamentNou);
                db.SaveChanges();
                MessageBox.Show($"Abonamentul a fost adăugat cu succes!\nPreț: {pretCalculat} RON\nValabil până la: {dataExpirare.ToShortDateString()}",
                "Succes", MessageBoxButtons.OK);
                this.Close();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void cmbTipAbonament_SelectedIndexChanged(object sender, EventArgs e) 
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm formularNou = new MainForm();
            formularNou.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            formularNou.Show();
        }

        private void pnlMembruNou_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}