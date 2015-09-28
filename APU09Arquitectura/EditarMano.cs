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
using System;

namespace APU09Maker
{
    public partial class EditarMano : Form
    {
        conexion c = new conexion();
        string _fecha;
        double _smv, _prt, _fdiasinh, _cuotafija, _excedentep, _excedenteo, _prestacionp, _prestaciono,
            _gastmedp, _gastmedo, _invyvidap, _invyvidao, _guaryprest, _retiro, _vejezp, _vejezo,
            _infonavit, _aguinaldo, _primavacacional, _factzona, _impsnomina, _facteqseg, _factherr;
        string codigo, ocupacion;
        double SueldoSemanalVigente, SalarioDiarioVigente, FactorDemanda, SalarioBase, Aguinaldo, PrimaVacacional,
            SumaParcial, SalarioDiarioIntegrado, CuotaFija, ExcedentesP, ExcedentesO, PrestacionP, PrestacionO, IMSS, GastosMedP,
            GastosMedO, RiesgodeTrabajo, InvyVidaP, InvyVidao, Guarderia, Retiro, VejezP, VejezO, InfonavitSSDI, Infonavit,
                        ImpSobreNomina, SalarioDiarioTotal, FactorZona, FactorEqSeg, FactorHerM, SalarioTotal, Rendimiento = 0, Importe = 0;
        public EditarMano()
        {
            InitializeComponent();
            c.llenarCombo(cbActualizar, "listapu.manodeobra");
            if (cbActualizar.Items.Count > 0)
                cbActualizar.SelectedIndex = 0;
            else
                MessageBox.Show("No hay registros para actualizar", "¡Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt3.Text == "")
                MessageBox.Show("Debes proporcionar el SUELDO SEMANAL VIGENTE", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string constring = "datasource = localhost; port = 3306; username = root; password = ";
                string query = "select * from listapu.datosprincipales where CODIGO = '1';";
                MySqlConnection con = new MySqlConnection(constring);
                MySqlCommand cmdPorcentajes = new MySqlCommand(query, con);
                MySqlDataReader reader;

                try
                {
                    con.Open();
                    reader = cmdPorcentajes.ExecuteReader();

                    while (reader.Read())
                    {
                        _fecha = reader.GetString("fecha");
                        _smv = reader.GetDouble("SMV");
                        _prt = reader.GetDouble("PRT");
                        _fdiasinh = reader.GetDouble("FDIASINH");
                        _cuotafija = reader.GetDouble("CUOTAFIJA");
                        _excedentep = reader.GetDouble("EXCEDENTEP");
                        _excedenteo = reader.GetDouble("EXCEDENTEO");
                        _prestacionp = reader.GetDouble("PRESTACIONP");
                        _prestaciono = reader.GetDouble("PRESTACIONO");
                        _gastmedp = reader.GetDouble("GASTMEDP");
                        _gastmedo = reader.GetDouble("GASTMEDO");
                        _invyvidap = reader.GetDouble("INVYVIDAP");
                        _invyvidao = reader.GetDouble("INVYVIDAO");
                        _guaryprest = reader.GetDouble("GUARYPREST");
                        _retiro = reader.GetDouble("RETIRO");
                        _vejezp = reader.GetDouble("VEJEZP");
                        _vejezo = reader.GetDouble("VEJEZO");
                        _infonavit = reader.GetDouble("INFONAVIT");
                        _aguinaldo = reader.GetDouble("AGUINALDO");
                        _primavacacional = reader.GetDouble("PRIMAVACACIONAL");
                        _factzona = reader.GetDouble("FACTZONA");
                        _impsnomina = reader.GetDouble("IMPSNOMINA");
                        _facteqseg = reader.GetDouble("FACTEQSEG");
                        _factherr = reader.GetDouble("FACTHERR");
                    }
                    con.Close();
                    //


                    label1.Text = "Salario Mínimo Vigente: " + _smv.ToString("0.##");
                    label10.Text = "Prima de Riesgo de Trabajo: " + _prt.ToString("0.##");

                    codigo = txt1.Text;

                    ocupacion = txt2.Text;

                    SueldoSemanalVigente = Math.Round(Convert.ToDouble(txt3.Text), 2);

                    SalarioDiarioVigente = Math.Round(SueldoSemanalVigente / 7, 2);
                    txt4.Text = SalarioDiarioVigente.ToString();

                    FactorDemanda = Math.Round(SalarioDiarioVigente / _smv, 2);

                    SalarioBase = Math.Round(_smv * FactorDemanda);

                    Aguinaldo = Math.Round(SalarioBase * (_aguinaldo / 100), 2);

                    PrimaVacacional = Math.Round(SalarioBase * (_primavacacional / 100), 2);

                    SumaParcial = Math.Round(SalarioBase + Aguinaldo + PrimaVacacional, 2);

                    SalarioDiarioIntegrado = Math.Round(SumaParcial * _fdiasinh, 2);
                    txt7.Text = SalarioDiarioIntegrado.ToString("0.##");

                    CuotaFija = Math.Round(_smv * (_cuotafija / 100), 2);

                    ExcedentesP = Math.Round(SalarioDiarioIntegrado * (_excedentep / 100), 2);

                    ExcedentesO = Math.Round(SalarioDiarioIntegrado * (_excedenteo / 100), 2);

                    PrestacionP = Math.Round(SalarioDiarioIntegrado * (_prestacionp / 100), 2);

                    PrestacionO = Math.Round(SalarioDiarioIntegrado * (_prestaciono / 100), 2);

                    GastosMedP = Math.Round(SalarioDiarioIntegrado * (_gastmedp / 100), 2);

                    GastosMedO = Math.Round(SalarioDiarioIntegrado * (_gastmedo / 100), 2);

                    RiesgodeTrabajo = Math.Round(SalarioDiarioIntegrado * (_prt / 100), 2);

                    InvyVidaP = Math.Round(SalarioDiarioIntegrado * (_invyvidap / 100), 2);

                    InvyVidao = Math.Round(SalarioDiarioIntegrado * (_invyvidao / 100), 2);

                    Guarderia = Math.Round(SalarioDiarioIntegrado * (_guaryprest / 100), 2);

                    IMSS = Math.Round(CuotaFija + ExcedentesP + ExcedentesO + PrestacionP + PrestacionO +
                        GastosMedP + GastosMedO + RiesgodeTrabajo + InvyVidaP + InvyVidao + Guarderia, 2);
                    txt5.Text = IMSS.ToString();

                    Retiro = Math.Round(SalarioDiarioIntegrado * (_retiro / 100), 2);

                    VejezP = Math.Round(SalarioDiarioIntegrado * (_vejezp / 100), 2);

                    VejezO = Math.Round(SalarioDiarioIntegrado * (_vejezo / 100), 2);

                    InfonavitSSDI = Math.Round(SalarioDiarioIntegrado * (_infonavit / 100), 2);

                    Infonavit = Math.Round(Retiro + VejezP + VejezO + InfonavitSSDI, 2);
                    txt6.Text = Infonavit.ToString();

                    ImpSobreNomina = Math.Round(SalarioDiarioIntegrado * (_impsnomina / 100), 2);

                    SalarioDiarioTotal = Math.Round(SalarioDiarioIntegrado + IMSS + Infonavit + ImpSobreNomina, 2);
                    txt8.Text = SalarioDiarioTotal.ToString();

                    FactorZona = Math.Round(SalarioDiarioTotal * (_factzona / 100), 2);

                    FactorEqSeg = Math.Round(SalarioDiarioTotal * (_facteqseg / 100), 2);

                    FactorHerM = Math.Round(SalarioDiarioTotal * (_factherr / 100), 2);

                    SalarioTotal = Math.Round(SalarioDiarioTotal + FactorZona + FactorEqSeg + FactorHerM, 2);
                    txt9.Text = SalarioTotal.ToString();

                    string myConnectionString = "datasource = localhost; port = 3306; username = root; password = ";
                    string myInsertQuery = "update listapu.manodeobra set CODIGO = '" + codigo + "', OCUPACION = '" + ocupacion +
                        "', SUELDOSEMANALVIGENTE= '" + SueldoSemanalVigente + "', SALARIODIARIOVIGENTE= '" + SalarioDiarioVigente +
                        "', FACTORDEMANDA = '" + FactorDemanda + "', SALARIOBASE = '" + SalarioBase + "', AGUINALDO = '" + Aguinaldo +
                        "', PRIMAVACACIONAL = '" + PrimaVacacional + "', SUMAPARCIAL = '" + SumaParcial + "', SALARIODIARIOINTEGRADO = '" +
                        SalarioDiarioIntegrado + "', CUOTAFIJA = '" + CuotaFija + "', EXCEDENTESP = '" + ExcedentesP + "', EXCEDENTESO = '" +
                        ExcedentesO + "', PRESTACIONP = '" + PrestacionP + "', PRESTACIONO = '" + PrestacionO + "', GASTOSP = '" + GastosMedP +
                        "', GASTOSO = '" + GastosMedO + "', RIESGOTRABAJO = '" + RiesgodeTrabajo + "', INVYVIDAP = '" + InvyVidaP + "', INVYVIDAO = '" +
                        InvyVidao + "', GUARDERIA = '" + Guarderia + "', IMSS = '" + IMSS + "', RETIRO = '" + Retiro + "', VEJEZP = '" + VejezP +
                        "', VEJEZO = '" + VejezO + "', INFONAVITSSDI = '" + InfonavitSSDI + "', INFONAVIT = '" + Infonavit + "', IMPSOBRENOMINASSDI = '" +
                        ImpSobreNomina + "', SALARIODIARIOTOTAL = '" + SalarioDiarioTotal + "', FACTORDEZONA = '" + FactorZona + "', FACTOREQDESEG = '" +
                        FactorEqSeg + "', FACTORHERRAM = '" + FactorHerM + "', SALARIOTOTAL = '" + SalarioTotal + "', RENDIMIENTO = '" + Rendimiento
                        + "', IMPORTE = '" + Importe + "' WHERE CODIGO = '" + txt1.Text + "';";

                    string queryVistaPrevia = "update listapu.vp_manodeobra set Ocupacion = '" + ocupacion +
                        "', SueldoSemVig = '" + SueldoSemanalVigente + "', SalarioTotal = '" + SalarioTotal + "', Rendimiento = '" + Rendimiento
                        + "', Importe = '" + Importe + "' WHERE Codigo = '" + txt1.Text + "';";

                    MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                    MySqlConnection myConnection1 = new MySqlConnection(myConnectionString);
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    MySqlCommand myCommand1 = new MySqlCommand(queryVistaPrevia);
                    MySqlDataReader readerAct;
                    MySqlDataReader readerAct1;


                    myConnection.Open();
                    myConnection1.Open();
                    DialogResult dialog = MessageBox.Show("¿Realmente deseas editar al personal?", "Editar personal",
                        MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        myCommand.Connection = myConnection;
                        myCommand1.Connection = myConnection1;
                        readerAct = myCommand.ExecuteReader();
                        readerAct1 = myCommand1.ExecuteReader();
                        MessageBox.Show("Se ha actualizado el empleado con el Código: " + txt1.Text,
                            "Personal actualizado", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    DialogResult dialog1 = MessageBox.Show("¿Deseas editar otra persona?",
                "Editar Personal", MessageBoxButtons.YesNo);
                    if (dialog1 == DialogResult.No)
                    {
                        this.Close();
                        con.Close();
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
                catch
                {
                    MessageBox.Show("Ocurrió un error al ingresar algún dato", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "select * from listapu.manodeobra where Codigo = '" + cbActualizar.Text + "';";
            //CODIGO, OCUPACION, SUELDOSEMANALVIGENTE, SALARIODIARIOVIGENTE, SALARIODIARIOINTEGRADO, IMSS, INFONAVIT, SALARIODIARIOTOTAL, SALARIOTOTAL
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
                    double sueldosemanalvigente = reader.GetDouble("SueldoSemanalVigente");
                    double salariodiariovigente = reader.GetDouble("SalarioDiarioVigente");
                    double salariodiariointegrado = reader.GetDouble("SalarioDiarioIntegrado");
                    double imss = reader.GetDouble("IMSS");
                    double infonavit = reader.GetDouble("Infonavit");
                    double salariodiariototal = reader.GetDouble("SalarioDiarioTotal");
                    double salariototal = reader.GetDouble("SalarioTotal");

                    txt1.Text = codigo;
                    txt2.Text = ocupacion;
                    txt3.Text = sueldosemanalvigente.ToString("0.##");
                    txt4.Text = salariodiariovigente.ToString("0.##");
                    txt5.Text = salariodiariointegrado.ToString("0.##");
                    txt6.Text = imss.ToString("0.##");
                    txt7.Text = infonavit.ToString("0.##");
                    txt8.Text = salariodiariototal.ToString("0.##");
                    txt9.Text = salariototal.ToString("0.##");
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
