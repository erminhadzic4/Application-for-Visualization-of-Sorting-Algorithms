using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_Sortiranja
{
    internal interface SortEngine
    {
        void Sljedeci();
        void OcitajLog(Label lblPristup, Label lblPoredjenja);
        bool Sortirana();

        int DajBrPristupa();

        int DajBrPoredjenja();
    }
}
