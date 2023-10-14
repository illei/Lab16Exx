using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exx.Models
{
    internal class Producator
    {
        public int Id { get; set; }
        public int AutovehiculId { get; set; }
        public string Nume { get; set; }
        public String Adresa { get; set; }
        public override string ToString()
        {
            return $"{Nume} cu adresa {Adresa}";
        }
    }
}
