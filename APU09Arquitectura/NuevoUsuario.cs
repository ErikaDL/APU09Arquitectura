using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using InputKey;
using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

namespace APU09Maker
{
    public partial class NuevoUsuario : Form
    {
        conexion c = new conexion();
        string correo,dominio;
        public NuevoUsuario()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
                if (comboBox1.SelectedIndex == 1)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                }                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text != txtRepetir.Text)

                MessageBox.Show("La contraseña no coincide con la confirmación", "Error 00003",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (txtNombre.Text != "" && txtUsuario.Text != "" && txtContrasena.Text != ""
                && txtContrasena.Text == txtRepetir.Text)
            {
                c.NuevoUsuario(txtNombre, txtApellidos, correo, txtUsuario, txtContrasena, comboBox1);
                this.Close();
            }
            else
                MessageBox.Show("Ingresa todos los datos", "Error 00004",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 3)
            {
                dominio = InputDialog.mostrar("Nombre del dominio: ",
                    "Ingresa el dominio", InputDialog.ACEPTAR_CANCELAR_BOTON);
                if (dominio.Contains("@") && dominio.Contains(".com"))
                    correo = txtCorreo.Text + dominio;
                else
                    MessageBox.Show("No olvides agregar " + "@", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                correo = txtCorreo.Text + comboBox2.Text;
        }
    }
}
