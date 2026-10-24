using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect_Sala_de_Fitness.dataModels
{
    public class LogSala
    {
        public int Id { get; set; }
        public int MembruId { get; set; }
        public byte TipEveniment { get; set; } 
        public DateTime DataOra { get; set; }
        public Membru Membru { get; set; } 
    }
}