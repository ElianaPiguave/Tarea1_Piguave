using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Piguave
{
    class Contrato : Persona

    {
        private double sueldo;
        string fecha_contrato;

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string Fecha_contrato { get => fecha_contrato; set => fecha_contrato = value; }
    }
}
