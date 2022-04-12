using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyetisyen
{
    public class GlutenFree : IDiyet
    {
        public string[,] DiyetTable = new string[7, 3] {{"PazartesiKahvaltısı","PazartesiÖğle","PazartesiAksam"},
                                                     {"SalıKahvaltı","SalıÖğle","SalıAksam"},
                                                     {"CarsambaKahvaltı","CarsambaÖğle","ÇarşambaAksam"},
                                                     {"PersembeKahvaltı","PersembeÖğle","PersembeAksam"},
                                                     {"CumaKahvaltı","CumaÖğle","CumaAksam"},
                                                     {"CumartesiKahvaltı","CumartesiÖğle","CumartesiAksam"},
                                                     {"PazarKahvaltı","PazarÖğle","PazarAksam"}, };
        public void diyetYap(Hasta hasta)
        {
            hasta.DiyetAdi = "GlutenFree";
            hasta.DiyetVerilisTarihi = DateTime.Now;
            MessageBox.Show("GlutenFree Diyeti Uygulaniyor");
        }
    }
}
