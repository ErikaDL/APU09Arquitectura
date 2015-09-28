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
    public partial class Form1 : Form
    {
        #region "Variables y Constructor"
        conexion c = new conexion();
        public Form1()
        {
            InitializeComponent();            
        }
        #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region "Menú"
        private void tSIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion i = new IniciarSesion();
            i.MdiParent = this;
            i.Show();
        }

        private void tSNuevoUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario n = new NuevoUsuario();
            n.Show();
        }

        #region "Materiales"
        private void tSBVerMateriales_Click(object sender, EventArgs e)
        {
            AnPrUn apu = new AnPrUn(label1.Text);
            apu.Show();
            apu.tabControl1.SelectTab(0);
            c.VisualizarMateriales(apu.dGVMateriales);
            c.VisualizarManodeObra(apu.dGVMano);
            c.VisualizarEquipo(apu.dGVEquipo);
        }

        private void tSBAgregarMaterial_Click(object sender, EventArgs e)
        {
            AgregarMaterial am = new AgregarMaterial();
            am.Show();
        }

        private void tSBEditarMaterial_Click(object sender, EventArgs e)
        {
            EditarMaterial ed = new EditarMaterial();
            ed.Show();
        }

        private void tSBEliminarMaterial_Click(object sender, EventArgs e)
        {
            EliminarMaterial el = new EliminarMaterial();
            el.Show();
        }
        #endregion

        #region "Mano de Obra"
        private void tSBVerMano_Click(object sender, EventArgs e)
        {
            AnPrUn apu = new AnPrUn(label1.Text);
            apu.Show();
            apu.tabControl1.SelectTab(1);
            apu.dGVManoBoton.Rows.Clear();
            c.VisualizarMateriales(apu.dGVMateriales);
            c.VisualizarManodeObra(apu.dGVMano);
            c.VisualizarEquipo(apu.dGVEquipo);
        }

        private void tSBAgregarMano_Click(object sender, EventArgs e)
        {
            AgregarMano agregar = new AgregarMano();
            agregar.Show();
        }

        private void tSBEditarMano_Click(object sender, EventArgs e)
        {
            EditarMano editar = new EditarMano();
            editar.Show();
        }

        private void tSBEliminarMano_Click(object sender, EventArgs e)
        {
            EliminarMano eliminar = new EliminarMano();
            eliminar.Show();
        }

        private void DatosPpales_Click(object sender, EventArgs e)
        {
            APU09Arquitectura.IniciarSesionAdmon i = new APU09Arquitectura.IniciarSesionAdmon();
            i.Show();
        }
        #endregion

        #region "Equipo/Maquinaria"
        private void tSBVerEQ_Click(object sender, EventArgs e)
        {
            AnPrUn apu = new AnPrUn(label1.Text);
            apu.Show();
            apu.tabControl1.SelectTab(2);
            c.VisualizarMateriales(apu.dGVMateriales);
            c.VisualizarManodeObra(apu.dGVMano);
            c.VisualizarEquipo(apu.dGVEquipo);
        }

        private void tSBAgregarEQ_Click(object sender, EventArgs e)
        {
            AgregarEQ agregar = new AgregarEQ();
            agregar.Show();
        }

        private void tSBEditarEQ_Click(object sender, EventArgs e)
        {
            EditarEQ editar = new EditarEQ();
            editar.Show();
        }

        private void tSBEliminarEQ_Click(object sender, EventArgs e)
        {
            EliminarEQ eliminar = new EliminarEQ();
            eliminar.Show();
        }
        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            APU09Arquitectura.Presupuestos p = new APU09Arquitectura.Presupuestos();
            p.Show();
            //c.VisualizarTAPU(p.dGVTAPU);
        }

        private void tls_AbrirTarjeta_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            MySqlConnection conexionBD = new MySqlConnection(constring);
            conexionBD.Open();
            DataTable tabla;
            MySqlDataAdapter datosAdapter;
            MySqlCommandBuilder comandoSQL;
            tabla = new DataTable();
            datosAdapter = new MySqlDataAdapter("SELECT count(*) as count FROM listapu.vp_titulos", conexionBD);
            comandoSQL = new MySqlCommandBuilder(datosAdapter);
            
            datosAdapter.Fill(tabla);
            dGV_Temp.DataSource = tabla;
            int count = Convert.ToInt32(dGV_Temp[0, 0].Value);
            if (count > 0)
            {
                APU09Arquitectura.AbrirTarjeta abrir = new APU09Arquitectura.AbrirTarjeta();
                abrir.Show();
            }
            else
                MessageBox.Show("No hay Tarjetas para mostrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

    }
}
#endregion