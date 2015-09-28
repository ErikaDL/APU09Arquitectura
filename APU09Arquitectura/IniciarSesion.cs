using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU09Maker
{
    public partial class IniciarSesion : Form
    {
        int contador = 0;
        conexion c = new conexion();

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btIniciarSesionPpal_Click(object sender, EventArgs e)
        {       
            c.IniciarSesion(txtUsuario, txtContrasena, timer1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador < 100)
            {
                progressBar1.Value = contador;
                label3.Text = "Conectando con la Base de Datos..." + progressBar1.Value + " %";
                contador += 5;
            }
            else
            {
                Form1 f = new Form1();
                f.Show();
                f.Text = "APU09Arquitectura Usuario: " + txtUsuario.Text + " Hoy es: " + f.dateTimePicker1.Value;
                f.label1.Text = txtUsuario.Text;
                timer1.Enabled = false;
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoUsuario n = new NuevoUsuario();
            n.Show();
        }
    }
}
