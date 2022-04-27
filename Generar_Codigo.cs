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
    public partial class Generar_Codigo : Form
    {
        public Generar_Codigo()
        {
            InitializeComponent();
        }

        private void buttongenerar_Click(object sender, EventArgs e)
        {
            //Vector de control = 121212121
            int num = textBoxcodigo.Text.Count();
            int num1, num2, num3, num4, num5, num6, num7, num8, num9, total, total1;
            string codigo = textBoxcodigo.Text;
            char[] chars = codigo.ToCharArray();
            if (num == 9)
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
                while (total1%10 != 0)
                {
                    total1++;
                }
                total = total1 - total;
                codigo = codigo + total.ToString();
                textBoxcodfinal.Visible = true;
                labelcod.Visible = true;
                textBoxcodfinal.Text = codigo;
            }
            else
            {
                MessageBox.Show("El codigo debe tener 9 digitos, porfavor ingresa un numero valido" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Generar_Codigo_Load(object sender, EventArgs e)
        {
            textBoxcodfinal.ReadOnly = true;
        }
    }
}
