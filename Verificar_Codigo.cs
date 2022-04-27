using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresCodigo
{
    public partial class Verificar_Codigo : Form
    {
        public Verificar_Codigo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonverificar_Click(object sender, EventArgs e)
        {
            //Codigo codificador = 121212121
            int num = textBoxcodigo.Text.Count();
            int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, total, total1;
            string codigo = textBoxcodigo.Text;
            char[] chars = codigo.ToCharArray();
            if (num == 10)
            {
                num1 = (int)char.GetNumericValue(chars[0]) * 1;
                num2 = (int)char.GetNumericValue(chars[1]) * 2;
                num3 = (int)char.GetNumericValue(chars[2]) * 1;
                num4 = (int)char.GetNumericValue(chars[3]) * 2;
                num5 = (int)char.GetNumericValue(chars[4]) * 1;
                num6 = (int)char.GetNumericValue(chars[5]) * 2;
                num7 = (int)char.GetNumericValue(chars[6]) * 1;
                num8 = (int)char.GetNumericValue(chars[7]) * 2;
                num9 = (int)char.GetNumericValue(chars[8]) * 1;
                total = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9;
                total1 = total;
                while (total1 % 10 != 0)
                {
                    total1++;
                }
                total = total1 - total;
                num10 = (int)char.GetNumericValue(chars[9]);
                textBoxresultado.Visible = true;
                if (total == num10)
                {
                    textBoxresultado.Text = "Codigo Válido";
                    textBoxresultado.BackColor = Color.Green;
                }
                else
                {
                    textBoxresultado.Text = "Codigo No Válido";
                    textBoxresultado.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("El codigo debe tener 10 digitos, porfavor ingresa un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
