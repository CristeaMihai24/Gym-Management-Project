using System;
using System.Linq;
using Proiect_Sala_de_Fitness.dataModels;

namespace Proiect_Sala_de_Fitness.services
{
    public class LogSalaService
    {
        private AppDbContext db;
        public LogSalaService(AppDbContext db)
        {
            this.db = db;
        }
        public bool EsteInSala(int membruId)
        {
            var ultimulLog = db.LogSala.Where(l => l.MembruId == membruId).OrderByDescending(l => l.DataOra).FirstOrDefault();
            return ultimulLog != null && ultimulLog.TipEveniment == 1;
        }
        public void Intrare(int membruId)
        {
            if (EsteInSala(membruId))
                throw new Exception("Membrul este deja în sală.");
            var ultimulAbonament = db.Abonamente.Where(a => a.MembruId == membruId).OrderByDescending(a => a.DataExpirare).FirstOrDefault();
            if (ultimulAbonament == null)
                throw new Exception("Acces respins: Membrul nu are niciun abonament înregistrat.");
            if (!ultimulAbonament.EsteActiv)
                throw new Exception($"Acces respins: Abonamentul a expirat la data de {ultimulAbonament.DataExpirare.ToShortDateString()}.");

            db.LogSala.Add(new LogSala
            {
                MembruId = membruId,
                TipEveniment = (byte)1, 
                DataOra = DateTime.Now
            });
            db.SaveChanges();
        }

        public void Iesire(int membruId)
        {
            if (!EsteInSala(membruId))
                throw new Exception("Membrul nu este în sală.");

            db.LogSala.Add(new LogSala
            {
                MembruId = membruId,
                TipEveniment = (byte)2, 
                DataOra = DateTime.Now
            });
            db.SaveChanges();
        }

        public int NumarPersoaneInSala()
        {
            var inSalaCount = db.LogSala.ToList().GroupBy(l => l.MembruId).Select(g => g.OrderByDescending(l => l.DataOra).FirstOrDefault())
            .Count(l => l != null && l.TipEveniment == 1);
            return inSalaCount;
        }
    }
}