using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyetisyen
{
    public class Hasta
    {
        public int HastaKayitNo { get; set; }
        public ulong Tc { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public string HastalikAdi { get; set; }
        public string DiyetAdi { get; set; }
        public DateTime DiyetVerilisTarihi { get; set; }
        //  public List<string> diyetTakvimi = new List<string>();
       // public string[,] diyetTakvimi = new string[7, 3];
    }
}
