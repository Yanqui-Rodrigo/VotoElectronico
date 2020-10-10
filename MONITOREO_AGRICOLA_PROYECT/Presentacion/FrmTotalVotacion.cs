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

namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    public partial class FrmTotalVotacion : Form
    {
        public FrmTotalVotacion()
        {
            InitializeComponent();
        }
        List<ClsCandidatos> listacandidatos = new List<ClsCandidatos>();
        string linea;
        private void FrmTotalVotaciones_Load(object sender, EventArgs e)
        {
            int cont_pre = 0;
            int cont_secre = 0;
            int cont_teso = 0;

            StreamReader candidatos = new StreamReader(@"Candidatos.txt");
            do
            {
                linea = candidatos.ReadLine();
                if (linea != null || linea == "")
                {
                    string[] datos = linea.Split(';');
                    if (datos[1].Equals("Presidente"))
                    {
                        dgvPresidente.Rows.Add(datos[2].ToUpper() + " " + datos[3].ToUpper());
                        cont_pre++;
                    }
                    else if (datos[1].Equals("Secretario"))
                    {
                        dgvSecretario.Rows.Add(datos[2].ToUpper() + " " + datos[3].ToUpper());
                        cont_secre++;
                    }
                    else if (datos[1].Equals("Tesorero"))
                    {
                        dgvTesorero.Rows.Add(datos[2].ToUpper() + " " + datos[3].ToUpper());
                        cont_teso++;
                    }
                }
            } while (linea != null);
            candidatos.Close();


            
            
            
            foreach (DataGridViewRow fila in dgvPresidente.Rows)
            {
                cont_pre = 0;
                StreamReader leer = new StreamReader(@"votos realizados.txt");
                linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] datos_fichero = linea.Split(';');
                    if (fila.Cells[0].Value.Equals(datos_fichero[2]))
                    {
                        cont_pre++;
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                fila.Cells[1].Value = cont_pre.ToString();
            }


            foreach (DataGridViewRow fila in dgvSecretario.Rows)
            {
                cont_secre = 0;
                StreamReader leer = new StreamReader(@"votos realizados.txt");
                linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] datos_fichero = linea.Split(';');
                    if (fila.Cells[0].Value.Equals(datos_fichero[3]))
                    {
                        cont_secre++;
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                fila.Cells[1].Value = cont_secre.ToString();
            }


            foreach (DataGridViewRow fila in dgvTesorero.Rows)
            {
                cont_teso = 0;
                StreamReader leer = new StreamReader(@"votos realizados.txt");
                linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] datos_fichero = linea.Split(';');
                    if (fila.Cells[0].Value.Equals(datos_fichero[4]))
                    {
                        cont_teso++;
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                fila.Cells[1].Value = cont_teso.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal form = new FrmMenuPrincipal();
            form.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
