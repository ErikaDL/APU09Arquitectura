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
    public partial class AgregarMaterial : Form
    {
        conexion c = new conexion();
        APU09Arquitectura.Funciones f = new APU09Arquitectura.Funciones();

        public AgregarMaterial()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            c.InsertarMaterial(txtCodigo, txtDesc, txtUnidad, txtCosto);
            DialogResult dialog1 = MessageBox.Show("¿Deseas agregar a otro Material?", "Agregar Material", 
                MessageBoxButtons.YesNo);
            if (dialog1 == DialogResult.No)
            {
                this.Close();
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AnPrUn);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                AnPrUn a = new AnPrUn();
                a.Show();
                a.tabControl1.SelectTab(0);
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
                }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.Numeros(sender, e, txtCosto);
        }
    }
}
