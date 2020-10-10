using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;//Sistema. Tiempo de ejecución. Espacio de nombres de servicios de interoperabilidad

using System.IO;

namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    public partial class FrmRegistrarCandidato : Form
    {
        public static string cod;
        public FrmRegistrarCandidato()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }

        List<ClsCandidatos> listacandidatos = new List<ClsCandidatos>();

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        string linea;
        private void FrmRegistrarCandidato_Load(object sender, EventArgs e)
        {
            dgvCandidatos.AllowUserToAddRows = false;

            StreamReader leer = new StreamReader(@"Candidatos.txt");

            linea = leer.ReadLine();
            while (linea != null)
            {
                ClsCandidatos obj = new ClsCandidatos();
                string[] datos_fichero = linea.Split(';');
                obj.Codigo = datos_fichero[0];
                obj.Cargo = datos_fichero[1];
                obj.Nombre = datos_fichero[2];
                obj.Apellido = datos_fichero[3];
                obj.Edad = datos_fichero[4];
                obj.Sexo = datos_fichero[5];
                linea = leer.ReadLine();
                listacandidatos.Add(obj);
            }
            dgvCandidatos.DataSource = listacandidatos;
            Frm.Codigo = "";
            leer.Close();
        }
        public void CAPTURA()
        {
            

        }
        public void ESPERA(int INTERVALO)
        {
            // PARA DAR TIEMPO A QUE CARGUE LA PAGINA
            Stopwatch PARADA = new Stopwatch();
            PARADA.Start();
            while ((PARADA.ElapsedMilliseconds < INTERVALO))
            {
                Application.DoEvents();
            }

            PARADA.Stop();
        }
        public void PRESENTACION()
        { 


        }

      

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void TextBoxCIUDAD_KeyDown(object sender, EventArgs e)
        {
           
        }

        private void TextBoxCIUDAD_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBoxCIUDAD_KeyDown_1(object sender, KeyEventArgs e)
        {
            //SI SE PULSA ENTER EN EL TEXTBOX REINICIA LA CAPTURA
            if (e.KeyCode == Keys.Enter)
            {
                CAPTURA(); //CAPTURA TODOS LOS DATOS
            }
        }

        private void LinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            ClsCandidatos objCandidato = new ClsCandidatos();
            objCandidato.Codigo = txtcodigo.Text;
            objCandidato.Cargo = cbcargo.Text;
            objCandidato.Nombre = txtnombre.Text;
            objCandidato.Apellido = txtapellido.Text;
            objCandidato.Edad = txtedad.Text;
            objCandidato.Sexo = comboxSexo.Text;


            listacandidatos.Add(objCandidato);
            dgvCandidatos.DataSource = null;
            dgvCandidatos.DataSource = listacandidatos;

            StreamWriter writer = new StreamWriter(@"Candidatos.txt");
            foreach (DataGridViewRow item in dgvCandidatos.Rows)
            {
                writer.WriteLine(item.Cells[0].Value.ToString() + ";" +
                                 item.Cells[1].Value.ToString() + ";" +
                                 item.Cells[2].Value.ToString() + ";" +
                                 item.Cells[3].Value.ToString() + ";" +
                                 item.Cells[4].Value.ToString() + ";" +
                                 item.Cells[5].Value.ToString());
            }
            writer.Close();
        }
        public void listar()
        {
           
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
           
        }
        public void Limpiar()
        {
            txtcodigo.Text = "";
            cbcargo.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            comboxSexo.Text = "";
            txtcodigo.Focus();
        }
      
        private void btnmodificar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvCandidatos.Rows)
            {
                if (fila.Cells[0].Value.ToString() == txtcodbuscar.Text)
                {

                    fila.Visible = true;
                }
                else
                {
                    dgvCandidatos.CurrentCell = null;
                    fila.Visible = false;
                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            cbcargo.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            comboxSexo.Text = "";
        }

        private void btnreestablecer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvCandidatos.Rows)
            {
                fila.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal form = new FrmMenuPrincipal();
            form.Show();
            this.Hide();
        }

        private void btnVigilancia_Click(object sender, EventArgs e)
        {

        }

        private void dgvCandidatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEditCandidatos frm = new FrmEditCandidatos(dgvCandidatos.CurrentRow.Cells[0].Value.ToString(),
                                            dgvCandidatos.CurrentRow.Cells[1].Value.ToString(),
                                            dgvCandidatos.CurrentRow.Cells[2].Value.ToString(),
                                            dgvCandidatos.CurrentRow.Cells[3].Value.ToString(),
                                            dgvCandidatos.CurrentRow.Cells[4].Value.ToString(),
                                            dgvCandidatos.CurrentRow.Cells[5].Value.ToString());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            //pasar datos a dta grid view
            if (Frm.Codigo.Length > 0)
            {
                dgvCandidatos.CurrentRow.Cells[0].Value = Frm.Codigo;
                dgvCandidatos.CurrentRow.Cells[1].Value = Frm.Cargo;
                dgvCandidatos.CurrentRow.Cells[2].Value = Frm.Nombre;
                dgvCandidatos.CurrentRow.Cells[3].Value = Frm.Apellido;
                dgvCandidatos.CurrentRow.Cells[4].Value = Frm.Edad;
                dgvCandidatos.CurrentRow.Cells[5].Value = Frm.Sexo;
                Frm.Codigo = "";

            }
            //actualizar fichero
            StreamWriter txt = new StreamWriter(@"Candidatos.txt", false);
            foreach (DataGridViewRow item in dgvCandidatos.Rows)
            {
                txt.WriteLine(item.Cells[0].Value.ToString() + ";" +
                              item.Cells[1].Value.ToString() + ";" +
                              item.Cells[2].Value.ToString() + ";" +
                              item.Cells[3].Value.ToString() + ";" +
                              item.Cells[4].Value.ToString() + ";" +
                              item.Cells[5].Value.ToString());
            }
            txt.Close();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }    


            
}
