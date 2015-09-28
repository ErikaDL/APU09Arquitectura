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
    public partial class EditarMaterial : Form
    {
        conexion c = new conexion();
        public EditarMaterial()
        {
            InitializeComponent();
            c.llenarCombo(cbEditar, "listapu.materiales");
            if (cbEditar.Items.Count > 0)
                cbEditar.SelectedIndex = 0;
            else
                MessageBox.Show("No hay registros para editar", "¡Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            c.ActualizarMaterial(cbEditar, txtCodigo, txtDesc, txtUnidad, txtCosto);
            DialogResult dialog = MessageBox.Show("¿Deseas editar otro material?",
                "Editar Material", MessageBoxButtons.YesNo);
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

        private void cbEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "Database=listapu;Data Source=localhost;User Id=root;Password=";
            string query = "select * from materiales where Codigo = '" + cbEditar.Text + "';";

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
                    string descripcion = reader.GetString("Descripcion");
                    string unidad = reader.GetString("Unidad");
                    double costo = reader.GetDouble("Costo");
                    txtCodigo.Text = codigo;
                    txtDesc.Text = descripcion;
                    txtUnidad.Text = unidad;
                    txtCosto.Text = costo.ToString();
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
