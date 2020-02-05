using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = {100,50,20,10,5,1,0.5,0.25,0.1,0.05,0.01};
            double cantidad = double.Parse(txtCantidad.Text);
            sbyte n = 0;
            string respuesta = "Total: \n";
            foreach (double denominacion in denominaciones)  {
                while (denominacion<=Math.Round (cantidad,2))
                {
                    n++;
                    cantidad -= denominacion;

                
                }
                if(n>0)
                {
                    respuesta += n + (denominacion > 1 ? " Billetes de " : " Monedas de ") + denominacion + "\n" ;
                
                }
                n = 0;

            }

            lblTotal.Text = respuesta;
        }
    }
}
