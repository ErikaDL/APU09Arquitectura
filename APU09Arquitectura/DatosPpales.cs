using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU09Arquitectura
{
    public partial class DatosPpales : Form
    {
        APU09Maker.conexion c = new APU09Maker.conexion();
        Funciones f = new Funciones();
        public DatosPpales()
        {
            InitializeComponent();
            c.VisualizarDatosPpales(label19, txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10,
                txt11, txt12, txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20, txt21, txt22, txt23);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.ActualizarDatosPpales(dateTimePicker1, txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10,
                txt11, txt12, txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20, txt21, txt22, txt23);
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt1);
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt2);
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt3);
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt4);
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt5);
        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt6);
        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt7);
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt8);
        }

        private void txt9_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt9);
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt10);
        }

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt11);
        }

        private void txt12_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt12);
        }

        private void txt13_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt13);
        }

        private void txt14_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt14);
        }

        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt15);
        }

        private void txt16_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt16);
        }

        private void txt17_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt17);
        }

        private void txt18_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt18);
        }

        private void txt19_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt19);
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt20);
        }

        private void txt21_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt21);
        }

        private void txt22_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt22);
        }

        private void txt23_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txt23);
        }

    }
}
