﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGymControl
{
    static class FormatDecimal
    {
        public static string FormatValueDecimal(string valueDecimal)
        {
            valueDecimal = Convert.ToDecimal(valueDecimal).ToString("0.00");
            return valueDecimal;
        }

        public static void HandleFormatDecimal(Control textBox, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBox.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }
    }
}
