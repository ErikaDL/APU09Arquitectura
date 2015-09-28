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
    public partial class AnPrUn : Form
    {
        conexion c = new conexion();
        string usuario;
        public AnPrUn()
        {
            InitializeComponent();            
        }

        public AnPrUn(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        
        #region Materiales        
        private void btAgregarMaterial_Click(object sender, EventArgs e)
        {
            AgregarMaterial a = new AgregarMaterial();
            a.Show();
        }

        private void btEditarMaterial_Click(object sender, EventArgs e)
        {
            EditarMaterial a = new EditarMaterial();
            a.Show();
        }

        private void btEliminarMaterial_Click(object sender, EventArgs e)
        {
            EliminarMaterial el = new EliminarMaterial();
            el.Show();
        }

        private void SumImMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(sender, e, SumImMat);
        }

        private void dGVMateriales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double importe = 0;
            double total = 0;
            try
            {
                for (int i = 0; i < dGVMateriales.RowCount; i++)
                {
                    importe = Convert.ToDouble(dGVMateriales[4, i].Value) * Convert.ToDouble(dGVMateriales[5, i].Value);
                    dGVMateriales[6, i].Value = importe.ToString("0.##");
                    total += importe;
                }
                SumImMat.Text = total.ToString("0.##");
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region ManodeObra
        private void btAgregarMano_Click_1(object sender, EventArgs e)
        {
            AgregarMano agregar = new AgregarMano();
            agregar.Show();
        }

        private void btEditarMano_Click_1(object sender, EventArgs e)
        {
            EditarMano editar = new EditarMano();
            editar.Show();
        }

        private void btEliminarMano_Click_1(object sender, EventArgs e)
        {
            EliminarMano eliminar = new EliminarMano();
            eliminar.Show();
        }

        private void SumImMano_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(sender, e, SumImMano);
        }

        private void dGVMano_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double importe = 0;
            double total = 0;
            try
            {
                for (int i = 0; i < dGVMano.RowCount; i++)
                {
                    importe = Convert.ToDouble(dGVMano[4, i].Value) * Convert.ToDouble(dGVMano[5, i].Value);
                    dGVMano[6, i].Value = importe.ToString("0.##");
                    total += importe;
                }
                SumImMano.Text = total.ToString("0.##");
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
    
        #endregion

        #region EqMaq
        private void btAgregarEQ_Click(object sender, EventArgs e)
        {
            AgregarEQ agregar = new AgregarEQ();
            agregar.Show();
        }

        private void btEditarEQ_Click(object sender, EventArgs e)
        {
            EditarEQ editar = new EditarEQ();
            editar.Show();
        }

        private void btEliminarEQ_Click(object sender, EventArgs e)
        {
            EliminarEQ eliminar = new EliminarEQ();
            eliminar.Show();
        }

        private void SumImEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(sender, e, SumImEQ);
        }

        private void dGVEquipo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double importe = 0;
            double total = 0;
            try
            {
                for (int i = 0; i < dGVEquipo.RowCount; i++)
                {
                    importe = Convert.ToDouble(dGVEquipo[4, i].Value) * Convert.ToDouble(dGVEquipo[5, i].Value);
                    dGVEquipo[6, i].Value = importe.ToString("0.##");
                    total += importe;
                }
                SumImEQ.Text = total.ToString("0.##");
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SumImEQ.Clear();
            double suma = 0;
            for (int i = 0; i < dGVEquipo.RowCount; i++)
                suma += Convert.ToDouble(dGVEquipo[6, i].Value);
            SumImEQ.Text = suma.ToString("0.##");
        }
        #endregion

        #region Metodos
        private void Numeros(object sender, KeyPressEventArgs e, TextBox txt)
        {
            if (txt.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
                if (e.KeyChar == '\b')
                    e.Handled = false;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
                if (e.KeyChar == '.' || e.KeyChar == '\b')
                    e.Handled = false;
            }
        }
        #endregion            

        #region Todos
        private void btFiltrarMat_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                c.Filtrar(dGVMateriales);
            else
                if (tabControl1.SelectedIndex == 1)
                    c.Filtrar(dGVMano);
                else
                    if (tabControl1.SelectedIndex == 2)
                        c.Filtrar(dGVEquipo);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            VistaPrevia vistaprevia = new VistaPrevia(usuario);
            vistaprevia.Show();
            vistaprevia.tls_Guardar.Visible = true;
            vistaprevia.tSBGuardardesdeTarjeta.Visible = false;
            //MATERIALES
            vistaprevia.dGVMateriales.Columns.Add("col0", "Clave");
            vistaprevia.dGVMateriales.Columns[0].Visible = false;
            vistaprevia.dGVMateriales.Columns.Add("col1", "Código");
            vistaprevia.dGVMateriales.Columns.Add("col2", "Descripción");
            vistaprevia.dGVMateriales.Columns[2].Width = 130;
            vistaprevia.dGVMateriales.Columns.Add("col3", "Unidad");
            vistaprevia.dGVMateriales.Columns.Add("col4", "Costo");
            vistaprevia.dGVMateriales.Columns.Add("col5", "Rendimiento");
            vistaprevia.dGVMateriales.Columns.Add("col6", "Importe");
            
            for (int j = 0; j < dGVMateriales.RowCount; j++)
            {
                vistaprevia.dGVMateriales.Rows.Add();
                for (int i = 1; i < dGVMateriales.ColumnCount; i++)
                    vistaprevia.dGVMateriales[i, j].Value = dGVMateriales[i, j].Value;
            }
            if (SumImMat.Text == "")
                SumImMat.Text = "0.00";
            vistaprevia.lbl_SumaImpMAT.Text = SumImMat.Text;
            
            //MANO DE OBRA
            vistaprevia.dGVManodeObra.Columns.Add("col0", "Clave");
            vistaprevia.dGVManodeObra.Columns[0].Visible = false;
            vistaprevia.dGVManodeObra.Columns.Add("col1", "Código");
            vistaprevia.dGVManodeObra.Columns.Add("col2", "Ocupación");
            vistaprevia.dGVManodeObra.Columns[2].Width = 130;
            vistaprevia.dGVManodeObra.Columns.Add("col3", "Sueldo Sem. Vig.");
            vistaprevia.dGVManodeObra.Columns.Add("col4", "Salario Total");
            vistaprevia.dGVManodeObra.Columns.Add("col5", "Rendimiento");
            vistaprevia.dGVManodeObra.Columns.Add("col6", "Importe");

            for (int j = 0; j < dGVMano.RowCount; j++)
            {
                vistaprevia.dGVManodeObra.Rows.Add();
                for (int i = 1; i < dGVMano.ColumnCount; i++)
                    vistaprevia.dGVManodeObra[i, j].Value = dGVMano[i, j].Value;
            }
            if (SumImMano.Text == "")
                SumImMano.Text = "0.00";
            vistaprevia.lbl_SumaImpMAN.Text = SumImMano.Text;

            //EQUIPO
            vistaprevia.dGVEquipo.Columns.Add("col0", "Clave");
            vistaprevia.dGVEquipo.Columns[0].Visible = false;
            vistaprevia.dGVEquipo.Columns.Add("col1", "Código");
            vistaprevia.dGVEquipo.Columns.Add("col2", "Descripción");
            vistaprevia.dGVEquipo.Columns[2].Width = 130;
            vistaprevia.dGVEquipo.Columns.Add("col3", "Unidad");
            vistaprevia.dGVEquipo.Columns.Add("col4", "Costo Hr");
            vistaprevia.dGVEquipo.Columns.Add("col5", "Rendimiento");
            vistaprevia.dGVEquipo.Columns.Add("col6", "Importe");
            for (int j = 0; j < dGVEquipo.RowCount; j++)
            {
                vistaprevia.dGVEquipo.Rows.Add();
                for (int i = 1; i < dGVEquipo.ColumnCount; i++)
                    vistaprevia.dGVEquipo[i, j].Value = dGVEquipo[i, j].Value;
            }
            if (SumImEQ.Text == "")
                SumImEQ.Text = "0.00";
            vistaprevia.lbl_SumaImpEQ.Text = SumImEQ.Text;

            SumImMat.Clear();
            SumImMano.Clear();
            SumImEQ.Clear();
            vistaprevia.dGV_AgregarMAT.Visible = false;
            vistaprevia.dGV_AgregarMAN.Visible = false;
            vistaprevia.dGV_AgregarEQMAQ.Visible = false;

            vistaprevia.dGVEquipo.Visible = true;
            vistaprevia.dGVManodeObra.Visible = true;
            vistaprevia.dGVMateriales.Visible = true;
        }
        #endregion

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "")
        //        btBuscar.Enabled = false;
        //    else
        //        btBuscar.Enabled = true;
        //}

        //private void btBuscar_Click(object sender, EventArgs e)
        //{
        //    dGVMano.Visible = false;
        //    dGVManoBoton.Visible = true;
        //    DataTable tabla;
        //    MySqlDataAdapter datosAdapter;
        //    MySqlCommandBuilder comandoSQL;
        //    string constring = "datasource = localhost; port = 3306; username = root; password = ";
        //    MySqlConnection con = new MySqlConnection(constring);
        //    try
        //    {
        //        //HACEMOS LA CONSULTA DEL CODIGO QUE ESTAMOS BUSCANDO
        //        con.Open();
        //        tabla = new DataTable();
        //        datosAdapter = new MySqlDataAdapter("select Codigo, Ocupacion, SueldoSemanalVigente, SalarioTotal, Rendimiento, Importe from listapu.manodeobra where Codigo like '" + textBox1.Text + "%'", con);
        //        comandoSQL = new MySqlCommandBuilder(datosAdapter);
        //        datosAdapter.Fill(tabla);

        //        dGVManoBoton.DataSource = tabla;

        //        dGVManoBoton.Columns[0].Width = 50;
        //        dGVManoBoton.Columns[2].Width = 300;
        //        dGVManoBoton.Columns[3].Width = 170;
        //        dGVManoBoton.Columns[3].HeaderText = "Sueldo Sem. Vig.";
        //        dGVManoBoton.Columns[4].Width = 120;
        //        dGVManoBoton.Columns[4].HeaderText = "Salario Total";

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al mostrar los datos de la tabla [manodeobra] de MySQL: " + ex.ToString(),
        //            "Error ejecutar SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void dGVManoBoton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dGVManoBoton.Rows[e.RowIndex];
                
                string codigo = row.Cells[1].Value.ToString();

                DataGridViewRow rows = new DataGridViewRow();
                for (int i = 0; i < dGVMano.RowCount; i++)
                {
                    rows = dGVMano.Rows[i];
                    if(codigo == rows.Cells[1].Value.ToString())
                    {
                        rows.Cells[0].Value = true;
                    }
                }
            }

        }
        
        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                c.VisualizarMateriales(dGVMateriales);
                
            }
            else
                if (tabControl1.SelectedIndex == 1)
                {
                    if (MessageBox.Show("Al actualizar se borrará cualquier selección, ¿desea continuar?", 
                        "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dGVMano.Visible = true;
                        dGVManoBoton.Visible = false;
                        c.VisualizarManodeObra(dGVMano);
                    }
                    else
                    {
                        dGVMano.Visible = true;
                        dGVManoBoton.Visible = false;
                    }

        
                    //HACEMOS UN RENGLON POR CADA RESULTADO QUE SE MUESTRA EN EL DGV OCULTO
                    /* string codigo = "";
                     DataGridViewRow rowdGVBuscarMano = new DataGridViewRow();
                     for (int i = 0; i < dGVBuscarMano.Rows.Count; i++)
                     {
                         rowdGVBuscarMano = dGVBuscarMano.Rows[i];
                         rowdGVBuscarMano.Cells[0].Value = true;
                         codigo = rowdGVBuscarMano.Cells[1].Value.ToString();
                         for (int j = 0; j < dGVMano.Rows.Count; j++)
                         {
                             if (codigo == Convert.ToString(dGVMano[1, j].Value))
                             {
                                 DataGridViewRow rowdGVMano = new DataGridViewRow();
                                 rowdGVMano = dGVMano.Rows[j];
                                 rowdGVMano.Cells[0].Value = true;
                             }
                         }
                     }*/

                }
                else
                    if (tabControl1.SelectedIndex == 2)
                        c.VisualizarEquipo(dGVEquipo);
        }

        

    }
}


