using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using Tecactus.Api.Common;
using Tecactus.Api.Exception;
using Tecactus.Api.Reniec;

namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    public partial class FrmVotaciones : Form
    {
        //CODIGO PARA VER WEBCAM
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public FrmVotaciones()
        {
            InitializeComponent();
            BuscarDispositivos();
        }
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivo.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivo.Text = cbxDispositivo.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }
            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            picCam.Image = Imagen;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        string linea;
        private void FrmVotaciones_Load(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"Candidatos.txt");
            do
            {
                linea = leer.ReadLine();
                if (linea != null || linea == "")
                {
                    string[] datos = linea.Split(';');
                    if (datos[1].Equals("Presidente"))
                    {
                        cbPresidente.Items.Add(datos[2].ToUpper() + " " + datos[3].ToUpper());
                    }
                    else if (datos[1].Equals("Secretario"))
                    {
                        cbSecretario.Items.Add(datos[2].ToUpper() + " " + datos[3].ToUpper());
                    }
                    else if (datos[1].Equals("Tesorero"))
                    {
                        cbTesorero.Items.Add(datos[2].ToUpper() + " " + datos[3].ToUpper());

                    }


                }
            } while (linea != null);
            leer.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMenuPrincipal form = new FrmMenuPrincipal();
            form.label2.Text = "votante";
            form.Show();
            this.Hide();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Equals(""))
            {
                error1.SetError(txtDNI, "Ingrese DNI del trabajador");
                error1.SetError(txtDNI, "");
                return;
            }
            else
            {
                //RENIEC POR DNI
                try
                {
                    var dni = new Tecactus.Api.Reniec.Dni("dJd6YlS1PxnMYFFwLiponnJPJ0CV39j0H5XJnTbA");
                    var person = dni.get(txtDNI.Text);
                    txtDNI.Text = person.dni;
                    lblVotante.Text = person.nombres + " " + person.apellido_paterno + " " + person.apellido_materno;
                    bool validar_voto = true;
                    StreamReader votos = new StreamReader(@"votos realizados.txt");
                    do
                    {
                        linea = votos.ReadLine();
                        if (linea != null || linea == "")
                        {
                            string[] datos = linea.Split(';');
                            if (datos[0].Equals(txtDNI.Text))
                            {
                                validar_voto = false;
                                break;
                            }
                        }
                    } while (linea != null);
                    votos.Close();
                    if(validar_voto is false)
                    {
                        MessageBox.Show("Usted ya realizo su voto.", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        txtDNI.Clear();
                        lblVotante.Text = "------------";
                        txtDNI.Focus();
                    }
                    else
                    {
                        cbPresidente.Enabled = true;
                        cbSecretario.Enabled = true;
                        cbTesorero.Enabled = true;
                        btnVotar.Enabled = true;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cbPresidente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsCandidatos objCandidato = new ClsCandidatos();
            objCandidato.Nombre = cbPresidente.Text;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            /*if (cbPresidente.SelectedIndex == -1)
            {
                error1.SetError(cbPresidente, "Seleccione un Presidente");
                cbPresidente.Focus();
                return;
            }
            error1.SetError(cbPresidente, "");

            if (cbSecretario.SelectedIndex == -1)
            {
                error1.SetError(cbSecretario, "Seleccione un Secretario");
                cbSecretario.Focus();
                return;
            }
            error1.SetError(cbSecretario, "");

            if (cbTesorero.SelectedIndex == -1)
            {
                error1.SetError(cbTesorero, "Seleccione un Tesorero");
                cbTesorero.Focus();
                return;
            }
            error1.SetError(cbTesorero, "");*/

            DialogResult resp = MessageBox.Show("¿Esta seguro de su eleccion?", "Mensaje",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(resp ==DialogResult.Yes)
            {
                StreamWriter txt = new StreamWriter(@"votos realizados.txt", true);//false->sobreescribir      true:seguir escribiendo
                //txt.WriteLine(lblVotante.Text + ";" + cbPresidente.Items[cbPresidente.SelectedIndex].ToString() + ";" + cbSecretario.Items[cbSecretario.SelectedIndex].ToString() + ";" + cbTesorero.Items[cbTesorero.SelectedIndex].ToString());
                txt.WriteLine(txtDNI.Text + ";" + lblVotante.Text + ";" + cbPresidente.Text + ";" + cbSecretario.Text + ";" + cbTesorero.Text);
                txt.Close();

                MessageBox.Show("Su voto fue registrado con exito", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbPresidente.SelectedIndex = -1;
                cbSecretario.SelectedIndex = -1;
                cbTesorero.SelectedIndex = -1;
                cbPresidente.Enabled = false;
                cbSecretario.Enabled = false;
                cbTesorero.Enabled = false;
                txtDNI.Clear();
                lblVotante.Text = "------------";
                txtDNI.Focus();
            }
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")

            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivo.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    //Estado.Text = "Ejecutando Dispositivo…";
                    btnIniciar.Text = "Capturar";
                    cbxDispositivo.Enabled = false;
                }
                else
                {
                    //Estado.Text = "No Hay Camaras Conectadas";
                    picCam.Image = MONITOREO_AGRICOLA_PROYECT.Properties.Resources.Imagen11;
                }
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    //Estado.Text = "Dispositivo Detenido…";
                    btnIniciar.Text = "Iniciar";
                    cbxDispositivo.Enabled = true;
                }
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
