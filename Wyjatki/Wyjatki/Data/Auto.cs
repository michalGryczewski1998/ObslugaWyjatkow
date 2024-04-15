using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki.Data
{
    internal class Auto
    {
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? TypNadwozia { get; set; }
        public int? IloscDrzwi { get; set; }
        public string? Silnik { get; set; }
        public int? MocSilnika { get; set; }
        public double? SpalanieNaStoKilometrow { get; set; }
        public DateTime Rocznik { get; set; }
    }
}
