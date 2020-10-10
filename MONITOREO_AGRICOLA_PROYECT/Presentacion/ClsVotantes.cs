using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    class ClsVotantes
    {
        string dni;
        string nombre;
        string apellido;
        string edad;
        string imagen;
        private static int ingreso;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public static int Ingreso { get => ingreso; set => ingreso = value; }
    }
}
