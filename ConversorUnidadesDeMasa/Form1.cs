using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorUnidadesDeMasa
{
    public partial class Form1 : Form
    {
        Miligramos miligramos = new Miligramos();
        Gramos gramos = new Gramos();
        Decagramos decagramos = new Decagramos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {

            if (txtpeso.Text == "") { MessageBox.Show("Debes ingresar un valor"); }
            else

            {
                miligramos.setpeso(double.Parse(txtpeso.Text));
                if (rbmg.Checked == true)
                {
                    lblresultado.Text = txtpeso.Text + " kilogramos = " + Convert.ToString(String.Format("{0:n0}", miligramos.ConAmg()) + " Miligramos");
                }
                else
                {
                    gramos.setpeso(double.Parse(txtpeso.Text));
                    if (rbgramos.Checked == true)
                    {
                        lblresultado.Text = txtpeso.Text + " Kilogramos = " + Convert.ToString(String.Format("{0:n0}", gramos.ConAg()) + " Gramos");
                    }
                    else
                    {
                        decagramos.setpeso(double.Parse(txtpeso.Text));
                        if (rbdag.Checked == true)
                        {
                            lblresultado.Text = txtpeso.Text + " Kilogramos = " + Convert.ToString(String.Format("{0:n0}", decagramos.ConAdag()) + " Decagramos");
                        }
                    }

                }

                lblresultado.Visible = true
                ;

            }

            
        }
        private void btnconvertirnuevopeso_Click(object sender, EventArgs e)
        {
            txtpeso.Text = String.Empty;
           
            lblresultado.Text = String.Empty;
            txtpeso.Focus();
        }

    }

}        
    

