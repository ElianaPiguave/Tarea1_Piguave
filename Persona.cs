using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Piguave
{
    class Persona
    {
        private int identificacion;
        private string nombres;
        private string apellido;
        private string fecha_nacimiento;
        private string genero;
        private string tipo_sangre;

        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Tipo_sangre { get => tipo_sangre; set => tipo_sangre = value; }
    }
}
