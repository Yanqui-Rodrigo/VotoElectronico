using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;//Sistema. Tiempo de ejecución. Espacio de nombres de servicios de interoperabilidad


namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.MaxLength = 10;
        }
     
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnIngresar_Click(object sender, EventArgs e)
        {
                
           
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void pnlsuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtusuario_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Windows/WinSxS/amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.17134.1_none_903d5fc3c319176b/osk.exe");
            txtusuario.Text = "";
        }

        private void txtcontraseña_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Windows/WinSxS/amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.17134.1_none_903d5fc3c319176b/osk.exe");
            txtcontraseña.Text = "";
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            Size = new Size(960, 540);
            StartPosition = FormStartPosition.CenterParent;
            txtusuario.Size=new Size(356,44);
            txtusuario.Location = new Point(313, 31);
            txtcontraseña.Size = new Size(356, 44);
            txtcontraseña.Location = new Point(313, 92);
         
           
            
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(296, 672);
            txtusuario.Size = new Size(211, 44);
            txtusuario.Location = new Point(48, 47);
            txtcontraseña.Size = new Size(211, 44);
            txtcontraseña.Location = new Point(48, 99);
          
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pnlmedio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            ClsVotantes.Ingreso = 1;
            lblprueba.Text = "votante";
            frm.label2.Text = lblprueba.Text;
            frm.Show();
            this.Hide();
        }

        private void btningresar_Click_1(object sender, EventArgs e)
        {
            string usuario = "admin";
            string contraseña = "admin123";
            ClsVotantes.Ingreso = 0;


            if (txtusuario.Text == usuario)
            {

                if (txtcontraseña.Text == contraseña)
                {
                    MessageBox.Show("Ingresando al sistema...", "BIENVENIDO");
                    FrmMenuPrincipal frm = new FrmMenuPrincipal();
                    lblprueba.Text = "Administrador";
                    frm.label2.Text = lblprueba.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos erroneos", "ERROR");
                }
            }

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "ADMINISTRADOR")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Gray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "ADMINISTRADOR";
                txtusuario.ForeColor = Color.DimGray;

            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.Gray;
                //txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.DimGray;
                //txtcontraseña.UseSystemPasswordChar = false;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
