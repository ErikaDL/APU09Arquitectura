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
    public partial class EliminarMano : Form
    {
        conexion c = new conexion();
        public EliminarMano()
        {
            InitializeComponent();
            c.llenarCombo(cbEliminar, "listapu.manodeobra");
            if (cbEliminar.Items.Count > 0)
                cbEliminar.SelectedIndex = 0;
            else
                MessageBox.Show("No hay registros para eliminar", "¡Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "select Codigo, Ocupacion, SueldoSemanalVigente from listapu.manodeobra where Codigo = '" + cbEliminar.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string codigo = reader.GetString("Codigo");
                    string ocupacion = reader.GetString("Ocupacion");
                    double ssv = reader.GetDouble("SueldoSemanalVigente");

                    txtCodigo.Text = codigo;
                    txtOcupacion.Text = ocupacion;
                    txtSSV.Text = ssv.ToString("0.##");
                }
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.EliminarMano(cbEliminar, txtCodigo);
            DialogResult dialog = MessageBox.Show("¿Deseas eliminar otra persona?",
                "Eliminar Personal", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
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
                a.tabControl1.SelectTab(1);
                c.VisualizarMateriales(a.dGVMateriales);
                c.VisualizarManodeObra(a.dGVMano);
                c.VisualizarEquipo(a.dGVEquipo);
            }
        }
    }
}
