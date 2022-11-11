using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = double.Parse(txtFePeso.Text);
            altura = double.Parse(txtFeAltura.Text);

            imc = (peso / (altura * altura));

            txtResultadoFe.Text = Convert.ToString(imc);
            if (peso < 5 || peso > 300 || altura < 0.5 || altura > 2.50) ;
        }
    }
}
