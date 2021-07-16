using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_Piguave
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar
            Contrato con;
            con = new Contrato();

            Console.WriteLine("---------------------SISTEMA MONETARIO---------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingresar Numero de identificacion");
            con.Identificacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su Nombre");
            con.Nombres = Console.ReadLine();


            Console.WriteLine("Ingresa su Apellidos");
            con.Apellido = Console.ReadLine();


            Console.WriteLine("Ingrese su fecha de nacimiento");
            con.Fecha_nacimiento = Console.ReadLine();


            Console.WriteLine("Ingrese su Genero");
            con.Genero = Console.ReadLine();


            Console.WriteLine("Ingrese su Tipo de sangre");
            con.Tipo_sangre = Console.ReadLine();


            Console.WriteLine("Ingrese su fecha de contrato");
            con.Fecha_contrato = Console.ReadLine();

           

            Console.Write("Ingrese el valor por dia: ");
            double costo= double.Parse(Console.ReadLine());

            Console.Write("Ingrese los dias trabajados: ");
            int dias = int.Parse(Console.ReadLine());


            //imprimir datos
            Console.WriteLine("---------------------Datos del Cliente---------------------");
            Console.WriteLine("Identificacion: " + con.Identificacion);
            Console.WriteLine("Nombre Completo: " + con.Nombres + " " + con.Apellido);
            Console.WriteLine("Genero: " + con.Genero);
            Console.WriteLine("Fecha Nacimiento: " + con.Fecha_nacimiento);
            Console.WriteLine("Tipo de sangre: " + con.Tipo_sangre);
            Console.WriteLine("Fecha Contrato: " + con.Fecha_contrato);
            


            Calcular_Sueldo(dias, costo);

            Console.ReadKey();

        }
        public static void Calcular_Sueldo(int d, double c)
        {
            double costo = c;

            int dia = d;

            double aporte_iess;

            double sueldoi;

            double patronal;

            double sueldotercero;

            double sueldocuarto;

            double sueldofinal;

            costo = d * c;

            Console.WriteLine(" sueldo  es:" + costo + "$");


            aporte_iess = costo * 0.1145;

            Console.WriteLine("Aporte al IESS es:" + aporte_iess + "$");

            sueldoi = costo - aporte_iess;

            Console.WriteLine("Sueldo descontado el Aporte al IESS es:" + sueldoi + "$");

            patronal = costo * 0.0945;

            Console.WriteLine("Aporte Patronal es:" + patronal + "$");

            sueldotercero = costo / 12;

            sueldocuarto = 400 / 12;

            Console.WriteLine("Decimo Tercero es:" + sueldotercero + "$");
            Console.WriteLine("Decimo Cuarto es:" + sueldocuarto + "$");

            sueldofinal = sueldoi - patronal;

            Console.WriteLine("Sueldo Final es:" + sueldofinal + "$");

            Console.ReadKey();
        }



    }
}

