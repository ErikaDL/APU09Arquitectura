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
    public partial class EliminarMaterial : Form
    {
        conexion c = new conexion();
        public EliminarMaterial()
        {
            InitializeComponent();
            c.llenarCombo(cbEditar, "listapu.materiales");
            if (cbEditar.Items.Count > 0)
                cbEditar.SelectedIndex = 0;
            else
                MessageBox.Show("No hay registros para eliminar", "¡Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "select * from listapu.materiales where CODIGO = '" + cbEditar.Text + "';";

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
                    string unidad = reader.GetString("UNIDAD");
                    double costo = reader.GetDouble("COSTO");
                    txtCodigo.Text = codigo;
                    txtDesc.Text = descripcion;
                    txtUnidad.Text = unidad;
                    txtCosto.Text = costo.ToString();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            c.EliminarMaterial(cbEditar, txtCodigo);
            DialogResult dialog = MessageBox.Show("¿Deseas eliminar otro Material?",
                "Eliminar Material", MessageBoxButtons.YesNo);
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
                a.tabControl1.SelectTab(0);
                c.VisualizarMateriales(a.dGVMateriales);
                c.VisualizarManodeObra(a.dGVMano);
                c.VisualizarEquipo(a.dGVEquipo);
            }
        }
    }
}
