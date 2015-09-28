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
    public partial class Agregar : Form
    {
        #region "Variables y Constructor"
        string constring = "datasource = localhost; port = 3306; username = root; password = ";
        string query;
        MySqlConnection con;
        MySqlDataReader reader;
        MySqlCommand cmd;
        //MySqlDataAdapter datosAdapter;
        //MySqlCommandBuilder comandoSQL;
        APU09Maker.VistaPrevia vp = new APU09Maker.VistaPrevia("");
        //int count = 0, rowsBD = 0;
        //string clave;
        public Agregar()
        {
            InitializeComponent();
            llenarComboAgregarVP("listapu.materiales");
            if (cb_Agregar.Items.Count > 0)
                cb_Agregar.SelectedIndex = 0;
            else
            {
                MessageBox.Show("No hay registros para mostrar", "¡Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region "Métodos y Eventos"
        public void llenarComboAgregarVP(string db)
        {
            try
            {
                query = "SELECT * FROM " + db + ";";
                con = new MySqlConnection(constring);
                cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString("Codigo");
                    cb_Agregar.Items.Add(sName);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Error 00002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Change(string columnas, string bd, int rB)
        {
            query = "SELECT " + columnas + " FROM " + bd + " WHERE Codigo = '" + cb_Agregar.Text + "';";
            try
            {
                if (rB == 1)
                {
                    con = new MySqlConnection(constring);
                    cmd = new MySqlCommand(query, con);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string Codigo = reader.GetString("Codigo");
                        string Descripcion = reader.GetString("Descripcion");
                        string Unidad = reader.GetString("Unidad");
                        double Costo = reader.GetDouble("Costo");
                        double Rendimiento = reader.GetDouble("Rendimiento");
                        double Importe = reader.GetDouble("Importe");

                        txtCodigo.Text = Codigo;
                        txtDesc.Text = Descripcion;
                        txtUnidad.Text = Unidad;
                        txtCosto.Text = Costo.ToString("0.##");
                    }
                    con.Close();
                    lbl_Ocupacion.Visible = false;
                    lbl_Descripcion.Visible = true;
                    lbl_Sueldo.Visible = false;
                    lbl_Costo.Visible = true;
                    lbl_Salario.Visible = false;
                    lbl_CostoHr.Visible = false;
                }
                else
                    if (rB == 2)
                    {
                        con = new MySqlConnection(constring);
                        cmd = new MySqlCommand(query, con);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string Codigo = reader.GetString("Codigo");
                            string ocupacion = reader.GetString("Ocupacion");
                            double Sueldo = reader.GetDouble("SueldoSemVig");
                            double Salario = reader.GetDouble("SalarioTotal");
                            double Rendimiento = reader.GetDouble("Rendimiento");
                            double Importe = reader.GetDouble("Importe");

                            txtCodigo.Text = Codigo;
                            txtDesc.Text = ocupacion;
                            txtUnidad.Text = Sueldo.ToString("0.##");
                            txtCosto.Text = Salario.ToString("0.##");
                        }
                        con.Close();
                        lbl_Ocupacion.Visible = true;
                        lbl_Descripcion.Visible = false;
                        lbl_Sueldo.Visible = true;
                        lbl_Costo.Visible = false;
                        lbl_Salario.Visible = true;
                        lbl_CostoHr.Visible = false;
                    }
                    else
                        if (rB == 3)
                        {
                            con = new MySqlConnection(constring);
                            cmd = new MySqlCommand(query, con);
                            con.Open();
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                string Codigo = reader.GetString("Codigo");
                                string Descripcion = reader.GetString("Descripcion");
                                string Unidad = reader.GetString("Unidad");
                                double Costo = reader.GetDouble("CostoHr");
                                double Rendimiento = reader.GetDouble("Rendimiento");
                                double Importe = reader.GetDouble("Importe");

                                txtCodigo.Text = Codigo;
                                txtDesc.Text = Descripcion;
                                txtUnidad.Text = Unidad;
                                txtCosto.Text = Costo.ToString("0.##");
                            }
                            con.Close();
                            lbl_Ocupacion.Visible = false;
                            lbl_Descripcion.Visible = true;
                            lbl_Sueldo.Visible = false;
                            lbl_Costo.Visible = false;
                            lbl_Salario.Visible = false;
                            lbl_CostoHr.Visible = true;
                        }

            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_Materiales_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Materiales.Checked == true)
            {
                cb_Agregar.Items.Clear();
                llenarComboAgregarVP("listapu.materiales");
                cb_Agregar.SelectedIndex = 0;
                Change("Codigo, Descripcion, Unidad, Costo, Rendimiento, Importe", "listapu.vp_materiales", 1);
                btActualizar.Text = "Agregar Material";
            }
        }

        private void rB_EqMaq_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_EqMaq.Checked == true)
            {
                cb_Agregar.Items.Clear();
                llenarComboAgregarVP("listapu.equipo");
                cb_Agregar.SelectedIndex = 0;
                Change("Codigo, Descripcion, Unidad, CostoHr, Rendimiento, Importe", "listapu.vp_eqmaq", 3);
                btActualizar.Text = "Agregar Equipo/Maquinaria";
            }
        }

        private void rB_ManodeObra_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_ManodeObra.Checked == true)
            {
                cb_Agregar.Items.Clear();
                llenarComboAgregarVP("listapu.manodeobra");
                cb_Agregar.SelectedIndex = 0;
                Change("Codigo, Ocupacion, SueldoSemVig, SalarioTotal, Rendimiento, Importe", "listapu.vp_manodeobra", 2);
                btActualizar.Text = "Agregar Mano de Obra";
            }
        }

        private void cb_Agregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb_Materiales.Checked == true)
            {

                query = "SELECT Codigo, Descripcion, Unidad, Costo, Rendimiento, Importe FROM listapu.materiales WHERE Codigo = '" + cb_Agregar.Text + "';";
                con = new MySqlConnection(constring);
                cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string Codigo = reader.GetString("Codigo");
                    string Descripcion = reader.GetString("Descripcion");
                    string Unidad = reader.GetString("Unidad");
                    double Costo = reader.GetDouble("Costo");
                    double Rendimiento = reader.GetDouble("Rendimiento");
                    double Importe = reader.GetDouble("Importe");

                    txtCodigo.Text = Codigo;
                    txtDesc.Text = Descripcion;
                    txtUnidad.Text = Unidad;
                    txtCosto.Text = Costo.ToString("0.##");

                    lbl_Ocupacion.Visible = false;
                    lbl_Descripcion.Visible = true;
                    lbl_Sueldo.Visible = false;
                    lbl_Costo.Visible = true;
                    lbl_Salario.Visible = false;
                    lbl_CostoHr.Visible = false;
                }
                con.Close();
            }
            else
                if (rB_ManodeObra.Checked == true)
                {
                    query = "SELECT Codigo, Ocupacion, SueldoSemanalVigente, SalarioTotal, Rendimiento, Importe FROM listapu.manodeobra WHERE Codigo = '" + cb_Agregar.Text + "';";
                    con = new MySqlConnection(constring);
                    cmd = new MySqlCommand(query, con);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string Codigo = reader.GetString("Codigo");
                        string ocupacion = reader.GetString("Ocupacion");
                        double Sueldo = reader.GetDouble("SueldoSemanalVigente");
                        double Salario = reader.GetDouble("SalarioTotal");
                        double Rendimiento = reader.GetDouble("Rendimiento");
                        double Importe = reader.GetDouble("Importe");

                        txtCodigo.Text = Codigo;
                        txtDesc.Text = ocupacion;
                        txtUnidad.Text = Sueldo.ToString("0.##");
                        txtCosto.Text = Salario.ToString("0.##");
                    }
                    con.Close();
                    lbl_Ocupacion.Visible = true;
                    lbl_Descripcion.Visible = false;
                    lbl_Sueldo.Visible = true;
                    lbl_Costo.Visible = false;
                    lbl_Salario.Visible = true;
                    lbl_CostoHr.Visible = false;
                }
                else
                    if (rB_EqMaq.Checked == true)
                    {
                        query = "SELECT Codigo, Descripcion, Unidad, CostoHr, Rendimiento, Importe FROM listapu.equipo WHERE Codigo = '" + cb_Agregar.Text + "';";
                        con = new MySqlConnection(constring);
                        cmd = new MySqlCommand(query, con);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string Codigo = reader.GetString("Codigo");
                            string Descripcion = reader.GetString("Descripcion");
                            string Unidad = reader.GetString("Unidad");
                            double Costo = reader.GetDouble("CostoHr");
                            double Rendimiento = reader.GetDouble("Rendimiento");
                            double Importe = reader.GetDouble("Importe");

                            txtCodigo.Text = Codigo;
                            txtDesc.Text = Descripcion;
                            txtUnidad.Text = Unidad;
                            txtCosto.Text = Costo.ToString("0.##");
                        }
                        con.Close();
                        lbl_Ocupacion.Visible = false;
                        lbl_Descripcion.Visible = true;
                        lbl_Sueldo.Visible = false;
                        lbl_Costo.Visible = false;
                        lbl_Salario.Visible = false;
                        lbl_CostoHr.Visible = true;
                    }
        }
        #endregion

        #region "Método para agregar a la Vista previa"
        private void btActualizar_Click(object sender, EventArgs e)
        {
            APU09Arquitectura.IAgregar agregar = this.Owner as APU09Arquitectura.IAgregar;           
            if (rb_Materiales.Checked == true)
            {
                if (agregar != null)
                {
                    vp.dGV_AgregarMAT.Rows.Add();
                    agregar.AgregarMAT(txtCodigo.Text, txtDesc.Text, txtUnidad.Text, Convert.ToDouble(txtCosto.Text));
                }
            }
            else
                if (rB_ManodeObra.Checked == true)
                {
                    if (agregar != null)
                    {
                        vp.dGV_AgregarMAN.Rows.Add();
                        agregar.AgregarMAN(txtCodigo.Text, txtDesc.Text, txtUnidad.Text, Convert.ToDouble(txtCosto.Text));
                    }
                }
                else
                    if (rB_EqMaq.Checked == true)
                    {
                        vp.dGV_AgregarEQMAQ.Rows.Add();
                        agregar.AgregarEQMAQ(txtCodigo.Text, txtDesc.Text, txtUnidad.Text, Convert.ToDouble(txtCosto.Text));
                    }
        }
        #endregion
    }
}
