using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string stringNroUno = txtNumeroUno.Text;
            string stringNroDos = txtNumeroDos.Text;

            double nroUno = Convert.ToDouble(stringNroUno);
            double nroDos = Convert.ToDouble(stringNroDos);

            double resultado = nroUno + nroDos;

            lblResultado.Text = resultado.ToString();
        }
    }
}
