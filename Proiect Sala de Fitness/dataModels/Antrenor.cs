using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                                                                      
using System.Threading.Tasks;

namespace Proiect_Sala_de_Fitness.dataModels
{
    public class Antrenor
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public SpecializariAntrenori Specializare { get; set; } 
        public string Email { get; set; }
        public string NumarTelefon { get; set; }    

    }
}
