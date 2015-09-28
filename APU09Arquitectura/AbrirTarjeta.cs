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
    public partial class AbrirTarjeta : Form
    {
        APU09Maker.conexion c = new APU09Maker.conexion();

        public AbrirTarjeta()
        {
            InitializeComponent();
            c.llenarComboTAPU(cb_clave);
            if (cb_clave.Items.Count > 0)
                cb_clave.SelectedIndex = 0;                
            else
            {
                MessageBox.Show("No hay registros para mostrar", "¡Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void bt_VistaPrevia_Click(object sender, EventArgs e)
        {
            APU09Maker.VistaPrevia vp = new APU09Maker.VistaPrevia("");
            vp.Show();
            vp.tSBGuardardesdeTarjeta.Visible = true;
            vp.tls_Guardar.Visible = false;
            c.vp_titulos(cb_clave, vp.txtClave, vp.txtConcepto, vp.txtUnidad, vp.txtPU);
            c.vp_materiales(vp.dGVMateriales, cb_clave);
            vp.dGV_AgregarMAT.Visible = true;
            for (int i = 0; i < vp.dGVMateriales.RowCount; i++)
            {
                vp.dGV_AgregarMAT.Rows.Add();
                for (int j = 0; j < vp.dGVMateriales.ColumnCount; j++)
                    vp.dGV_AgregarMAT[j, i].Value = vp.dGVMateriales[j, i].Value;
            }
            c.vp_manodeobra(vp.dGVManodeObra, cb_clave);
            vp.dGV_AgregarMAN.Visible = true;
            for (int i = 0; i < vp.dGVManodeObra.RowCount; i++)
            {
                vp.dGV_AgregarMAN.Rows.Add();
                for (int j = 0; j < vp.dGVManodeObra.ColumnCount; j++)
                    vp.dGV_AgregarMAN[j, i].Value = vp.dGVManodeObra[j, i].Value;
            }
            c.vp_eqmaq(vp.dGVEquipo, cb_clave);
            vp.dGV_AgregarEQMAQ.Visible = true;
            for (int i = 0; i < vp.dGVEquipo.RowCount; i++)
            {
                vp.dGV_AgregarEQMAQ.Rows.Add();
                for (int j = 0; j < vp.dGVEquipo.ColumnCount; j++)
                    vp.dGV_AgregarEQMAQ[j, i].Value = vp.dGVEquipo[j, i].Value;
            }
            c.vp_costos(cb_clave, vp.lbl_SumaImpMAT, vp.lbl_SumaImpMAN, vp.lbl_SumaImpEQ, vp.txtCostoDir, vp.txtIndCam, vp.txtIndOF, vp.txtUtilidad, vp.txtFinanciamiento, vp.txtPrecioUnitario);
            c.vp_porc_obs_el(cb_clave, vp.IndCamptxt, vp.IndOFtxt, vp.Utilidadtxt, vp.Finantxt, vp.txtObservaciones, vp.txtUsuario);
            vp.dGV_AgregarMAT.Columns[0].ReadOnly = true;
            vp.dGV_AgregarMAT.Columns[1].ReadOnly = true;
            vp.dGV_AgregarMAT.Columns[2].ReadOnly = true;
            vp.dGV_AgregarMAT.Columns[3].ReadOnly = true;
            vp.dGV_AgregarMAT.Columns[4].ReadOnly = true;

            vp.dGV_AgregarMAN.Columns[0].ReadOnly = true;
            vp.dGV_AgregarMAN.Columns[1].ReadOnly = true;
            vp.dGV_AgregarMAN.Columns[2].ReadOnly = true;
            vp.dGV_AgregarMAN.Columns[3].ReadOnly = true;
            vp.dGV_AgregarMAN.Columns[4].ReadOnly = true;

            vp.dGV_AgregarEQMAQ.Columns[0].ReadOnly = true;
            vp.dGV_AgregarEQMAQ.Columns[1].ReadOnly = true;
            vp.dGV_AgregarEQMAQ.Columns[2].ReadOnly = true;
            vp.dGV_AgregarEQMAQ.Columns[3].ReadOnly = true;
            vp.dGV_AgregarEQMAQ.Columns[4].ReadOnly = true;

            if (vp.dGV_AgregarMAT.RowCount == 0)
                vp.lbl_SumaImpMAT.Text = "0.00";
            if (vp.dGV_AgregarMAN.RowCount == 0)
                vp.lbl_SumaImpMAN.Text = "0.00";
            if (vp.dGV_AgregarEQMAQ.RowCount == 0)
                vp.lbl_SumaImpEQ.Text = "0.00";
            this.Close();
            vp.dGVEquipo.Visible = false;
            vp.dGVManodeObra.Visible = false;
            vp.dGVMateriales.Visible = false;

            vp.dGV_AgregarMAT.Visible = true;
            vp.dGV_AgregarMAN.Visible = true;
            vp.dGV_AgregarEQMAQ.Visible = true;
            
        }

    }
}
