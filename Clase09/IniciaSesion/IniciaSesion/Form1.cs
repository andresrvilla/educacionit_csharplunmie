using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IniciaSesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToLower() == "admin" && txtPassword.Text == "admin")
            {
                lblResultado.Text = "Inicio sesión correctamente";
            }
            else
            {
                lblResultado.Text = "Error al iniciar sesión";
            }
        }
    }
}
