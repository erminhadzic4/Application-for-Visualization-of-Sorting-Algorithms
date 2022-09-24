using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi_Sortiranja
{
    public static class Boja
    {
        public static Color Primarna { get; set; }
        public static Color Sekundarna { get; set; }
        public static List<string> Boje = new List<string>() {
            "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            "#E41A4A",
            "#5978BB",
            "#018790",
            "#0E3441",
            "#00B0AD",
            "#721D47",
            "#EA4833",
            "#EF937E",
            "#F37521",
            "#A12059",
            "#126881",
            "#8BC240",
            "#364D5B",
            "#C7DC5B",
            "#0094BC",
            "#E4126B",
            "#43B76E",
            "#7BCFE9",
            "#B71C46"};
        public static Color JacinaBoje(Color boja, double skalar)
        {
            double crvena = boja.R;
            double zelena = boja.G;
            double plava = boja.B;
            if (skalar < 0)
            {
                skalar = 1 + skalar;
                crvena *= skalar;
                zelena *= skalar;
                plava *= skalar;
            }
            else
            {
                crvena = (255 - crvena) * skalar + crvena;
                zelena = (255 - zelena) * skalar + zelena;
                plava = (255 - plava) * skalar + plava;
            }
            return Color.FromArgb(boja.A, (byte)crvena, (byte)zelena, (byte)plava);
        }
    }
}
