using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Sala_de_Fitness.dataModels
{
    public class Abonament
    {
        public int Id { get; set; }
        public int MembruId { get; set; }
        public TipAbonament Tip{ get; set; }        
        public decimal Pret { get; set; }       
        public DateTime DataStart { get; set; }
        public DateTime DataExpirare { get; set; }
        public bool EsteActiv => DateTime.Now <= DataExpirare;
        public Membru Membru { get; set; }
    }
}
