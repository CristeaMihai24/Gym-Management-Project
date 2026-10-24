using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Sala_de_Fitness.dataModels
{
    public class Rezervari
    {
        public int Id { get; set; }   
        public int MembruId { get; set; }
        public Membru Membru { get; set; }
        public int AntrenorId { get; set; }  
        public Antrenor Antrenor { get; set; }
        public DateTime DataOraIncepere { get; set; }
        public SpecializariAntrenori TipRezervare { get; set; }
        public int Durata { get; set; }
    }
}
