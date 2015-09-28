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

namespace APU09Maker
{
    public partial class EditarEQ : Form
    {
        conexion c = new conexion();
        public EditarEQ()
        {
            InitializeComponent();
            c.llenarCombo(cbActualizar, "listapu.equipo");
            if (cbActualizar.Items.Count > 0)
                cbActualizar.SelectedIndex = 0;
            else
                MessageBox.Show("No hay registros para editar", "¡Aviso!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double costohr = Convert.ToDouble(txtCosto.Text) / Convert.ToDouble(txtVida.Text);
                txtCostohr.Text = costohr.ToString("0.##");
            }
            catch
            {
                MessageBox.Show("Revisa los datos ingresados", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            c.ActualizarEquipo(cbActualizar, txtCodigo, txtDesc, txtUnidad, txtCosto, txtVida, txtCostohr);
            DialogResult dialog1 = MessageBox.Show("¿Deseas editar otro Equipo/Maquinaria?", "Editar Equipo/Maquinaria",
               MessageBoxButtons.YesNo);
            if (dialog1 == DialogResult.No)
            {
                this.Close();
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AnPrUn);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                //frm = new AnPrUn();
                //frm.Show();
                AnPrUn a = new AnPrUn();
                a.Show();
                a.tabControl1.SelectTab(2);
                c.VisualizarMateriales(a.dGVMateriales);
                c.VisualizarManodeObra(a.dGVMano);
                c.VisualizarEquipo(a.dGVEquipo);
            }
        }

        private void cbActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "select * from listapu.equipo where CODIGO = '" + cbActualizar.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string codigo = reader.GetString("CODIGO");
                    string descripcion = reader.GetString("DESCRIPCION");
                    double costo = reader.GetDouble("COSTO");
                    double vida = reader.GetDouble("VIDAUTIL");
                    string unidad = reader.GetString("UNIDAD");
                    double costohr = reader.GetDouble("COSTOHR");

                    txtCodigo.Text = codigo;
                    txtDesc.Text = descripcion;
                    txtCosto.Text = costo.ToString("0.##");
                    txtVida.Text = vida.ToString("0.##");
                    txtUnidad.Text = unidad;
                    txtCostohr.Text = costohr.ToString("0.##");
                }
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
