using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONITOREO_AGRICOLA_PROYECT.Presentacion
{
    class ClsCandidatos
    {
        string codigo;
        string cargo;
        string nombre;
        string apellido;
        string edad;
        string sexo;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
