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
    public partial class AgregarMano : Form
    {
        conexion c = new conexion();
        APU09Arquitectura.Funciones f = new APU09Arquitectura.Funciones();
        #region Variables

        string _fecha;
        double _smv, _prt, _fdiasinh, _cuotafija, _excedentep, _excedenteo, _prestacionp, _prestaciono,
            _gastmedp, _gastmedo, _invyvidap, _invyvidao, _guaryprest, _retiro, _vejezp, _vejezo,
            _infonavit, _aguinaldo, _primavacacional, _factzona, _impsnomina, _facteqseg, _factherr;
        string codigo, ocupacion;
        double SueldoSemanalVigente, SalarioDiarioVigente, FactorDemanda, SalarioBase, Aguinaldo, PrimaVacacional,
            SumaParcial, SalarioDiarioIntegrado, CuotaFija, ExcedentesP, ExcedentesO, PrestacionP, PrestacionO, IMSS, GastosMedP,
            GastosMedO, RiesgodeTrabajo, InvyVidaP, InvyVidao, Guarderia, Retiro, VejezP, VejezO, InfonavitSSDI, Infonavit,
                        ImpSobreNomina, SalarioDiarioTotal, FactorZona, FactorEqSeg, FactorHerM, SalarioTotal;
        #endregion

        public AgregarMano()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "")
                MessageBox.Show("No has proporcinado alguno de los datos obligatorios", "Ocurrió un error",
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

                    string myConnectionString = "Database=listapu;Data Source=localhost;User Id=root;Password=";
                    MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                    string myInsertQuery =
                        "INSERT INTO manodeobra (Codigo, Ocupacion, SueldoSemanalVigente, SalarioDiarioVigente, FACTORDEMANDA," +
                        "SALARIOBASE, AGUINALDO, PRIMAVACACIONAL, SUMAPARCIAL,SALARIODIARIOINTEGRADO, CUOTAFIJA, EXCEDENTESP, EXCEDENTESO," +
                        "PRESTACIONP, PRESTACIONO, GASTOSP, GASTOSO, RIESGOTRABAJO, INVYVIDAP, INVYVIDAO, GUARDERIA, IMSS, RETIRO," +
                        "VEJEZP,VEJEZO, INFONAVITSSDI, INFONAVIT, IMPSOBRENOMINASSDI, SALARIODIARIOTOTAL, FACTORDEZONA," +
                        "FACTOREQDESEG, FACTORHERRAM, SALARIOTOTAL, RENDIMIENTO, IMPORTE) " +
                        "Values (?codigo, ?ocupacion, ?sueldosemanalvigente, ?salariodiariovigente, ?factordemanda," +
                        "?salariobase, ?aguinaldo, ?primavacacional, ?sumaparcial, ?salariodiariointegrado, ?cuotafija, ?excedentesP, ?excedentesO," +
                        "?prestacionP, ?prestacionO, ?gastosP, ?gastosO, ?riesgotrabajo, ?invyvidaP, ?invyvidaO, ?guarderia, ?imss, ?retiro," +
                        "?vejezP, ?vejezO, ?infonavitssdi, ?infonavit, ?impsobrenominassdi, ?salariodiariototal, ?factordezona," +
                        "?factoreqdeseg, ?factorherram, ?salariototal, ?rendimiento, ?importe)";

                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    label25.Text = "Salario Minímo Vigente: " + _smv.ToString("0.##");
                    label10.Text = "Prima de Riesgo de Trabajo: " + _prt.ToString("0.##");

                    codigo = txt1.Text;
                    myCommand.Parameters.Add("?codigo", MySqlDbType.VarChar, 10).Value = codigo;

                    ocupacion = txt2.Text;
                    myCommand.Parameters.Add("?ocupacion", MySqlDbType.VarChar, 100).Value = ocupacion;
                    SueldoSemanalVigente = Math.Round(Convert.ToDouble(txt3.Text), 2);
                    /*double salariosminimos3 = _smv * 3;
                    if (SueldoSemanalVigente > salariosminimos3)
                        MessageBox.Show("El sueldo es mayor a 3 salarios mínimos, \r\n por favor ingresa el valor del excedente", "Aviso");
                    else*/
                    myCommand.Parameters.Add("?sueldosemanalvigente", MySqlDbType.Double, 10).Value = SueldoSemanalVigente;

                    SalarioDiarioVigente = Math.Round(SueldoSemanalVigente / 7, 2);
                    txt4.Text = SalarioDiarioVigente.ToString();
                    myCommand.Parameters.Add("?salariodiariovigente", MySqlDbType.Double, 10).Value = SalarioDiarioVigente;

                    FactorDemanda = Math.Round(SalarioDiarioVigente / _smv, 2);
                    myCommand.Parameters.Add("?factordemanda", MySqlDbType.Double, 10).Value = FactorDemanda;

                    SalarioBase = Math.Round(_smv * FactorDemanda);
                    myCommand.Parameters.Add("?salariobase", MySqlDbType.Double, 10).Value = SalarioBase;

                    Aguinaldo = Math.Round(SalarioBase * (_aguinaldo / 100), 2);
                    myCommand.Parameters.Add("?aguinaldo", MySqlDbType.Double, 10).Value = Aguinaldo;

                    PrimaVacacional = Math.Round(SalarioBase * (_primavacacional / 100), 2);
                    myCommand.Parameters.Add("?primavacacional", MySqlDbType.Double, 10).Value = PrimaVacacional;

                    SumaParcial = Math.Round(SalarioBase + Aguinaldo + PrimaVacacional, 2);
                    myCommand.Parameters.Add("?sumaparcial", MySqlDbType.Double, 10).Value = SumaParcial;

                    SalarioDiarioIntegrado = Math.Round(SumaParcial * _fdiasinh, 2);
                    txt7.Text = SalarioDiarioIntegrado.ToString("0.##");
                    myCommand.Parameters.Add("?salariodiariointegrado", MySqlDbType.Double, 10).Value = SalarioDiarioIntegrado;

                    CuotaFija = Math.Round(_smv * (_cuotafija / 100), 2);
                    myCommand.Parameters.Add("?cuotafija", MySqlDbType.Double, 10).Value = CuotaFija;

                    ExcedentesP = Math.Round(SalarioDiarioIntegrado * (_excedentep / 100), 2);
                    myCommand.Parameters.Add("?excedentesP", MySqlDbType.Double, 10).Value = ExcedentesP;

                    ExcedentesO = Math.Round(SalarioDiarioIntegrado * (_excedenteo / 100), 2);
                    myCommand.Parameters.Add("?excedentesO", MySqlDbType.Double, 10).Value = ExcedentesO;

                    PrestacionP = Math.Round(SalarioDiarioIntegrado * (_prestacionp / 100), 2);
                    myCommand.Parameters.Add("?prestacionP", MySqlDbType.Double, 10).Value = PrestacionP;

                    PrestacionO = Math.Round(SalarioDiarioIntegrado * (_prestaciono / 100), 2);
                    myCommand.Parameters.Add("?prestacionO", MySqlDbType.Double, 10).Value = PrestacionO;

                    GastosMedP = Math.Round(SalarioDiarioIntegrado * (_gastmedp / 100), 2);
                    myCommand.Parameters.Add("?gastosP", MySqlDbType.Double, 10).Value = GastosMedP;

                    GastosMedO = Math.Round(SalarioDiarioIntegrado * (_gastmedo / 100), 2);
                    myCommand.Parameters.Add("?gastosO", MySqlDbType.Double, 10).Value = GastosMedO;

                    RiesgodeTrabajo = Math.Round(SalarioDiarioIntegrado * (_prt / 100), 2);
                    myCommand.Parameters.Add("?riesgotrabajo", MySqlDbType.Double, 10).Value = RiesgodeTrabajo;

                    InvyVidaP = Math.Round(SalarioDiarioIntegrado * (_invyvidap / 100), 2);
                    myCommand.Parameters.Add("?invyvidaP", MySqlDbType.Double, 10).Value = InvyVidaP;

                    InvyVidao = Math.Round(SalarioDiarioIntegrado * (_invyvidao / 100), 2);
                    myCommand.Parameters.Add("?invyvidaO", MySqlDbType.Double, 10).Value = InvyVidao;

                    Guarderia = Math.Round(SalarioDiarioIntegrado * (_guaryprest / 100), 2);
                    myCommand.Parameters.Add("?guarderia", MySqlDbType.Double, 10).Value = Guarderia;

                    IMSS = Math.Round(CuotaFija + ExcedentesP + ExcedentesO + PrestacionP + PrestacionO +
                        GastosMedP + GastosMedO + RiesgodeTrabajo + InvyVidaP + InvyVidao + Guarderia, 2);
                    txt5.Text = IMSS.ToString();
                    myCommand.Parameters.Add("?imss", MySqlDbType.Double, 10).Value = IMSS;

                    //
                    Retiro = Math.Round(SalarioDiarioIntegrado * (_retiro / 100), 2);
                    myCommand.Parameters.Add("?retiro", MySqlDbType.Double, 10).Value = Retiro;

                    VejezP = Math.Round(SalarioDiarioIntegrado * (_vejezp / 100), 2);
                    myCommand.Parameters.Add("?vejezP", MySqlDbType.Double, 10).Value = VejezP;

                    VejezO = Math.Round(SalarioDiarioIntegrado * (_vejezo / 100), 2);
                    myCommand.Parameters.Add("?vejezO", MySqlDbType.Double, 10).Value = VejezO;

                    InfonavitSSDI = Math.Round(SalarioDiarioIntegrado * (_infonavit / 100), 2);
                    myCommand.Parameters.Add("?infonavitssdi", MySqlDbType.Double, 10).Value = InfonavitSSDI;

                    Infonavit = Math.Round(Retiro + VejezP + VejezO + InfonavitSSDI, 2);
                    txt6.Text = Infonavit.ToString();
                    myCommand.Parameters.Add("?infonavit", MySqlDbType.Double, 10).Value = Infonavit;

                    ImpSobreNomina = Math.Round(SalarioDiarioIntegrado * (_impsnomina / 100), 2);
                    myCommand.Parameters.Add("?impsobrenominassdi", MySqlDbType.Double, 10).Value = ImpSobreNomina;

                    SalarioDiarioTotal = Math.Round(SalarioDiarioIntegrado + IMSS + Infonavit + ImpSobreNomina, 2);
                    txt8.Text = SalarioDiarioTotal.ToString();
                    myCommand.Parameters.Add("?salariodiariototal", MySqlDbType.Double, 10).Value = SalarioDiarioTotal;

                    FactorZona = Math.Round(SalarioDiarioTotal * (_factzona / 100), 2);
                    myCommand.Parameters.Add("?factordezona", MySqlDbType.Double, 10).Value = FactorZona;

                    FactorEqSeg = Math.Round(SalarioDiarioTotal * (_facteqseg / 100), 2);
                    myCommand.Parameters.Add("?factoreqdeseg", MySqlDbType.Double, 10).Value = FactorEqSeg;

                    FactorHerM = Math.Round(SalarioDiarioTotal * (_factherr / 100), 2);
                    myCommand.Parameters.Add("?factorherram", MySqlDbType.Double, 10).Value = FactorHerM;

                    SalarioTotal = Math.Round(SalarioDiarioTotal + FactorZona + FactorEqSeg + FactorHerM, 2);
                    txt9.Text = SalarioTotal.ToString();
                    myCommand.Parameters.Add("?salariototal", MySqlDbType.Double, 10).Value = SalarioTotal;

                    myCommand.Parameters.Add("?rendimiento", MySqlDbType.Double, 10).Value = 0;
                    myCommand.Parameters.Add("?importe", MySqlDbType.Double, 10).Value = 0;

                    myCommand.Connection = myConnection;
                    myConnection.Open();

                    DialogResult dialog = MessageBox.Show("¿Deseas agregar al Personal?", "Agregar Personal",
                        MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha agregado la persona con el código: " + txt1.Text, "Personal agregado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    DialogResult dialog1 = MessageBox.Show("¿Deseas agregar a otra persona?", "Agregar Personal",
                        MessageBoxButtons.YesNo);
                    if (dialog1 == DialogResult.No)
                    {
                        this.Close();
                        myCommand.Connection.Close();
                      
                        Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AnPrUn);
                        if(frm!=null)
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
                    else
                        if (dialog1 == DialogResult.Yes)
                        {
                            txt1.Clear();
                            txt2.Clear();
                            txt3.Clear();
                            txt4.Clear();
                            txt5.Clear();
                            txt6.Clear();
                            txt7.Clear();
                            txt8.Clear();
                            txt9.Clear();
                        }
                }
                catch
                {
                    MessageBox.Show("Ocurrió un error al ingresar algún dato", "Error 00002",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt3);
        }
    }
}
