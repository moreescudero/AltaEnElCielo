using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    internal class Formulario
    {
        static PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public static void Font(Form formulario)
        {
            privateFontCollection.AddFontFile("../../../Resources/SuperLegendBoy-4w8Y.ttf");
            foreach (Control control in formulario.Controls)
            {
                control.Font = new Font(privateFontCollection.Families[0], 7, FontStyle.Regular);
            }
        }
    }
}
