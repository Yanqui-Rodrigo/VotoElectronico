using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//Sistema. Tiempo de ejecución. Espacio de nombres de servicios de interoperabilidad


namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        



        private object picPerfil;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVotaciones form = new FrmVotaciones();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTotalVotacion form = new FrmTotalVotacion();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRegistrarCandidato form = new FrmRegistrarCandidato();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("seguro de cerrar ?", "alerta¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form form = new FrmLogin();
                form.Show();
                this.Hide();
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (ClsVotantes.Ingreso==0)
            {
                btnRegistrarCandidato.Enabled = true;               
                btnVotar.Enabled = true;
                btnVotos.Enabled = true;
            }else
            if (ClsVotantes.Ingreso==1)
            {
                btnRegistrarCandidato.Enabled = false;               
                btnVotar.Enabled = true;
                btnVotos.Enabled = true;
            }




        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            Size = new Size(960, 540);
            StartPosition = FormStartPosition.CenterParent;
            
           
            btnRegistrarCandidato.Location = new Point(379, 37);
           
            btnVotar.Location = new Point(379, 150);
            btnVotos.Location = new Point(379, 208);
           
        
            pictureBox1.Location = new Point(442, 6);
        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Size = new Size(296, 672);
            StartPosition = FormStartPosition.CenterParent;
           
          
            btnRegistrarCandidato.Location = new Point(46, 106);
          
            btnVotar.Location = new Point(46, 219);
            btnVotos.Location = new Point(46, 277);
           
    
            pictureBox1.Location = new Point(116, 7);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }
            
           

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Hide();
        }
   

    
 

     
    }
}
