using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU09Maker
{
    public partial class AgregarEQ : Form
    {
        conexion c = new conexion();
        APU09Arquitectura.Funciones f = new APU09Arquitectura.Funciones();
       
        public AgregarEQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double costohr = Convert.ToDouble(txtCosto.Text) / Convert.ToDouble(txtVida.Text);
                txtCostohr.Text = costohr.ToString("0.##");
            }
            catch
            {
                MessageBox.Show("Revisa los datos ingresados", "Ocurrió un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            c.InsertarEquipo(txtCodigo, txtDesc, txtUnidad, txtCosto, txtVida, txtCostohr);
            DialogResult dialog1 = MessageBox.Show("¿Deseas agregar a otro Equipo/Maquinaria?", 
                "Agregar Equipo/Maquinaria", MessageBoxButtons.YesNo);
            if (dialog1 == DialogResult.No)
            {
                this.Close();
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
                a.tabControl1.SelectTab(2);
                c.VisualizarMateriales(a.dGVMateriales);
                c.VisualizarManodeObra(a.dGVMano);
                c.VisualizarEquipo(a.dGVEquipo);
            }
            else
                if (dialog1 == DialogResult.Yes)
                {
                    txtCodigo.Clear();
                    txtDesc.Clear();
                    txtUnidad.Clear();
                    txtCosto.Clear();
                    txtVida.Clear();
                    txtCostohr.Clear();
                }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txtCosto);
        }

        private void txtVida_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txtVida);
        }
    }
}
