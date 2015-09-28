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
    class conexion
    {
        #region ""
        MySqlConnection conexionBD;

        public void ActualizarDatosPpales(DateTimePicker dt, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5,
         TextBox txt6, TextBox txt7, TextBox txt8, TextBox txt9, TextBox txt10, TextBox txt11, TextBox txt12,
         TextBox txt13, TextBox txt14, TextBox txt15, TextBox txt16, TextBox txt17, TextBox txt18,
         TextBox txt19, TextBox txt20, TextBox txt21, TextBox txt22, TextBox txt23)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "update listapu.datosprincipales set fecha = '" + dt.Text + "', SMV = '" + txt1.Text +
                "', PRT = '" + txt2.Text + "', FDIASINH = '" + txt3.Text +
                "', CUOTAFIJA = '" + txt4.Text + "', EXCEDENTEP = '" + txt5.Text +
                "', EXCEDENTEO = '" + txt6.Text + "', PRESTACIONP = '" + txt7.Text +
                "', PRESTACIONO = '" + txt8.Text + "', GASTMEDP = '" + txt9.Text +
                "', GASTMEDO = '" + txt10.Text + "', INVYVIDAP = '" + txt11.Text +
                "', INVYVIDAO = '" + txt12.Text + "', GUARYPREST = '" + txt13.Text +
                "', RETIRO = '" + txt14.Text + "', VEJEZP = '" + txt15.Text +
                "', VEJEZO = '" + txt16.Text + "', INFONAVIT = '" + txt17.Text +
                "', AGUINALDO = '" + txt18.Text + "', PRIMAVACACIONAL = '" + txt19.Text +
                "', IMPSNOMINA = '" + txt20.Text + "', FACTZONA = '" + txt21.Text +
                  "', FACTEQSEG = '" + txt22.Text + "', FACTHERR = '" + txt23.Text +
                "' where CODIGO = '1';";
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                DialogResult dialog = MessageBox.Show("¿Realmente deseas actualizar estos datos?", "Actualizar",
                    MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Se han actualizado los datos correctamente", "Datos principales",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar un registro", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarMaterial(ComboBox cb, TextBox txtCodigo, TextBox txtDesc, TextBox txtUnidad, TextBox txtCosto)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "update listapu.materiales set Codigo =  '" + txtCodigo.Text +
                "', Descripcion = '" + txtDesc.Text + "', Unidad = '" + txtUnidad.Text + "', Costo = '" + txtCosto.Text + "' where Codigo = '" + txtCodigo.Text + "';";

            string query1 = "update listapu.vp_materiales set Codigo =  '" + txtCodigo.Text +
                "', Descripcion = '" + txtDesc.Text + "', Unidad = '" + txtUnidad.Text + "', Costo = '" + txtCosto.Text + "' where Codigo = '" + txtCodigo.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlConnection con1 = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlCommand cmd1 = new MySqlCommand(query1, con1);
            MySqlDataReader reader;
            MySqlDataReader reader1;
            try
            {
                con.Open();
                con1.Open();
                DialogResult dialog = MessageBox.Show("¿Realmente deseas actualizar este material?", "Actualizar", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    reader = cmd.ExecuteReader();
                    reader1 = cmd1.ExecuteReader();
                    MessageBox.Show("Se ha actualizado el material con el Código: " + txtCodigo.Text, "Material actualizado",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                con.Close();
                con1.Close();
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarEquipo(ComboBox cb, TextBox txtCodigo, TextBox txtDesc, TextBox txtUnidad, TextBox txtCosto, TextBox txtVida, TextBox txtCostohr)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "update listapu.equipo set CODIGO =  '" + txtCodigo.Text +
                "', DESCRIPCION = '" + txtDesc.Text + "', UNIDAD = '" + txtUnidad.Text +
                "', COSTO = '" + txtCosto.Text + "', VIDAUTIL = '" + txtVida.Text + "', COSTOHR = '" + txtCostohr.Text +
                "' where CODIGO = '" + txtCodigo.Text + "';";
            string query1 = "update listapu.vp_eqmaq set Codigo =  '" + txtCodigo.Text +
                "', Descripcion = '" + txtDesc.Text + "', Unidad = '" + txtUnidad.Text +
                "', CostoHr = '" + txtCostohr.Text +
                "' where Codigo = '" + txtCodigo.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlConnection con1 = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlCommand cmd1 = new MySqlCommand(query1, con1);
            MySqlDataReader reader;
            MySqlDataReader reader1;
            try
            {
                con.Open();
                con1.Open();
                DialogResult dialog = MessageBox.Show("¿Realmente deseas actualizar este Equipo/Maquinaria?", "Actualizar Equipo/Maquinaria",
                    MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    reader = cmd.ExecuteReader();
                    reader1 = cmd1.ExecuteReader();
                    MessageBox.Show("Se ha actualizado el Equipo/Maquinaria con el Código: " + txtCodigo.Text, "Equipo/Maquinaria actualizado",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                con.Close();
                con1.Close();
            }
            catch
            {
                MessageBox.Show("Error al actualizar un registro", "Ocurrió un error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Conectar()
        {
            if (conexionBD != null)
                conexionBD.Close();

            string connStr =
                String.Format("server={0};port={1};user id={2}; password={3}; " +
                "database=mysql; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                "localhost", "3306", "root", "");
            try
            {
                conexionBD = new MySqlConnection(connStr);
                conexionBD.Open();
                obtenerBasesDatosMySQL();
            }
            catch
            {
                MessageBox.Show("Error al conectar al servidor de MySQL", "Error 00002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CrearCuenta(TextBox txtNombre, TextBox txtApellidos, TextBox txtCorreo, TextBox txtUsuario, TextBox txtContrasena, ComboBox cb)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                    myConnectionString = "Database=listapu;Data Source=localhost;User Id=root;Password=";
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myInsertQuery = "INSERT INTO usuario (usuario, contraseña) Values(?usuario, ?contraseña)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Parameters.Add("?usuario", MySqlDbType.VarChar, 20).Value = txtUsuario.Text;
                myCommand.Parameters.Add("?contraseña", MySqlDbType.VarChar, 20).Value = txtContrasena.Text;
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Error al crear la cuenta, verifica los datos", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void CrearLibro(DataGridView dGVMaterial, Label txtSumImpMat, DataGridView dGVMano, Label txtSumImpMan,
            DataGridView dGVEquipo, Label txtSumImpEQ, TextBox txtObservaciones, Excel.Application xla, Excel.Worksheet ws,
            TextBox IndCamptxt, TextBox IndOFtxt, TextBox Utilidadtxt, TextBox Finantxt, TextBox txtCostoDir, TextBox txtIndCam,
            TextBox txtIndOF, TextBox txtUtilidad, TextBox txtFinanciamiento, TextBox txtPrecioUnitario, TextBox txtUsuario)
        {
            int rowsM = 0, rowsE = 0;
            try
            {
                ws = (Excel.Worksheet)xla.ActiveSheet;
                string[] letras = new string[8];
                letras[0] = "A";
                letras[1] = "B";
                letras[2] = "C";
                letras[3] = "D";
                letras[4] = "E";
                letras[5] = "F";
                letras[6] = "G";
                letras[7] = "H";
                
                
                ws.Cells[6, 1] = "Materiales";
                for (int i = 1; i < dGVMaterial.Columns.Count; i++)
                {
                    ws.Cells[7, letras[i - 1]] = dGVMaterial.Columns[i].HeaderText;
                    Excel.Range r;
                    string l = letras[i - 1].ToString();
                    r = ws.get_Range("A7", l + "7");
                    r.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                        Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                    r.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    r.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
                int fila = 7;
                for (int i = 0; i < dGVMaterial.Rows.Count; i++)
                {
                    fila++;
                    for (int j = 1; j < dGVMaterial.Columns.Count; j++)
                    {
                        ws.Cells[fila, letras[j - 1]] = dGVMaterial.Rows[i].Cells[j].Value;
                        Excel.Range r;
                        string l = letras[j - 1].ToString();
                        r = ws.get_Range(l + fila.ToString(), l + fila.ToString());
                        r.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                            Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                        if (j == 4 || j == 6) //Signo de $ para Costo e Importe
                            ws.Cells[fila, letras[j - 1]] = "$" + dGVMaterial.Rows[i].Cells[j].Value;
                        if (j == 3 || j==5) //Centrar Unidad y Rendimiento
                        {
                            r.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            r.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        }
                    }
                }
                ws.Cells[(8 + dGVMaterial.RowCount), 6] = "$" + txtSumImpMat.Text;
                Excel.Range s;
                s = ws.get_Range("F" + (8 + dGVMaterial.RowCount), "F" + (8 + dGVMaterial.RowCount));
                s.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                    Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                s.Font.Bold = true;

                //------Mano de Obra------
                rowsM = fila + dGVMaterial.Rows.Count + 2;
                ws.Cells[(rowsM - 1), 1] = "Mano de Obra";
                for (int i = 1; i < dGVMano.Columns.Count; i++)
                {
                    ws.Cells[rowsM, letras[i - 1]] = dGVMano.Columns[i].HeaderText;
                    Excel.Range r;
                    string l = letras[i - 1].ToString();
                    r = ws.get_Range("A"+rowsM.ToString(), l + rowsM.ToString());
                    r.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                        Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                    r.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    r.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
                int filaMano = rowsM + 2;
                for (int i = 0; i < dGVMano.Rows.Count; i++)
                {
                    rowsM++;
                    for (int j = 1; j < dGVMano.Columns.Count; j++)
                    {
                        ws.Cells[rowsM, letras[j - 1]] = dGVMano.Rows[i].Cells[j].Value;
                        Excel.Range r;
                        string l = letras[j - 1].ToString();
                        r = ws.get_Range(l + rowsM.ToString(), l + rowsM.ToString());
                        r.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                            Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                        if (j == 3 || j == 4 || j == 6) //Signo de $ para Sueldo Semanal, Salario Total e Importe
                            ws.Cells[rowsM, letras[j - 1]] = "$" + dGVMano.Rows[i].Cells[j].Value;
                        if (j == 3 || j == 5) //Centrar Rendimiento 
                        {
                            r.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            r.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        }
                    }
                }
                ws.Cells[(rowsM + 1), 6] = "$" + txtSumImpMan.Text;
                Excel.Range s1;
                s1 = ws.get_Range("F" + (rowsM + 1), "F" + (rowsM + 1));
                s1.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                    Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                s1.Font.Bold = true;
                //---------Equipo-----------
                rowsE = filaMano + dGVMano.Rows.Count + 2;
                ws.Cells[(rowsE - 1), 1] = "Equipo/Maquinaria";
                for (int i = 1; i < dGVEquipo.Columns.Count; i++)
                {
                    ws.Cells[rowsE, letras[i - 1]] = dGVEquipo.Columns[i].HeaderText;
                    Excel.Range r;
                    string l = letras[i - 1].ToString();
                    r = ws.get_Range("A" + rowsE.ToString(), l + rowsE.ToString());
                    r.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                        Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                    r.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    r.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
                int filaEQ = rowsE + 1;
                for (int i = 0; i < dGVEquipo.Rows.Count; i++)
                {
                    rowsE++;
                    for (int j = 1; j < dGVEquipo.Columns.Count; j++)
                    {
                        ws.Cells[rowsE, letras[j - 1]] = dGVEquipo.Rows[i].Cells[j].Value;
                        Excel.Range r;
                        string l = letras[j - 1].ToString();
                        r = ws.get_Range(l + rowsE.ToString(), l + rowsE.ToString());
                        r.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                            Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                        if (j == 4 || j == 6) //Signo de $ para Costo/hr e Importe
                            ws.Cells[rowsE, letras[j - 1]] = "$" + dGVEquipo.Rows[i].Cells[j].Value;
                        if (j == 3 || j==5) //Centrar Unidad y Rendimiento 
                        {
                            r.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            r.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        }
                    }
                }
                ws.Cells[(rowsE + 1), 6] = "$" + txtSumImpEQ.Text;
                Excel.Range s2;
                s2 = ws.get_Range("F" + (rowsE + 1), "F" + (rowsE + 1));
                s2.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                    Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                s2.Font.Bold = true;

                ws.Cells[(rowsE + 3), 1] = "Observaciones";
                ws.Cells[(rowsE + 4), 1] = txtObservaciones.Text;
                Excel.Range observaciones;
                int f = rowsE + 4;
                int f3 = rowsE + 8;
                string f1 = "A" + f.ToString();
                string f2 = "B" + f3.ToString();
                ws.get_Range(f1, f2).Merge(false);
                observaciones = ws.get_Range(f1, f2);
                observaciones.HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify;
                observaciones.VerticalAlignment = Excel.XlHAlign.xlHAlignJustify;
                observaciones.Font.Size = 12;
                observaciones.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin,
                    Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

                ws.Cells[f + 7, "A"] = "Elaboró " + txtUsuario.Text;

                FormatoCostos(ws, f, IndCamptxt, IndOFtxt, Utilidadtxt, Finantxt, txtCostoDir, txtIndCam, 
                    txtIndOF, txtUtilidad, txtFinanciamiento, txtPrecioUnitario);
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al crear el libro de Excel", "Error 00006",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void FormatoCostos(Excel.Worksheet ws, int f, TextBox IndCamptxt, TextBox IndOFtxt, TextBox Utilidadtxt, TextBox Finantxt,
             TextBox txtCostoDir, TextBox txtIndCam, TextBox txtIndOF, TextBox txtUtilidad, TextBox txtFinanciamiento, TextBox txtPrecioUnitario)
        {
            #region "PORCENTAJES"
            Excel.Range por;
            por = ws.get_Range("C" + (f - 1), "C" + (f - 1));
            por.Font.Bold = true;
            ws.get_Range("C" + (f - 1), "C" + (f - 1)).Merge(false);
            por.FormulaR1C1 = "%";
            por.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            Excel.Range IndCamp;
            IndCamp = ws.get_Range("C" + f, "C" + f);
            ws.Cells[f, "C"] = IndCamptxt.Text + "%";
            IndCamp.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            Excel.Range IndOF;
            IndOF = ws.get_Range("C" + (f + 1), "C" + (f + 1));
            ws.Cells[f + 1, "C"] = IndOFtxt.Text + "%";
            IndOF.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            Excel.Range Util;
            Util = ws.get_Range("C" + (f + 2), "C" + (f + 2));
            ws.Cells[f + 2, "C"] = Utilidadtxt.Text + "%";
            Util.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            Excel.Range Fin;
            Fin = ws.get_Range("C" + (f + 3), "C" + (f + 3));
            ws.Cells[f + 3, "C"] = Finantxt.Text + "%";
            Fin.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            #endregion

            #region "COLUMNA TITULOS COSTOS"
            Excel.Range costoDir;
            costoDir = ws.get_Range("D" + (f - 1), "E" + (f - 1));
            costoDir.Font.Bold = true;
            ws.get_Range("D" + (f - 1), "E" + (f - 1)).Merge(false);
            costoDir.FormulaR1C1 = "COSTO DIRECTO";
            costoDir.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            Excel.Range indCamp;
            indCamp = ws.get_Range("D" + f, "E" + f);
            ws.get_Range("D" + f, "E" + f).Merge(false);
            indCamp.FormulaR1C1 = "INDIRECTO DE CAMPO";
            indCamp.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            Excel.Range indOF;
            indOF = ws.get_Range("D" + (f + 1), "E" + (f + 1));
            ws.get_Range("D" + (f + 1), "E" + (f + 1)).Merge(false);
            indOF.FormulaR1C1 = "INDIRECTO DE OFICINA C.";
            indOF.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            Excel.Range utilidad;
            utilidad = ws.get_Range("D" + (f + 2), "E" + (f + 2));
            ws.get_Range("D" + (f + 2), "E" + (f + 2)).Merge(false);
            utilidad.FormulaR1C1 = "UTILIDAD";
            utilidad.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            Excel.Range financiamiento;
            financiamiento = ws.get_Range("D" + (f + 3), "E" + (f + 3));
            ws.get_Range("D" + (f + 3), "E" + (f + 3)).Merge(false);
            financiamiento.FormulaR1C1 = "FINANCIAMIENTO";
            financiamiento.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            Excel.Range pu;
            pu = ws.get_Range("D" + (f + 4), "E" + (f + 4));
            pu.Font.Bold = true;
            ws.get_Range("D" + (f + 4), "E" + (f + 4)).Merge(false);
            pu.FormulaR1C1 = "PRECIO UNITARIO";
            pu.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            #endregion

            #region "COSTOS"
            Excel.Range costo_Dir;
            costo_Dir = ws.get_Range("F" + (f - 1), "F" + (f - 1));
            ws.Cells[f - 1, "F"] = "$" + txtCostoDir.Text;
            costo_Dir.Font.Bold = true;

            ws.Cells[f, "F"] = "$" + txtIndCam.Text;
            ws.Cells[f + 1, "F"] = "$" + txtIndOF.Text;
            ws.Cells[f + 2, "F"] = "$" + txtUtilidad.Text;
            ws.Cells[f + 3, "F"] = "$" + txtFinanciamiento.Text;

            Excel.Range p_u;
            p_u = ws.get_Range("F" + (f + 4), "F" + (f + 4));
            ws.Cells[f + 4, "F"] = "$" + txtPrecioUnitario.Text;
            p_u.Font.Bold = true;
            #endregion
        }

        public void EliminarEquipo(ComboBox cb, TextBox txt)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "delete from listapu.equipo where Codigo ='" + cb.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                DialogResult dialog = MessageBox.Show("¿Realmente deseas eliminar este Equipo/Maquinaria?", "Eliminar",
                    MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Se ha eliminado el Equipo/Maquinaria con el Código: " + txt.Text, "Equipo/Maquinaria eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar un registro", "Ocurrió un error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarMano(ComboBox cb, TextBox txt)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "delete from listapu.manodeobra where Codigo ='" + cb.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                DialogResult dialog = MessageBox.Show("¿Realmente deseas eliminar esta persona?", "Eliminar Persona",
                    MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Se ha eliminado la persona con el Código: " + txt.Text, "Personal eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar un registro", "Ocurrió un error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarMaterial(ComboBox cb, TextBox txt)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "delete from listapu.materiales where Codigo ='" + cb.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                DialogResult dialog = MessageBox.Show("¿Realmente deseas eliminar este Material?", "Eliminar Material",
                    MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Se ha eliminado el material con el Código: " + txt.Text, "Material eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar un registro", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Filtrar(DataGridView dGV)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int i = 0; i < dGV.Rows.Count; i++)
                {
                    row = dGV.Rows[i];
                    if (Convert.ToBoolean(row.Cells[0].Value) == false)
                    {
                        dGV.Rows.Remove(row);
                        i--;
                    }
                    else
                        if (Convert.ToBoolean(row.Cells[0].Value) == true)
                            row.Cells[0].Value = false;
                }
            }
            catch
            {
                MessageBox.Show("No se puede hacer la selección", "Error 00005",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GuardarArreglo(DataGridView dGV)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int i = 0; i < dGV.Rows.Count; i++)
                {
                    row = dGV.Rows[i];
                    if (Convert.ToBoolean(row.Cells[0].Value) == false)
                    {
                        dGV.Rows.Remove(row);
                        i--;
                    }
                }
                for (int i = 0; i < dGV.Rows.Count; i++)
                {
                    Excel.Application ExcelObj = new Excel.Application();
                    Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(
                    "C:\\Users\\ErikaDL\\Desktop\\" + dGV[1, i].Value + ".xlsx", 0, true, 5,
                    "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false,
                    0, true);

                    Excel.Sheets sheets = theWorkbook.Worksheets;
                    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
                    ExcelObj.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("No se puede hacer la selección", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IniciarSesion(TextBox txtUsuario, TextBox txtContrasena, Timer t1)//, Label lbl)
        {
            try
            {
                string constring = "datasource = localhost; port = 3306; username = root; password = ";
                MySqlConnection con = new MySqlConnection(constring);
                MySqlCommand cmd = new MySqlCommand("select * from listapu.usuario where usuario = '" + txtUsuario.Text + "' and contraseña = '" + txtContrasena.Text + "'", con);
                MySqlDataReader reader;
                con.Open();
                reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    t1.Enabled = true;
                    //lbl.Text = txtUsuario.Text;
                }
                else
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error 00001", MessageBoxButtons.OK, MessageBoxIcon.Error);

                con.Close();
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Error 00002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IniciarSesionDatos(TextBox txtUsuario, TextBox txtContrasena, Timer t1)
        {
            try
            {
                string constring = "datasource = localhost; port = 3306; username = root; password = ";
                MySqlConnection con = new MySqlConnection(constring);
                MySqlCommand cmd = new MySqlCommand("select usuario, contraseña, grupo from listapu.usuario where usuario = '" + txtUsuario.Text + "'and contraseña = '" + txtContrasena.Text + "' and grupo = 'Administrador'", con);
                MySqlDataReader reader;
                con.Open();
                reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                    t1.Enabled = true;
                else
                    MessageBox.Show("El usuario no es Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                con.Close();
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertarEquipo(TextBox txtCodigo, TextBox txtDesc, TextBox txtUnidad, TextBox txtCosto, TextBox txtVida, TextBox txtCostohr)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                    myConnectionString = "Database=listapu;Data Source=localhost;User Id=root;Password=";
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myInsertQuery = "INSERT INTO equipo (CODIGO, DESCRIPCION, COSTO, VIDAUTIL, UNIDAD, COSTOHR, RENDIMIENTO, IMPORTE) Values(?codigo,?desc,?costo,?vidautil,?unidad,?costohr,?ren,?imp)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Parameters.Add("?codigo", MySqlDbType.VarChar, 20).Value = txtCodigo.Text;
                myCommand.Parameters.Add("?desc", MySqlDbType.VarChar, 100).Value = txtDesc.Text;
                myCommand.Parameters.Add("?costo", MySqlDbType.Double, 10).Value = txtCosto.Text;
                myCommand.Parameters.Add("?vidautil", MySqlDbType.Double, 10).Value = txtVida.Text;
                myCommand.Parameters.Add("?unidad", MySqlDbType.VarChar, 10).Value = txtUnidad.Text;
                myCommand.Parameters.Add("?costohr", MySqlDbType.Double, 10).Value = txtCostohr.Text;
                myCommand.Parameters.Add("?ren", MySqlDbType.Double, 10).Value = 0;
                myCommand.Parameters.Add("?imp", MySqlDbType.Double, 10).Value = 0;
                myCommand.Connection = myConnection;
                myConnection.Open();
                DialogResult dialog = MessageBox.Show("¿Deseas agregar este Equipo/Maquinaria?", "Agregar Equipo/Maquinaria", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha agregado el Equipo/Maquinaria con el Código: " + txtCodigo.Text,
                        "Equipo/Maquinaria agregado", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                myCommand.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Error al insertar un nuevo equipo:\n*Revisa la conexión a la Base de Datos. \n*Los campos estén completos.", "Error 00007",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void InsertarMaterial(TextBox txtCodigo, TextBox txtDesc, TextBox txtUnidad, TextBox txtCosto)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                    myConnectionString = "Database=listapu;Data Source=localhost;User Id=root;Password=";
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myInsertQuery = "INSERT INTO materiales (Codigo, Descripcion, Unidad, Costo, Rendimiento, Importe) Values(?codigo,?desc,?unidad,?costo,?ren,?imp)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Parameters.Add("?codigo", MySqlDbType.VarChar, 20).Value = txtCodigo.Text;
                myCommand.Parameters.Add("?desc", MySqlDbType.VarChar, 50).Value = txtDesc.Text;
                myCommand.Parameters.Add("?unidad", MySqlDbType.VarChar, 10).Value = txtUnidad.Text;
                myCommand.Parameters.Add("?costo", MySqlDbType.Double, 10).Value = txtCosto.Text;
                myCommand.Parameters.Add("?ren", MySqlDbType.Double, 10).Value = 0;
                myCommand.Parameters.Add("?imp", MySqlDbType.Double, 10).Value = 0;
                myCommand.Connection = myConnection;
                myConnection.Open();

                DialogResult dialog = MessageBox.Show("¿Deseas agregar este Material?", "Agregar Material", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Se ha agregado el Material con el Código: " + txtCodigo.Text,
                        "Material agregado", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                myCommand.Connection.Close();


            }
            catch
            {
                MessageBox.Show("Error al insertar un nuevo material:\n*Revisa la conexión a la Base de Datos. \n*Los campos estén completos.", "Error 00007",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void llenarCombo(ComboBox cb, string db)
        {
            try
            {
                string constring = "datasource = localhost; port = 3306; username = root; password = ";
                string query = "select * from " + db + ";";
                MySqlConnection con = new MySqlConnection(constring);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString("Codigo");
                    cb.Items.Add(sName);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Error 00002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarComboTAPU(ComboBox cb)
        {
            try
            {
                string constring = "datasource = localhost; port = 3306; username = root; password = ";
                string query = "select * from listapu.vp_titulos;";
                MySqlConnection con = new MySqlConnection(constring);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString("Clave");
                    cb.Items.Add(sName);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Error 00002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public void NuevoUsuario(TextBox txtNombre, TextBox txtApellidos, string correo, TextBox txtUsuario,
            TextBox txtContrasena, ComboBox cb)
        {
            try
            {
                //PARA VERIFICAR SI YA EXISTE UN ADMINISTRADOR                
                string constring = "datasource = localhost; port = 3306; username = root; password = ";
                MySqlConnection con = new MySqlConnection(constring);
                MySqlCommand cmd = new MySqlCommand("select * from listapu.usuario where grupo = 'administrador' ", con);
                MySqlDataReader reader;
                con.Open();
                reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 2)
                    MessageBox.Show("Ya no se pueden agregar administradores", "Límite de administadores");
                else
                {
                    con.Close();
                    //PARA INSERTAR EL NUEVO USUARIO
                    string myConnectionString = "";
                    if (myConnectionString == "")
                        myConnectionString = "Database=listapu;Data Source=localhost;User Id=root;Password=";
                    MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                    string myInsertQuery = "INSERT INTO usuario (nombre, apellidos, correo, usuario, contraseña, grupo) Values(?nombre, ?apellidos, ?correo, ?usuario, ?contraseña, ?grupo)";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                    myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 20).Value = txtNombre.Text;
                    myCommand.Parameters.Add("?apellidos", MySqlDbType.VarChar, 20).Value = txtApellidos.Text;
                    myCommand.Parameters.Add("?correo", MySqlDbType.VarChar, 20).Value = correo;
                    myCommand.Parameters.Add("?usuario", MySqlDbType.VarChar, 20).Value = txtUsuario.Text;
                    myCommand.Parameters.Add("?contraseña", MySqlDbType.VarChar, 20).Value = txtContrasena.Text;
                    myCommand.Parameters.Add("?grupo", MySqlDbType.VarChar, 20).Value = cb.Text;

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
                    MessageBox.Show("Cuenta creada correctamente\r\n Por favor inicia sesión");
                }
            }
            catch
            {
                MessageBox.Show("Error al crear la cuenta, verifica los datos", "Error 00002",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void obtenerBasesDatosMySQL()
        {
            MySqlDataReader registrosObtenidosMySQL = null;
            MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexionBD);
            try
            {
                registrosObtenidosMySQL = cmd.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Error al obtener la Base de Datos de MySQL", "Error 00002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (registrosObtenidosMySQL != null)
                    registrosObtenidosMySQL.Close();
            }
        }

        public void obtenerTablasBDMysql()
        {
            MySqlDataReader reader = null;
            try
            {
                conexionBD.ChangeDatabase("listapu");
                MySqlCommand cmd = new MySqlCommand("SHOW TABLES", conexionBD);
                reader = cmd.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Error al obtener la tabla de la Base de Datos", "Error 00002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        public void VisualizarDatosPpales(Label lbl, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5,
            TextBox txt6, TextBox txt7, TextBox txt8, TextBox txt9, TextBox txt10, TextBox txt11, TextBox txt12,
            TextBox txt13, TextBox txt14, TextBox txt15, TextBox txt16, TextBox txt17, TextBox txt18,
            TextBox txt19, TextBox txt20, TextBox txt21, TextBox txt22, TextBox txt23)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "select * from listapu.datosprincipales where CODIGO = '1';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string fecha = reader.GetString("fecha");
                    double smv = reader.GetDouble("SMV");
                    double prt = reader.GetDouble("PRT");
                    double fdiasinh = reader.GetDouble("FDIASINH");
                    double cuotafija = reader.GetDouble("CUOTAFIJA");
                    double excedentep = reader.GetDouble("EXCEDENTEP");
                    double excedenteo = reader.GetDouble("EXCEDENTEO");
                    double prestacionp = reader.GetDouble("PRESTACIONP");
                    double prestaciono = reader.GetDouble("PRESTACIONO");
                    double gastmedp = reader.GetDouble("GASTMEDP");
                    double gastmedo = reader.GetDouble("GASTMEDO");
                    double invyvidap = reader.GetDouble("INVYVIDAP");
                    double invyvidao = reader.GetDouble("INVYVIDAO");
                    double guaryprest = reader.GetDouble("GUARYPREST");
                    double retiro = reader.GetDouble("RETIRO");
                    double vejezp = reader.GetDouble("VEJEZP");
                    double vejezo = reader.GetDouble("VEJEZO");
                    double infonavit = reader.GetDouble("INFONAVIT");
                    double aguinaldo = reader.GetDouble("AGUINALDO");
                    double primavacacional = reader.GetDouble("PRIMAVACACIONAL");
                    double factzona = reader.GetDouble("FACTZONA");
                    double impsnomina = reader.GetDouble("IMPSNOMINA");
                    double facteqseg = reader.GetDouble("FACTEQSEG");
                    double factherr = reader.GetDouble("FACTHERR");

                    lbl.Text = "Última actulización: \r\n" + fecha.ToString();

                    txt1.Text = smv.ToString();
                    txt2.Text = prt.ToString();
                    txt3.Text = fdiasinh.ToString();
                    txt4.Text = cuotafija.ToString();
                    txt5.Text = excedentep.ToString();
                    txt6.Text = excedenteo.ToString();
                    txt7.Text = prestacionp.ToString();
                    txt8.Text = prestaciono.ToString();
                    txt9.Text = gastmedp.ToString();
                    txt10.Text = gastmedo.ToString();
                    txt11.Text = invyvidap.ToString();
                    txt12.Text = invyvidao.ToString();
                    txt13.Text = guaryprest.ToString();
                    txt14.Text = retiro.ToString();
                    txt15.Text = vejezp.ToString();
                    txt16.Text = vejezo.ToString();
                    txt17.Text = infonavit.ToString();
                    txt18.Text = aguinaldo.ToString();
                    txt19.Text = primavacacional.ToString();
                    txt20.Text = factzona.ToString();
                    txt21.Text = impsnomina.ToString();
                    txt22.Text = facteqseg.ToString();
                    txt23.Text = factherr.ToString();

                }
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VisualizarEquipo(DataGridView dGVEquipo)
        {
            Conectar();
            obtenerTablasBDMysql();
            DataTable tabla;
            MySqlDataAdapter datosAdapter;
            MySqlCommandBuilder comandoSQL;
            try
            {
                tabla = new DataTable();
                datosAdapter = new MySqlDataAdapter("select Codigo, Descripcion, Unidad, CostoHr, Rendimiento, Importe from equipo", conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGVEquipo.DataSource = tabla;
                dGVEquipo.Columns[0].Width = 50;
                dGVEquipo.Columns[1].Width = 100;
                dGVEquipo.Columns[2].Width = 190;
                dGVEquipo.Columns[3].Width = 60;
                dGVEquipo.Columns[4].HeaderText = "Costo/hr";
                dGVEquipo.Columns[4].Width = 80;
                dGVEquipo.Columns[5].Width = 95;
                dGVEquipo.Columns[6].Width = 80;
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VisualizarManodeObra(DataGridView dGVManodeObra)
        {
            Conectar();
            obtenerTablasBDMysql();
            DataTable tabla;
            MySqlDataAdapter datosAdapter;
            MySqlCommandBuilder comandoSQL;
            try
            {
                tabla = new DataTable();
                datosAdapter = new MySqlDataAdapter("select Codigo, Ocupacion, SueldoSemanalVigente, SalarioTotal, Rendimiento, Importe from manodeobra", conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGVManodeObra.DataSource = tabla;
                dGVManodeObra.Columns[0].Width = 50;
                dGVManodeObra.Columns[1].Width = 100;
                dGVManodeObra.Columns[2].Width = 160;
                dGVManodeObra.Columns[3].Width = 100;
                dGVManodeObra.Columns[3].HeaderText = "Sueldo Sem. Vig.";
                dGVManodeObra.Columns[4].Width = 100;
                dGVManodeObra.Columns[4].HeaderText = "Salario Total";
                dGVManodeObra.Columns[5].Width = 100;
                dGVManodeObra.Columns[6].Width = 65;
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void VisualizarMateriales(DataGridView dGVMateriales)
        {
            if (conexionBD != null)
                conexionBD.Close();

            string connStr =
                String.Format("server={0};port={1};user id={2}; password={3}; " +
                "database=mysql; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                "localhost", "3306", "root", "");
            try
            {
                conexionBD = new MySqlConnection(connStr);
                conexionBD.Open();
                obtenerBasesDatosMySQL();
                obtenerTablasBDMysql();
                DataTable tabla;
                MySqlDataAdapter datosAdapter;
                MySqlCommandBuilder comandoSQL;
                tabla = new DataTable();
                datosAdapter = new MySqlDataAdapter("select * from materiales", conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGVMateriales.DataSource = tabla;
                dGVMateriales.Columns[0].Width = 50;
                dGVMateriales.Columns[1].Width = 100;
                dGVMateriales.Columns[2].Width = 190;
                dGVMateriales.Columns[3].Width = 70;
                dGVMateriales.Columns[4].Width = 70;
                dGVMateriales.Columns[5].Width = 100;
                dGVMateriales.Columns[6].Width = 70;

                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VisualizarTAPU(DataGridView dGVTAPU)
        {
            if (conexionBD != null)
                conexionBD.Close();

            string connStr =
                String.Format("server={0};port={1};user id={2}; password={3}; " +
                "database=mysql; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                "localhost", "3306", "root", "");
            try
            {
                conexionBD = new MySqlConnection(connStr);
                conexionBD.Open();
                obtenerBasesDatosMySQL();
                obtenerTablasBDMysql();
                DataTable tabla;
                MySqlDataAdapter datosAdapter;
                MySqlCommandBuilder comandoSQL;
                tabla = new DataTable();
                datosAdapter = new MySqlDataAdapter("select * from vp_titulos", conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGVTAPU.DataSource = tabla;
                
                conexionBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos de la tabla [materiales] de MySQL: " + ex.ToString(),
                    "Error ejecutar SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Abrir Tarjeta"
        public void vp_titulos(ComboBox cb_clave, TextBox txtClave, TextBox txtConcepto, TextBox txtUnidad, TextBox txtPU)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "select Clave, Concepto, Unidad, PrecioUnitario from listapu.vp_titulos where Clave = '" + cb_clave.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string clave = reader.GetString("Clave");
                    string concepto = reader.GetString("Concepto");
                    string unidad = reader.GetString("Unidad");
                    double pu = reader.GetDouble("PrecioUnitario");

                    txtClave.Text = clave;
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

        public void vp_materiales(DataGridView dGVMateriales, ComboBox cb_clave)
        {
            if (conexionBD != null)
                conexionBD.Close();

            string connStr =
                String.Format("server={0};port={1};user id={2}; password={3}; " +
                "database=mysql; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                "localhost", "3306", "root", "");
            try
            {
                conexionBD = new MySqlConnection(connStr);
                conexionBD.Open();
                obtenerBasesDatosMySQL();
                obtenerTablasBDMysql();
                DataTable tabla;
                MySqlDataAdapter datosAdapter;
                MySqlCommandBuilder comandoSQL;
                tabla = new DataTable();
                datosAdapter = new MySqlDataAdapter("SELECT clave_tarjeta, Codigo, Descripcion, Unidad, Costo, Rendimiento, Importe FROM listapu.vp_materiales where clave_tarjeta = '" + cb_clave.Text + "';", conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGVMateriales.DataSource = tabla;
                dGVMateriales.Columns[0].Width = 50;
                dGVMateriales.Columns[0].Visible = false;
                dGVMateriales.Columns[1].Width = 100;
                dGVMateriales.Columns[2].Width = 190;
                dGVMateriales.Columns[3].Width = 80;
                dGVMateriales.Columns[4].Width = 80;
                dGVMateriales.Columns[5].Width = 100;
                dGVMateriales.Columns[6].Width = 80;

                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vp_manodeobra(DataGridView dGVManodeobra, ComboBox cb_clave)
        {
            if (conexionBD != null)
                conexionBD.Close();

            string connStr =
                String.Format("server={0};port={1};user id={2}; password={3}; " +
                "database=mysql; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                "localhost", "3306", "root", "");
            try
            {
                conexionBD = new MySqlConnection(connStr);
                conexionBD.Open();
                obtenerBasesDatosMySQL();
                obtenerTablasBDMysql();
                DataTable tabla;
                MySqlDataAdapter datosAdapter;
                MySqlCommandBuilder comandoSQL;
                tabla = new DataTable();
                datosAdapter = new MySqlDataAdapter("SELECT clave_tarjeta, Codigo, Ocupacion, SueldoSemVig, SalarioTotal, Rendimiento, Importe FROM listapu.vp_manodeobra where clave_tarjeta = '" + cb_clave.Text + "';", conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGVManodeobra.DataSource = tabla;
                //[0] = clave_tarjeta [1] = Codigo [2] = Ocupacion
                //[3] = SueldoSemVig [4] = Salario Total [5] = Rendimiento [6] = Importe    
                dGVManodeobra.Columns[0].Width = 100;
                dGVManodeobra.Columns[0].Visible = false;
                dGVManodeobra.Columns[1].Width = 70;
                dGVManodeobra.Columns[2].Width = 150;
                dGVManodeobra.Columns[3].Width = 140;
                dGVManodeobra.Columns[3].HeaderText = "Sueldo Sem. Vig.";
                dGVManodeobra.Columns[4].Width = 100;
                dGVManodeobra.Columns[4].HeaderText = "Salario Total";
                dGVManodeobra.Columns[5].Width = 80;
                dGVManodeobra.Columns[6].Width = 80;

                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vp_eqmaq(DataGridView dGVEquipo, ComboBox cb_clave)
        {
            if (conexionBD != null)
                conexionBD.Close();

            string connStr =
                String.Format("server={0};port={1};user id={2}; password={3}; " +
                "database=mysql; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                "localhost", "3306", "root", "");
            try
            {
                string query = "SELECT clave_tarjeta, Codigo, Descripcion, Unidad, CostoHr, Rendimiento, Importe " +
                               "FROM listapu.vp_eqmaq " +
                               "WHERE clave_tarjeta = '" + cb_clave.Text + "';";
                conexionBD = new MySqlConnection(connStr);
                conexionBD.Open();
                obtenerBasesDatosMySQL();
                obtenerTablasBDMysql();
                DataTable tabla;
                MySqlDataAdapter datosAdapter;
                MySqlCommandBuilder comandoSQL;
                tabla = new DataTable();
                datosAdapter = new MySqlDataAdapter(query, conexionBD);
                comandoSQL = new MySqlCommandBuilder(datosAdapter);
                datosAdapter.Fill(tabla);
                dGVEquipo.DataSource = tabla;
                //[0] = clave_tarjeta [1] = Codigo [2] = Descripcion
                //[3] = Unidad [4] = CostoHr [5] = Rendimiento [6] = Importe                
                dGVEquipo.Columns[0].Width = 100;
                dGVEquipo.Columns[0].Visible = false;                
                dGVEquipo.Columns[1].Width = 100;
                dGVEquipo.Columns[2].Width = 200;
                dGVEquipo.Columns[3].Width = 80;
                dGVEquipo.Columns[4].Width = 80;
                dGVEquipo.Columns[5].Width = 80;
                dGVEquipo.Columns[6].Width = 80;

                conexionBD.Close();
            }
            catch
            {
                MessageBox.Show("Error al mostrar los datos", "Error 00002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vp_costos(ComboBox cb_clave, Label lbl_MAT, Label lbl_MAN, Label lbl_EqMaq, TextBox txtCostoDirecto, TextBox txtIndCamp, TextBox txtIndOf, TextBox txtUtilidad,
            TextBox txtFinanciamiento, TextBox txtPrecioUni)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "SELECT TotalMateriales, TotalManodeObra, TotalEquMaq, CostoDirecto, "+ 
                           "indCamp, indOf, utilidad, financiamiento, PrecioUni " + 
                           "FROM listapu.vp_costos " + 
                           "WHERE clave_tarjeta = '" + cb_clave.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    double MAT = reader.GetDouble("TotalMateriales");
                    double MAN = reader.GetDouble("TotalManodeObra");
                    double EqMaq = reader.GetDouble("TotalEquMaq");                    
                    double CostoDirecto = reader.GetDouble("CostoDirecto");
                    double IndCamp = reader.GetDouble("IndCamp");
                    double IndOf = reader.GetDouble("IndOf");
                    double Utilidad = reader.GetDouble("Utilidad");
                    double Financiamiento = reader.GetDouble("Financiamiento");
                    double PrecioUni = reader.GetDouble("PrecioUni");

                    lbl_MAT.Text = MAT.ToString("0.##");
                    lbl_MAN.Text = MAN.ToString("0.##");
                    lbl_EqMaq.Text = EqMaq.ToString("0.##");
                    txtCostoDirecto.Text = CostoDirecto.ToString("0.##");
                    txtIndCamp.Text = IndCamp.ToString("0.##");
                    txtIndOf.Text = IndOf.ToString("0.##");
                    txtUtilidad.Text = Utilidad.ToString("0.##");
                    txtFinanciamiento.Text = Financiamiento.ToString("0.##");
                    txtPrecioUni.Text = PrecioUni.ToString("0.##");
                }
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vp_porc_obs_el(ComboBox cb_clave, TextBox txtPor_indCamp, TextBox txtPor_indOf, TextBox txtPor_utilidad,
            TextBox txtPor_finan, TextBox txtObservaciones, TextBox txtElaboro)
        {
            string constring = "datasource = localhost; port = 3306; username = root; password = ";
            string query = "SELECT por_indCamp, por_indOf, por_utilidad, por_finan, observaciones, elaboro " + 
                           "FROM listapu.vp_porc_obs_el " + 
                           "WHERE clave_tarjeta = '" + cb_clave.Text + "';";

            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    double por_indCamp = reader.GetDouble("por_indCamp");
                    double por_indOf = reader.GetDouble("por_indOf");
                    double por_utilidad = reader.GetDouble("por_utilidad");
                    double por_finan = reader.GetDouble("por_finan");
                    string observaciones = reader.GetString("observaciones");
                    string elaboro = reader.GetString("elaboro");

                    txtPor_indCamp.Text = por_indCamp.ToString("0.##");
                    txtPor_indOf.Text = por_indOf.ToString("0.##");
                    txtPor_utilidad.Text = por_utilidad.ToString("0.##");
                    txtPor_finan.Text = por_finan.ToString("0.##");
                    txtObservaciones.Text = observaciones;
                    txtElaboro.Text = elaboro;
                }
            }
            catch
            {
                MessageBox.Show("Error en la conexión de la Base de Datos", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion





    }
}
