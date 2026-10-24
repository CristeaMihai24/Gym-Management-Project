using Proiect_Sala_de_Fitness.forms;
using Proiect_Sala_de_Fitness.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Sala_de_Fitness
{
    public partial class CheckInCheckOut : Form
    {
        private LogSalaService logService;
        private AppDbContext db;
        public CheckInCheckOut()
        {
            InitializeComponent();
            this.db = new AppDbContext();
            this.logService = new LogSalaService(this.db);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMembruId.Text, out int membruId))
            {
                MessageBox.Show("Introduceți un ID valid.");
                return;
            }
            try
            {
                logService.Intrare(membruId);
                MessageBox.Show($"Check-in reușit pentru membrul {membruId}!");
                this.Close();
            }
            catch (Exception ex)
            {
                string mesaj = "Eroare: " + ex.Message;
                if (ex.InnerException != null)
                    mesaj += "\n\nInner: " + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    mesaj += "\n\nInner2: " + ex.InnerException.InnerException.Message;
                MessageBox.Show(mesaj);
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMembruId.Text, out int membruId))
            {
                MessageBox.Show("Introduceți un ID valid.");
                return;
            }
            try
            {
                logService.Iesire(membruId);
                MessageBox.Show($"Check-out reușit pentru membrul {membruId}!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtMembruId_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckInCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }
    }
}
