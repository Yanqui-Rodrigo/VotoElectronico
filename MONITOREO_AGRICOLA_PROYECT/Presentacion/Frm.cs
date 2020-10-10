using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    class Frm
    {
        static string codigo;
        static string cargo;
        static string nombre;
        static string apellido;
        static string edad;
        static string sexo;

        public static string Codigo { get => codigo; set => codigo = value; }
        public static string Cargo { get => cargo; set => cargo = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Apellido { get => apellido; set => apellido = value; }
        public static string Edad { get => edad; set => edad = value; }
        public static string Sexo { get => sexo; set => sexo = value; }
    }
}
