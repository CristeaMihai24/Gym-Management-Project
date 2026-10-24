using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Sala_de_Fitness.dataModels
{
    public class Membru
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Email {  get; set; }
        public string NumarTelefon { get; set; }
        public DateTime DataInscriere { get; set; }
    }
}
