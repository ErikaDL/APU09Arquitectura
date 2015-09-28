using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU09Arquitectura
{
    public partial class IniciarSesionAdmon : Form
    {
        APU09Maker.conexion c = new APU09Maker.conexion();
        int contador = 0;
        public IniciarSesionAdmon()
        {
            InitializeComponent();
        }

        private void btIniciarSesionPpal_Click(object sender, EventArgs e)
        {
            c.IniciarSesionDatos(txtUsuario, txtContrasena, timer1);
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
                DatosPpales d = new DatosPpales();
                d.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }
    }
}
