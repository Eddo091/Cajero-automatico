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
        //Retirar del banco
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtCantidad.Text);
            sbyte n = 0;
            string respuesta = "Total: \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    n++;
                    cantidad -= denominacion;


                }

                if (n > 0)
                {
                    lblTotal.Visible = true;
                    //oculto respuestas
                    lblPrimoResp.Visible = false;
                    lblTotal2.Visible = false;
                    lblFiboResp.Visible = false;
                    
                    respuesta +=  n + (denominacion > 1 ? " Billetes de " : " Monedas de ") + denominacion + "\n";

                }
                n = 0;

            }

            lblTotal.Text = respuesta;
            txtCantidad.Text = "";
        }

        //Fibonacci
        private void btnFibo_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtfibo.Text), a = 0, b = 1, au, i;
            string respuesta = "";
            for (i = 0; i < n; i++)
            {
                au = a;
                a = b;
                b = au + a;
                respuesta +=  "la suma de " + a + " es " + b +"\n" ;

                lblFiboResp.Visible = true;
                //Oculto respuestas
                lblPrimoResp.Visible = false;
                lblTotal2.Visible = false;
                lblTotal2.Visible = false;
                lblTotal.Visible = false;

                lblFiboResp.Text = "" + respuesta;

                txtfibo.Text = "";
            }



        }
        //Dejar invisible las respuestas
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Visible = false;
            lblTotal2.Visible = false;
            lblFiboResp.Visible = false;
            lblPrimoResp.Visible = false;
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
           
        }
        //Pagar producto
        private void btnRetirar2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtPrecio.Text), b = double.Parse(txtcCant.Text), total;
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01};
            sbyte n = 0;
            string respuesta = "Total: \n" ;
            foreach (double denominacion in denominaciones)
            {
                total = a - b;
                while (denominacion <= Math.Round(a, 2))
                {
                    a++;
                    //
                    a -= denominacion;
                    


                }
                if (n > 0)
                {
                    
                    //Oculto las respuestas que no necesito
                    lblPrimoResp.Visible = false;
                    lblFiboResp.Visible = false;
                    lblTotal.Visible = false;

                    //
                    lblTotal2.Visible = true;
                    respuesta +=  total + "\n" + a + (denominacion > 1 ? " Billetes de " : " Monedas de ") + denominacion;

                    n = 0;

                    lblTotal2.Text = respuesta;
                    //limpio
                    txtcCant.Text = "";
                    txtPrecio.Text = "";


                }
            }
        }
     //Primo
        private void btnPrimo_Click_1(object sender, EventArgs e)
        {
            int a = 0, i, n;

            n = int.Parse(txtPrimo.Text);
           
            a = 0;
           
            for (i = 1; i < (n + 1); i++)
              
            if (n % i == 0)
                    a++;
          
            lblPrimoResp.Visible = true;
            //Oculto las respuestas que no necesito
            lblTotal.Visible = false;
            lblTotal2.Visible = false;
            lblFiboResp.Visible = false;

            lblPrimoResp.Text = ((a != 2) ?  n + " No es primo " :  n + "  Es primo" + "\n");
            //limpio
            txtPrimo.Text = "";

        }
    }
}