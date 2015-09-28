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

namespace APU09Arquitectura
{
    public partial class Presupuestos : Form
    {
        APU09Maker.conexion c = new APU09Maker.conexion();
        public Presupuestos()
        {
            InitializeComponent();
            c.llenarComboTAPU(cb_clave);
            if (cb_clave.Items.Count > 0)
                cb_clave.SelectedIndex = 0;
            else
                MessageBox.Show("No hay registros para mostrar", "¡Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.GuardarArreglo(dGVTAPU);
        }

        private void cb_clave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "select Concepto, Unidad, PrecioUnitario from listapu.vp_titulos where Clave = '" + cb_clave.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string concepto = reader.GetString("Concepto");
                    string unidad = reader.GetString("Unidad");
                    double pu = reader.GetDouble("PrecioUnitario");

                    txtConcepto.Text = concepto;
                    txtUnidad.Text = unidad;
                    txtPU.Text = pu.ToString("0.##");
                }
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int i = 0;
        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            dGVTAPU.Rows.Add();
            dGVTAPU[0, i].Value = i + 1;
            dGVTAPU[1, i].Value = txtConcepto.Text;
            dGVTAPU[2, i].Value = txtUnidad.Text;
            dGVTAPU[3, i].Value = 0;
            dGVTAPU[4, i].Value = txtPU.Text;
            dGVTAPU[5, i].Value = 0;
            i++;
        }
    }
}
