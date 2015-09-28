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
    public partial class VistaPrevia : Form, APU09Arquitectura.IAgregar
    {
        #region "Variables y Constructor"
        conexion c = new conexion();
        APU09Arquitectura.AbrirTarjeta abrir = new APU09Arquitectura.AbrirTarjeta();

        string constring = "datasource = localhost; port = 3306; username = root; password = ";
        string query;
        MySqlConnection conexionBD;
        MySqlDataAdapter datosAdapter;
        MySqlCommandBuilder comandoSQL;
        DataTable tabla;
        MySqlCommand cmd;
        MySqlDataReader reader;

        double costodirecto = 0;
        string usuario;
        int rowsdGV = 0, rowsBD = 0;
        bool agregarMAT = true;
        bool agregarMAN = true;
        bool agregarEQMAQ = true;
        bool GuardarNueva = false;
        bool GuardarCambios = false;

        public VistaPrevia(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        public void AgregarMAT(string codigo, string desc, string unidad, double costo)
        {
            agregarMAT = true;
            for (int i = 0; i < dGV_AgregarMAT.RowCount; i++)
            {
                if (dGV_AgregarMAT[1, i].Value.ToString() == codigo)
                {
                    agregarMAT = false;
                    MessageBox.Show("no se puede agregar");
                }
            }
            if (agregarMAT == true)
            {
                dGV_AgregarMAT.Rows.Add();
                rowsBD = dGV_AgregarMAT.RowCount - 1;
                dGV_AgregarMAT[0, rowsBD].Value = txtClave.Text;
                dGV_AgregarMAT[1, rowsBD].Value = codigo;
                dGV_AgregarMAT[2, rowsBD].Value = desc;
                dGV_AgregarMAT[3, rowsBD].Value = unidad;
                dGV_AgregarMAT[4, rowsBD].Value = costo;
                //rowsBD++;
            }
        }

        public void AgregarMAN(string codigo, string desc, string unidad, double costo)
        {
            agregarMAN = true;
            for (int i = 0; i < dGV_AgregarMAN.RowCount; i++)
            {
                if (dGV_AgregarMAN[1, i].Value.ToString() == codigo)
                {
                    agregarMAN = false;
                    MessageBox.Show("no se puede agregar");
                }
            }
            if (agregarMAN == true)
            {
                dGV_AgregarMAN.Rows.Add();
                rowsBD = dGV_AgregarMAN.RowCount - 1;
                dGV_AgregarMAN[0, rowsBD].Value = txtClave.Text;
                dGV_AgregarMAN[1, rowsBD].Value = codigo;
                dGV_AgregarMAN[2, rowsBD].Value = desc;
                dGV_AgregarMAN[3, rowsBD].Value = unidad;
                dGV_AgregarMAN[4, rowsBD].Value = costo;
                //rowsBD++;
            }
        }

        public void AgregarEQMAQ(string codigo, string desc, string unidad, double costohr)
        {
            agregarEQMAQ = true;
            for (int i = 0; i < dGV_AgregarEQMAQ.RowCount; i++)
            {
                if (dGV_AgregarEQMAQ[1, i].Value.ToString() == codigo)
                {
                    agregarEQMAQ = false;
                    MessageBox.Show("no se puede agregar");
                }
            }
            if (agregarEQMAQ == true)
            {
                dGV_AgregarEQMAQ.Rows.Add();
                rowsBD = dGV_AgregarEQMAQ.RowCount - 1;
                dGV_AgregarEQMAQ[0, rowsBD].Value = txtClave.Text;
                dGV_AgregarEQMAQ[1, rowsBD].Value = codigo;
                dGV_AgregarEQMAQ[2, rowsBD].Value = desc;
                dGV_AgregarEQMAQ[3, rowsBD].Value = unidad;
                dGV_AgregarEQMAQ[4, rowsBD].Value = costohr;
                //rowsBD++;
            }
        }

        #endregion

        #region "Títulos"
        public void UpdateTitulos()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);

                query = "UPDATE listapu.vp_titulos " +
                        "SET Concepto =  '" + txtConcepto.Text +
                        "', Unidad = '" + txtUnidad.Text +
                        "', PrecioUnitario = '" + txtPU.Text +
                        "' WHERE Clave = '" + txtClave.Text + "';";

                cmd = new MySqlCommand(query, conexionBD);
                conexionBD.Open();
                reader = cmd.ExecuteReader();
                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertTitulos()
        {
            conexionBD = new MySqlConnection(constring);
            query = "INSERT INTO listapu.vp_titulos (Clave, Concepto, Unidad, PrecioUnitario) " +
                    "Values(?cl,?con,?un,?pu);";
            cmd = new MySqlCommand(query);
            cmd.Parameters.Add("?cl", MySqlDbType.VarChar, 20).Value = txtClave.Text;
            cmd.Parameters.Add("?con", MySqlDbType.VarChar, 50).Value = txtConcepto.Text;
            cmd.Parameters.Add("?un", MySqlDbType.VarChar, 10).Value = txtUnidad.Text;
            cmd.Parameters.Add("?pu", MySqlDbType.Double, 10).Value = txtPU.Text;
            cmd.Connection = conexionBD;
            conexionBD.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Titulos()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                conexionBD.Open();
                tabla = new DataTable();
                query = "SELECT COUNT(*) as Count " +
                        "FROM listapu.vp_titulos " +
                        "WHERE Clave = '" + txtClave.Text + "'";
                datosAdapter = new MySqlDataAdapter(query, conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGV_Temp.DataSource = tabla;
                rowsBD = Convert.ToInt32(dGV_Temp[0, 0].Value);
                if (rowsBD == 1)
                    UpdateTitulos();
                else
                    if (rowsBD == 0)
                        InsertTitulos();
                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Materiales"
        public void UpdateMAT(DataGridView dGV)
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                for (int i = 0; i < dGV.RowCount; i++)
                {
                    query = "UPDATE listapu.vp_materiales " +
                            "SET Codigo =  '" + dGV[1, i].Value +
                            "', Descripcion = '" + dGV[2, i].Value +
                            "', Unidad = '" + dGV[3, i].Value +
                            "', Costo = '" + dGV[4, i].Value +
                            "', Rendimiento = '" + dGV[5, i].Value +
                            "', Importe = '" + dGV[6, i].Value +
                            "' WHERE clave_tarjeta = '" + txtClave.Text + "';";

                    cmd = new MySqlCommand(query, conexionBD);
                    conexionBD.Open();
                    reader = cmd.ExecuteReader();
                    conexionBD.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al actualizar Materiales", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteMAT()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                query = "DELETE FROM listapu.vp_materiales " +
                        "WHERE clave_tarjeta = '" + txtClave.Text + "';";

                cmd = new MySqlCommand(query, conexionBD);
                conexionBD.Open();
                reader = cmd.ExecuteReader();
                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al eliminar Materiales", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertMAT(DataGridView dGV)
        {
            try
            {
                for (int i = 0; i < dGV.RowCount; i++)
                    dGV[0, i].Value = txtClave.Text;

                conexionBD = new MySqlConnection(constring);
                query = "INSERT INTO listapu.vp_materiales (clave_tarjeta, Codigo, " +
                        "Descripcion, Unidad, Costo, Rendimiento, Importe) " +
                        "Values(?clave, ?cod, ?desc, ?uni, ?cos, ?rend, ?imp)";
                cmd = new MySqlCommand(query);
                conexionBD.Open();

                foreach (DataGridViewRow row in dGV.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?clave", MySqlDbType.VarChar, 20).Value = row.Cells[0].Value;
                    cmd.Parameters.Add("?cod", MySqlDbType.VarChar, 20).Value = row.Cells[1].Value;
                    cmd.Parameters.Add("?desc", MySqlDbType.VarChar, 100).Value = row.Cells[2].Value;
                    cmd.Parameters.Add("?uni", MySqlDbType.VarChar, 10).Value = row.Cells[3].Value;
                    cmd.Parameters.Add("?cos", MySqlDbType.Double).Value = row.Cells[4].Value;
                    cmd.Parameters.Add("?rend", MySqlDbType.Double).Value = row.Cells[5].Value;
                    cmd.Parameters.Add("?imp", MySqlDbType.Double).Value = row.Cells[6].Value;
                    cmd.Connection = conexionBD;
                    cmd.ExecuteNonQuery();
                }
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Error al Agregar Materiales", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Materiales(DataGridView dGV)
        {
            try
            {
            conexionBD = new MySqlConnection(constring);
            conexionBD.Open();
            tabla = new DataTable();

            query = "SELECT count(*) as Count " +
                    "FROM listapu.vp_materiales " +
                    "WHERE clave_tarjeta = '" + txtClave.Text + "'";
            datosAdapter = new MySqlDataAdapter(query, conexionBD);
            comandoSQL = new MySqlCommandBuilder(datosAdapter);
            datosAdapter.Fill(tabla);
            dGV_Temp.DataSource = tabla;
            rowsdGV = dGV.RowCount;
            rowsBD = Convert.ToInt32(dGV_Temp[0, 0].Value);
            conexionBD.Close();
            //if (rowsdGV == rowsBD)
            //    UpdateMAT();
            //else
            if (rowsBD > 0 && rowsdGV > 0)
            {
                if (rowsdGV > rowsBD || rowsdGV < rowsBD || rowsdGV == rowsBD)
                {
                    DeleteMAT();
                    InsertMAT(dGV);
                }
            }
            else
                if (rowsBD == 0 && rowsdGV > 0)
                    InsertMAT(dGV);
                else
                    if (rowsdGV == 0 && rowsBD > 0)
                        DeleteMAT();
                    else
                        if (rowsBD == 0 && rowsdGV == 0)
                            return;
            }
            catch
            {
                MessageBox.Show("Error al Guardar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SumarMAT(DataGridView dGV)
        {
            double importe = 0;
            double total = 0;
            for (int i = 0; i < dGV.RowCount; i++)
            {
                importe = Convert.ToDouble(dGV[4, i].Value) * Convert.ToDouble(dGV[5, i].Value);
                dGV[6, i].Value = importe.ToString("0.##");
                total += importe;
            }
            lbl_SumaImpMAT.Text = total.ToString();
        }

        private void dGV_AgregarMAT_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumarMAT(dGV_AgregarMAT);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGV_AgregarMAT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumarMAT(dGV_AgregarMAT);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumarMAT(dGVMateriales);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVMateriales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumarMAT(dGVMateriales);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region "Mano de Obra"
        public void UpdateMAN(DataGridView dGV)
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                for (int i = 0; i < dGV.RowCount; i++)
                {
                    query = "UPDATE listapu.vp_manodeobra " +
                            "SET Codigo =  '" + dGV[1, i].Value +
                            "', Ocupacion = '" + dGV[2, i].Value +
                            "', SueldoSemVig = '" + dGV[3, i].Value +
                            "', SalarioTotal = '" + dGV[4, i].Value +
                            "', Rendimiento = '" + dGV[5, i].Value +
                            "', Importe = '" + dGV[6, i].Value +
                            "' WHERE clave_tarjeta = '" + txtClave.Text + "';";

                    cmd = new MySqlCommand(query, conexionBD);
                    conexionBD.Open();
                    reader = cmd.ExecuteReader();
                    conexionBD.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al Actualizar Mano de Obra", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteMAN()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                query = "DELETE FROM listapu.vp_manodeobra " +
                        "WHERE clave_tarjeta = '" + txtClave.Text + "';";

                cmd = new MySqlCommand(query, conexionBD);
                conexionBD.Open();
                reader = cmd.ExecuteReader();
                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al Eliminar Mano de Obra", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertMAN(DataGridView dGV)
        {
            try
            {
                for (int j = 0; j < dGV.RowCount; j++)
                    dGV[0, j].Value = txtClave.Text;

                conexionBD = new MySqlConnection(constring);
                query = "INSERT INTO listapu.vp_manodeobra (clave_tarjeta, Codigo, Ocupacion, " +
                        "SueldoSemVig, SalarioTotal, Rendimiento, Importe)" +
                        "Values(?clave, ?cod, ?ocup, ?ssv, ?st, ?rend, ?imp)";
                cmd = new MySqlCommand(query);
                conexionBD.Open();

                foreach (DataGridViewRow row in dGV.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?clave", MySqlDbType.VarChar, 20).Value = row.Cells[0].Value;
                    cmd.Parameters.Add("?cod", MySqlDbType.VarChar, 20).Value = row.Cells[1].Value;
                    cmd.Parameters.Add("?ocup", MySqlDbType.VarChar, 100).Value = row.Cells[2].Value;
                    cmd.Parameters.Add("?ssv", MySqlDbType.Double).Value = row.Cells[3].Value;
                    cmd.Parameters.Add("?st", MySqlDbType.Double).Value = row.Cells[4].Value;
                    cmd.Parameters.Add("?rend", MySqlDbType.Double).Value = row.Cells[5].Value;
                    cmd.Parameters.Add("?imp", MySqlDbType.Double).Value = row.Cells[6].Value;
                    cmd.Connection = conexionBD;
                    cmd.ExecuteNonQuery();
                }
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ManodeObra(DataGridView dGV)
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                conexionBD.Open();
                tabla = new DataTable();
                query = "SELECT count(*) as Count " +
                        "FROM listapu.vp_manodeobra " +
                        "WHERE clave_tarjeta = '" + txtClave.Text + "'";
                datosAdapter = new MySqlDataAdapter(query, conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGV_Temp.DataSource = tabla;
                rowsdGV = dGV.RowCount;
                rowsBD = Convert.ToInt32(dGV_Temp[0, 0].Value);
                conexionBD.Close();
                if (rowsBD > 0 && rowsdGV > 0)
                {
                    if (rowsdGV > rowsBD || rowsdGV < rowsBD || rowsdGV == rowsBD)
                    {
                        DeleteMAN();
                        InsertMAN(dGV);
                    }
                }
                else
                    if (rowsBD == 0 && rowsdGV > 0)
                        InsertMAN(dGV);
                    else
                        if (rowsdGV == 0 && rowsBD > 0)
                            DeleteMAN();
                        else
                            if (rowsBD == 0 && rowsdGV == 0)
                                return;
            }
            catch
            {
                MessageBox.Show("Error al Guardar los Datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SumaMAN(DataGridView dGV)
        {
            double importe = 0;
            double total = 0;
            try
            {
                for (int i = 0; i < dGV.RowCount; i++)
                {
                    importe = Convert.ToDouble(dGV[4, i].Value) * Convert.ToDouble(dGV[5, i].Value);
                    dGV[6, i].Value = importe.ToString("0.##");
                    total += importe;
                }
                lbl_SumaImpMAN.Text = total.ToString("0.##");
            }
            catch
            {
                MessageBox.Show("Revisa los datos", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGV_AgregarMAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumaMAN(dGV_AgregarMAN);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGV_AgregarMAN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                    SumaMAN(dGV_AgregarMAN);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVManodeObra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumaMAN(dGVManodeObra);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVManodeObra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumaMAN(dGVManodeObra);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region "Equipo/Maquinaria"
        public void UpdateEQMAQ(DataGridView dGV)
        {
            try
            {
                conexionBD = new MySqlConnection(constring);

                for (int i = 0; i < dGV.RowCount; i++)
                {
                    query = "UPDATE listapu.vp_eqmaq " +
                            "SET Codigo =  '" + dGV[1, i].Value +
                            "', Descripcion = '" + dGV[2, i].Value +
                            "', Unidad = '" + dGV[3, i].Value +
                            "', CostoHr = '" + dGV[4, i].Value +
                            "', Rendimiento = '" + dGV[5, i].Value +
                            "', Importe = '" + dGV[6, i].Value +
                            "' WHERE clave_tarjeta = '" + txtClave.Text + "';";

                    cmd = new MySqlCommand(query, conexionBD);
                    conexionBD.Open();
                    reader = cmd.ExecuteReader();
                    conexionBD.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteEQMAQ()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                query = "DELETE FROM listapu.vp_eqmaq " +
                        "WHERE clave_tarjeta = '" + txtClave.Text + "';";

                cmd = new MySqlCommand(query, conexionBD);
                conexionBD.Open();
                reader = cmd.ExecuteReader();
                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertEQMAQ(DataGridView dGV)
        {
            try
            {
                for (int i = 0; i < dGV.RowCount; i++)
                    dGV[0, i].Value = txtClave.Text;

                conexionBD = new MySqlConnection(constring);
                query = "INSERT INTO listapu.vp_eqmaq (clave_tarjeta, Codigo, Descripcion, " +
                        "Unidad, CostoHr, Rendimiento, Importe)" +
                        "Values(?clave, ?cod, ?desc, ?uni, ?cos, ?rend, ?imp)";
                cmd = new MySqlCommand(query);
                conexionBD.Open();

                foreach (DataGridViewRow row in dGV.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?clave", MySqlDbType.VarChar, 20).Value = row.Cells[0].Value;
                    cmd.Parameters.Add("?cod", MySqlDbType.VarChar, 20).Value = row.Cells[1].Value;
                    cmd.Parameters.Add("?desc", MySqlDbType.VarChar, 100).Value = row.Cells[2].Value;
                    cmd.Parameters.Add("?uni", MySqlDbType.VarChar, 10).Value = row.Cells[3].Value;
                    cmd.Parameters.Add("?cos", MySqlDbType.Double).Value = row.Cells[4].Value;
                    cmd.Parameters.Add("?rend", MySqlDbType.Double).Value = row.Cells[5].Value;
                    cmd.Parameters.Add("?imp", MySqlDbType.Double).Value = row.Cells[6].Value;
                    cmd.Connection = conexionBD;
                    cmd.ExecuteNonQuery();
                }
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EqMaq(DataGridView dGV)
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                conexionBD.Open();
                tabla = new DataTable();
                query = "SELECT count(*) as Count " +
                        "FROM listapu.vp_eqmaq " +
                        "WHERE clave_tarjeta = '" + txtClave.Text + "'";
                datosAdapter = new MySqlDataAdapter(query, conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGV_Temp.DataSource = tabla;
                rowsdGV = dGV.RowCount;                
                rowsBD = Convert.ToInt32(dGV_Temp[0, 0].Value);
                conexionBD.Close();
                if (rowsBD > 0 && rowsdGV > 0)
                {
                    if (rowsdGV > rowsBD || rowsdGV < rowsBD || rowsdGV == rowsBD)
                    {
                        DeleteEQMAQ();
                        InsertEQMAQ(dGV);
                    }
                }
                else
                    if (rowsBD == 0 && rowsdGV > 0)
                        InsertEQMAQ(dGV);
                    else
                        if (rowsdGV == 0 && rowsBD > 0)
                            DeleteEQMAQ();
                        else
                            if (rowsBD == 0 && rowsdGV == 0)
                                return;
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SumaEQ(DataGridView dGV)
        {
            double importe = 0;
            double total = 0;
            for (int i = 0; i < dGV.RowCount; i++)
            {
                importe = Convert.ToDouble(dGV[4, i].Value) * Convert.ToDouble(dGV[5, i].Value);
                dGV[6, i].Value = importe.ToString("0.##");
                total += importe;
            }
            lbl_SumaImpEQ.Text = total.ToString("0.##");
        }

        private void dGV_AgregarEQMAQ_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumaEQ(dGV_AgregarEQMAQ);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGV_AgregarEQMAQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumaEQ(dGV_AgregarEQMAQ);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumaEQ(dGVEquipo);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGVEquipo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    SumaEQ(dGVEquipo);
            }
            catch
            {
                MessageBox.Show("Verifica los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region "Costos"
        public void UpdateCostos()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                query = "UPDATE listapu.vp_costos " +
                        "SET clave_tarjeta = '" + txtClave.Text +
                        "', TotalMateriales =  '" + lbl_SumaImpMAT.Text +
                        "', TotalManodeObra = '" + lbl_SumaImpMAN.Text +
                        "', TotalEquMaq = '" + lbl_SumaImpEQ.Text +
                        "', costoDirecto = '" + txtCostoDir.Text +
                        "', indCamp = '" + txtIndCam.Text +
                        "', indOf = '" + txtIndOF.Text +
                        "', utilidad = '" + txtUtilidad.Text +
                        "', financiamiento = '" + txtFinanciamiento.Text +
                        "', precioUni = '" + txtPrecioUnitario.Text +
                        "' WHERE clave_tarjeta = '" + txtClave.Text + "';";

                cmd = new MySqlCommand(query, conexionBD);
                conexionBD.Open();
                reader = cmd.ExecuteReader();
                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertCostos()
        {
            conexionBD = new MySqlConnection(constring);
            query = "INSERT INTO listapu.vp_costos (clave_tarjeta, TotalMateriales, TotalManodeObra, TotalEquMaq, " +
                    "costoDirecto, indCamp, indOf, utilidad, financiamiento, precioUni) " +
                    "VALUES(?clave, ?mat, ?man, ?eq, ?cosDir, ?indcamp, ?indof, ?util, ?finan, ?pu);";
            cmd = new MySqlCommand(query);
            cmd.Parameters.Add("?clave", MySqlDbType.VarChar, 20).Value = txtClave.Text;
            cmd.Parameters.Add("?mat", MySqlDbType.Double).Value = lbl_SumaImpMAT.Text;
            cmd.Parameters.Add("?man", MySqlDbType.Double).Value = lbl_SumaImpMAN.Text;
            cmd.Parameters.Add("?eq", MySqlDbType.Double).Value = lbl_SumaImpEQ.Text;
            cmd.Parameters.Add("?cosDir", MySqlDbType.Double).Value = txtCostoDir.Text;
            cmd.Parameters.Add("?indcamp", MySqlDbType.Double).Value = txtIndCam.Text;
            cmd.Parameters.Add("?indof", MySqlDbType.Double).Value = txtIndOF.Text;
            cmd.Parameters.Add("?util", MySqlDbType.Double).Value = txtUtilidad.Text;
            cmd.Parameters.Add("?finan", MySqlDbType.Double).Value = txtFinanciamiento.Text;
            cmd.Parameters.Add("?pu", MySqlDbType.Double).Value = txtPrecioUnitario.Text;
            cmd.Connection = conexionBD;
            conexionBD.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Costos()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                conexionBD.Open();
                tabla = new DataTable();
                query = "SELECT count(*) as Count " +
                        "FROM listapu.vp_costos " +
                        "WHERE clave_tarjeta = '" + txtClave.Text + "'";
                datosAdapter = new MySqlDataAdapter(query, conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGV_Temp.DataSource = tabla;
                rowsBD = Convert.ToInt32(dGV_Temp[0, 0].Value);
                conexionBD.Close();
                if (rowsBD == 1)
                    UpdateCostos();
                else
                    if (rowsBD == 0)
                        InsertCostos();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Porcentajes"
        public void UpdatePorcentajes()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);

                query = "UPDATE listapu.vp_porc_obs_el " +
                        "SET clave_tarjeta = '" + txtClave.Text +
                        "', por_indCamp =  '" + IndCamptxt.Text +
                        "', por_indOf = '" + IndOFtxt.Text +
                        "', por_utilidad = '" + Utilidadtxt.Text +
                        "', por_finan = '" + Finantxt.Text +
                        "', observaciones = '" + txtObservaciones.Text +
                        "', elaboro = '" + txtUsuario.Text +
                        "' WHERE clave_tarjeta = '" + txtClave.Text + "';";

                cmd = new MySqlCommand(query, conexionBD);
                conexionBD.Open();
                reader = cmd.ExecuteReader();
                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertPorcentajes()
        {
            conexionBD = new MySqlConnection(constring);
            query = "INSERT INTO listapu.vp_porc_obs_el (clave_tarjeta, por_indCamp, por_indOf, " +
                    "por_utilidad, por_finan, observaciones, elaboro) " +
                    "Values(?clave, ?indCamp, ?indOf, ?utilidad, ?finan, ?obser, ?ela);";
            cmd = new MySqlCommand(query);
            cmd.Parameters.Add("?clave", MySqlDbType.VarChar, 20).Value = txtClave.Text;
            cmd.Parameters.Add("?indCamp", MySqlDbType.Double).Value = IndCamptxt.Text;
            cmd.Parameters.Add("?indOf", MySqlDbType.Double).Value = IndOFtxt.Text;
            cmd.Parameters.Add("?utilidad", MySqlDbType.Double).Value = Utilidadtxt.Text;
            cmd.Parameters.Add("?finan", MySqlDbType.Double).Value = Finantxt.Text;
            cmd.Parameters.Add("?obser", MySqlDbType.VarChar, 300).Value = txtObservaciones.Text;
            cmd.Parameters.Add("?ela", MySqlDbType.VarChar, 20).Value = txtUsuario.Text;
            cmd.Connection = conexionBD;
            conexionBD.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Porcentajes()
        {
            try
            {
                conexionBD = new MySqlConnection(constring);
                conexionBD.Open();
                tabla = new DataTable();
                query = "SELECT count(*) as Count " +
                        "FROM listapu.vp_porc_obs_el " +
                        "WHERE clave_tarjeta = '" + txtClave.Text + "'";
                datosAdapter = new MySqlDataAdapter(query, conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGV_Temp.DataSource = tabla;
                rowsBD = Convert.ToInt32(dGV_Temp[0, 0].Value);
                conexionBD.Close();
                if (rowsBD == 1)
                    UpdatePorcentajes();
                else
                    if (rowsBD == 0)
                        InsertPorcentajes();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Exportar a Excel"
        private void tSBExpExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xla = new Excel.Application();
                Excel.Workbook wb = xla.Workbooks.Add(Excel.XlSheetType.xlWorksheet);
                Excel.Worksheet ws = (Excel.Worksheet)xla.ActiveSheet;
                Excel.Range concepto;
                Excel.Range clave;
                Excel.Range titulo;
                Excel.Range unidad;
                Excel.Range pu;
                //subtitulos
                Excel.Range con;
                Excel.Range cl;
                Excel.Range u;
                Excel.Range p_u;
                Excel.Range tCon; //titulo de la tabla
                Excel.Range Ren;  //para modificar el ancho del rendimiento
                //ws.Name = "Prueba";
                Excel.Range desc;
                Excel.Range ssv; //para sueldo semanal vigente
                Excel.Range saltotal; //para salario total

                #region "TITULO"
                //celdas combinadas para el titulo
                ws.get_Range("A1", "F1").Merge(false);
                titulo = ws.get_Range("A1", "F1");
                titulo.FormulaR1C1 = "ANÁLISIS DE PRECIOS UNITARIOS";
                titulo.HorizontalAlignment = 3;
                titulo.VerticalAlignment = 3;
                titulo.Font.Bold = true;
                titulo.Font.Size = 20;
                #endregion

                #region "CLAVE, CONCEPTO, UNIDAD, PU DATOS"
                ws.get_Range("A3", "A4").Merge(false);
                clave = ws.get_Range("A3", "A4");
                clave.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                clave.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                clave.Font.Size = 18;
                clave.Font.Bold = true;
                clave.ColumnWidth = 15;
                clave.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

                //celdas combinadas para el concepto
                ws.get_Range("B3", "D4").Merge(false);
                concepto = ws.get_Range("B3", "D4");
                concepto.HorizontalAlignment = 2;
                concepto.VerticalAlignment = 1;
                concepto.Font.Size = 14;
                concepto.Font.Bold = true;
                //concepto = ws.get_Range("B3", "E4");
                concepto.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                
                //celdas combinadas para la unidad
                ws.get_Range("E3", "E4").Merge(false);
                unidad = ws.get_Range("E3", "E4");
                unidad.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                unidad.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                unidad.Font.Bold = true;
                unidad.Font.Size = 18;
                unidad.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

                //celdas combinadas para el PU
                ws.get_Range("F3", "F4").Merge(false);
                pu = ws.get_Range("F3", "F4");
                pu.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                pu.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                pu.Font.Bold = true;
                pu.Font.Size = 18;
                pu.ColumnWidth = 20;
                pu.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

                #endregion

                //Titulos
                ws.Cells[2, 1] = "Clave";
                ws.Cells[2, 2] = "Concepto";
                ws.Cells[2, 5] = "Unidad";
                ws.Cells[2, 6] = "P. U.";

                #region "CLAVE, CONCEPTO, UNIDAD, PU BORDES"
                //bordes
                con = ws.get_Range("A2", "A2");
                con.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, 
                    Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                cl = ws.get_Range("B2", "D2");
                cl.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, 
                    Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                u = ws.get_Range("E2", "E2");
                u.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, 
                    Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                p_u = ws.get_Range("F2", "F2");
                p_u.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, 
                    Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                #endregion

                if (txtClave.Text == "" || txtConcepto.Text == "" || txtUnidad.Text == "")
                    MessageBox.Show("Debes llenar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    ws.Cells[3, 1] = txtClave.Text;
                    ws.Cells[3, 2] = txtConcepto.Text;
                    ws.Cells[3, 5] = txtUnidad.Text;
                    ws.Cells[3, 6] = "$" + txtPU.Text;

                    ws.get_Range("B7", "B7").Merge(false);
                    tCon = ws.get_Range("B7", "B7");
                    tCon.HorizontalAlignment = 1;
                    tCon.VerticalAlignment = 3;

                    //ancho de la columna rendimiento de materiales
                    ws.get_Range("E7", "E7").Merge(true);
                    Ren = ws.get_Range("E7", "E7");
                    Ren.Columns.ColumnWidth = 12;

                    //ancho de la columna para la descripcion
                    ws.get_Range("B7", "B7").Merge(true);
                    desc = ws.get_Range("B7", "B7");
                    desc.Columns.ColumnWidth = 25;

                    //ancho de la columna para unidad = sueldo semanal vigente 
                    ws.get_Range("C7", "C7").Merge(true);
                    ssv = ws.get_Range("C7", "C7");
                    ssv.Columns.ColumnWidth = 15;

                    //ancho de la columna para costo = salario total
                    ws.get_Range("D7", "D7").Merge(true);
                    saltotal = ws.get_Range("D7", "D7");
                    saltotal.Columns.ColumnWidth = 12;


                    c.CrearLibro(dGV_AgregarMAT, lbl_SumaImpMAT, dGV_AgregarMAN, lbl_SumaImpMAN, dGV_AgregarEQMAQ, lbl_SumaImpEQ, txtObservaciones, xla, ws,
                        IndCamptxt, IndOFtxt, Utilidadtxt, Finantxt, txtCostoDir, txtIndCam, txtIndOF, txtUtilidad, txtFinanciamiento, txtPrecioUnitario, txtUsuario);

                    ws.Name = txtClave.Text;
                    xla.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Debes ingresar un nombre para la hoja de cálculo", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Eventos y Métodos"
        private void VistaPrevia_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = usuario;
        }

        public void CostoDirecto()
        {
            costodirecto = Convert.ToDouble(lbl_SumaImpEQ.Text) + Convert.ToDouble(lbl_SumaImpMAN.Text) + Convert.ToDouble(lbl_SumaImpMAT.Text);
            txtCostoDir.Text = costodirecto.ToString("0.##");
        }

        private void costoDirectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CostoDirecto();
        }

        public void OtrosCostos()
        {
            try
            {
                txtIndCam.Text = ((Convert.ToDouble(txtCostoDir.Text) * Convert.ToDouble(IndCamptxt.Text)) / 100).ToString("0.##");
                txtIndOF.Text = ((Convert.ToDouble(txtCostoDir.Text) * Convert.ToDouble(IndOFtxt.Text)) / 100).ToString("0.##");
                txtUtilidad.Text = ((Convert.ToDouble(txtCostoDir.Text) * Convert.ToDouble(Utilidadtxt.Text)) / 100).ToString("0.##");
                txtFinanciamiento.Text = ((Convert.ToDouble(txtCostoDir.Text) * Convert.ToDouble(Finantxt.Text)) / 100).ToString("0.##");
                txtPrecioUnitario.Text = (Convert.ToDouble(txtCostoDir.Text) + Convert.ToDouble(txtIndCam.Text) + Convert.ToDouble(txtIndOF.Text)
                    + Convert.ToDouble(txtUtilidad.Text) + Convert.ToDouble(txtFinanciamiento.Text)).ToString("0.##");
                txtPU.Text = txtPrecioUnitario.Text;
            }
            catch
            {
                MessageBox.Show("Posiblemente faltan datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void otrosCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtrosCostos();
        }

        private void tls_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog1 = MessageBox.Show("¿Deseas sobreescribir los Datos Actuales?",
                    "Guardar Datos", MessageBoxButtons.YesNo);
                if (dialog1 == DialogResult.Yes)
                {
                    SumarMAT(dGVMateriales);
                    SumaMAN(dGVManodeObra);
                    SumaEQ(dGVEquipo);
                    CostoDirecto();
                    OtrosCostos();
                    //Materiales
                    //dGV_AgregarMAT.Visible = true;
                    //for (int i = 0; i < dGVMateriales.RowCount; i++)
                    //{
                    //    dGV_AgregarMAT.Rows.Add();
                    //    for (int j = 0; j < dGVMateriales.ColumnCount; j++)
                    //        dGV_AgregarMAT[j, i].Value = dGVMateriales[j, i].Value;
                    //}
                    ////Mano de obra
                    //dGV_AgregarMAN.Visible = true;          
                    //for (int i = 0; i < dGVManodeObra.RowCount; i++)
                    //{
                    //    dGV_AgregarMAN.Rows.Add();
                    //    for (int j = 0; j < dGVManodeObra.ColumnCount; j++)
                    //        dGV_AgregarMAN[j, i].Value = dGVManodeObra[j, i].Value;
                    //}
                    ////Equipo/Maquinaria
                    //dGV_AgregarEQMAQ.Visible = true;
                    //for (int i = 0; i < dGVEquipo.RowCount; i++)
                    //{
                    //    dGV_AgregarEQMAQ.Rows.Add();
                    //    for (int j = 0; j < dGVEquipo.ColumnCount; j++)
                    //        dGV_AgregarEQMAQ[j, i].Value = dGVEquipo[j, i].Value;
                    //}
                    Titulos();
                    if (dGVMateriales.RowCount >= 0)
                    {
                        Materiales(dGVMateriales);
                        SumarMAT(dGVMateriales);
                    }
                    if (dGVManodeObra.RowCount >= 0)
                    {
                        ManodeObra(dGVManodeObra);
                        SumaMAN(dGVManodeObra);
                    }
                    if (dGVEquipo.RowCount >= 0)
                    {
                        EqMaq(dGVEquipo);
                        SumaEQ(dGVEquipo);
                    }
                    Costos();
                    Porcentajes();
                    MessageBox.Show("Se han guardado los datos", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tSBGuardardesdeTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog1 = MessageBox.Show("¿Deseas sobreescribir los Datos Actuales?",
                "Guardar Datos", MessageBoxButtons.YesNo);
                //SE UTILIZARAN LOS DGV QUE NO ESTAN ENLAZADOS A LA BASE DE DATOS
                if (dialog1 == DialogResult.Yes)
                {

                    SumarMAT(dGV_AgregarMAT);
                    SumaMAN(dGV_AgregarMAN);
                    SumaEQ(dGV_AgregarEQMAQ);
                    CostoDirecto();
                    OtrosCostos();
                    Titulos();
                    if (dGV_AgregarMAT.RowCount >= 0)
                    {
                        dGV_AgregarMAT.Visible = true;
                        Materiales(dGV_AgregarMAT);
                        SumarMAT(dGV_AgregarMAT);
                    }
                    if (dGV_AgregarMAN.RowCount >= 0)
                    {
                        dGV_AgregarMAN.Visible = true;
                        ManodeObra(dGV_AgregarMAN);
                        SumaMAN(dGV_AgregarMAN);
                    }
                    if (dGV_AgregarEQMAQ.RowCount >= 0)
                    {
                        dGV_AgregarEQMAQ.Visible = true;
                        EqMaq(dGV_AgregarEQMAQ);
                        SumaEQ(dGV_AgregarEQMAQ);
                    }
                    Costos();
                    Porcentajes();
                    MessageBox.Show("Se han guardado los datos", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }          

        private void tsb_Agregar_Click(object sender, EventArgs e)
        {
            dGV_AgregarMAT.Visible = true;
            //dGV_AgregarMAT.Rows.Clear();
            if (dGV_AgregarMAT.RowCount > 0)
            {
                for (int i = 0; i < dGVMateriales.RowCount; i++)
                {
                    //dGV_AgregarMAT.Rows.Add();
                    for (int j = 0; j < dGVMateriales.ColumnCount; j++)
                        dGV_AgregarMAT[j, i].Value = dGVMateriales[j, i].Value;
                }
            }
            dGV_AgregarMAN.Visible = true;
            //dGV_AgregarMAN.Rows.Clear();
            if (dGV_AgregarMAN.RowCount > 0)
            {
                for (int i = 0; i < dGVManodeObra.RowCount; i++)
                {
                    //dGV_AgregarMAN.Rows.Add();
                    for (int j = 0; j < dGVManodeObra.ColumnCount; j++)
                        dGV_AgregarMAN[j, i].Value = dGVManodeObra[j, i].Value;
                }
            }
            dGV_AgregarEQMAQ.Visible = true;
            //dGV_AgregarEQMAQ.Rows.Clear();
            if (dGV_AgregarEQMAQ.RowCount > 0)
            {
                for (int i = 0; i < dGVEquipo.RowCount; i++)
                {
                    //dGV_AgregarEQMAQ.Rows.Add();
                    for (int j = 0; j < dGVEquipo.ColumnCount; j++)
                        dGV_AgregarEQMAQ[j, i].Value = dGVEquipo[j, i].Value;
                }
            }
            APU09Arquitectura.Agregar agregar = new APU09Arquitectura.Agregar();
            agregar.Show(this);
        }

        public void llenarComboAgregarVP(string db)
        {
            try
            {
                int rows = dGVMateriales.RowCount;
                int i = 0;

                query = "SELECT * FROM " + db + ";";
                conexionBD = new MySqlConnection(constring);
                cmd = new MySqlCommand(query, conexionBD);
                conexionBD.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString("Codigo");

                    //cb_Agregar.Items.Add(sName);
                    i++;
                }
                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Error 00002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
               
        #region "ActualizarconF5"
        public void ActualizarconF5(KeyEventArgs e, DataGridView dGVMateriales,
            DataGridView dGVManodeObra, DataGridView dGVEquipo)
        {
            if (e.KeyCode == Keys.F5)
            {
                SumarMAT(dGVMateriales);
                SumaMAN(dGVManodeObra);
                SumaEQ(dGVEquipo);
                CostoDirecto();
                OtrosCostos();
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtConcepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtUnidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtPU_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void dGV_AgregarMAT_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void dGVMateriales_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void dGV_AgregarMAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void dGVManodeObra_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void dGVEquipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void dGV_AgregarEQMAQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtObservaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void IndCamptxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void IndOFtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void Utilidadtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void Finantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtCostoDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtIndCam_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtIndOF_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtUtilidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtFinanciamiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }

        private void txtPrecioUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (dGVMateriales.Visible == true && dGVManodeObra.Visible == true && dGVEquipo.Visible == true)
                ActualizarconF5(e, dGVMateriales, dGVManodeObra, dGVEquipo);
            else
                if (dGV_AgregarMAT.Visible == true && dGV_AgregarMAN.Visible == true && dGV_AgregarEQMAQ.Visible == true)
                    ActualizarconF5(e, dGV_AgregarMAT, dGV_AgregarMAN, dGV_AgregarEQMAQ);
        }
        
        #endregion                 
                                                    
        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog open = new OpenFileDialog();
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        string mysheet = open.FileName;
        //        var excelApp = new Excel.Application();
        //        excelApp.Visible = true;
        //        Excel.Workbooks books = excelApp.Workbooks;
        //        Excel.Workbook sheet = books.Open(mysheet);


        //    }
        //}

        //private void toolStripButton2_Click(object sender, EventArgs e)
        //{
        //    Excel.Application ExcelObj = new Excel.Application();
        //    Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(
        //    "C:\\Users\\ErikaDL\\Desktop\\Libro1.xlsx", 0, true, 5,
        //    "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false,
        //    0, true);

        //    Excel.Sheets sheets = theWorkbook.Worksheets;
        //    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
        //    ExcelObj.Visible = true;

        //    //dGV.DataSource = APU09Arquitectura.Funciones.selectExcel(@"C:\\Users\\ErikaDL\\Desktop\\Libro1.xlsx", "s",txtClave);

        //}
    }
}
