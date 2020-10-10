using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    public partial class FrmEditCandidatos : Form
    {
        public FrmEditCandidatos()
        {
            InitializeComponent();
        }
        public FrmEditCandidatos(string codigo, string cargo, string nombre, string apellido, string edad, string sexo)
        {
            InitializeComponent();

            txtcodigo.Text = codigo;
            cbcargo.Text = cargo;
            txtnombre.Text = nombre;
            txtapellido.Text = apellido;
            txtedad.Text = edad;
            comboxSexo.Text = sexo;




        }
        private void FrmEditCandidatos_Load(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtapellido.Text.Equals("") || txtcodigo.Text.Equals("") || txtedad.Text.Equals(""))
            {
                MessageBox.Show("Revise datos...");
            }
            else
            {
                Frm.Codigo = txtcodigo.Text;
                Frm.Cargo = cbcargo.Items[cbcargo.SelectedIndex].ToString();
                Frm.Nombre = txtnombre.Text;
                Frm.Apellido = txtapellido.Text;
                Frm.Edad = txtedad.Text;
                Frm.Sexo = comboxSexo.Items[comboxSexo.SelectedIndex].ToString();
                this.Close();
            }
        }
    }
}
