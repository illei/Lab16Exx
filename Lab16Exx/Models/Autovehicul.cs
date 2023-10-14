using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exx.Models
{
    internal class Autovehicul
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string SerieSasiu { get; set; }
        public int AnFabricatie { get; set; }   
        public Producator Producator { get; set; }

        public override string ToString()
        {
            return $"Autovehicului {Nume} cu seria de sasiu :{SerieSasiu} Fabricat in {AnFabricatie} cu producatorul {Producator}";
        }
    }
}
