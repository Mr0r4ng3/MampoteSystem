using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MampoteSystem.Windows.Tools.Enumerables;

namespace MampoteSystem.Windows.Tools
{
    public class Mensaje
    {
        // eerror
        public static void MessageBox(Mensajeria typeMessage, Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
        }
        // Yes Not

        public static void MessageBox(Mensajeria typeMessage, string warning)
        {
            System.Windows.Forms.MessageBox.Show(warning);
        }
    }
}
