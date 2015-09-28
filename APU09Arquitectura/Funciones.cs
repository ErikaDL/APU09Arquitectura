using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace APU09Arquitectura
{
    class Funciones
    {
        public static DataTable selectExcel(string Arch, string Hoja,TextBox txtClave)
        {

            OleDbConnection Conex = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Arch + ";Extended Properties=Excel 12.0;");

            OleDbCommand CmdOle = new OleDbCommand();

            CmdOle.Connection = Conex;
            CmdOle.CommandType = CommandType.Text;
            CmdOle.CommandText = "SELECT * FROM [" + Hoja + "$A7:F8]";

            OleDbDataAdapter AdaptadorOle = new OleDbDataAdapter(CmdOle.CommandText, Conex);

            DataTable dt = new DataTable();

            AdaptadorOle.Fill(dt);

            return dt;
        }

        public void Numeros(object sender, KeyPressEventArgs e, TextBox txt)
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

    }
}
