using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class Validaciones
    {
        public static bool txtVacios(TextBox textB)
        {
            if (textB.Text == string.Empty)
            {
                textB.Focus();
                return true;
            }
            else
            {
                return false;
            }
               
            
        }
        public static bool soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

    }
}
