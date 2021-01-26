using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoServicio
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceReference2.serviciosSoapClient cliente = new ServiceReference2.serviciosSoapClient();
            //string result = cliente.saludar("William");
            //string result = cliente.GuardarLog("William");
            //int result = cliente.Sumar3N(3,5,3);
            //string[] frutas = cliente.ObtenerFrutas().ToArray();

            //foreach (var fruta in frutas)
            //{
            //  Console.WriteLine(fruta);
            // }
            //string[] frutas =  { "aaa", "sss", "asdfasdf" };
            //string result = cliente.GuardarFrutas(frutas);

            ServiceReference2.Equipos[] equipos = cliente.ObtenerEquipos();

            foreach (var equipo in equipos)
            {
                Console.WriteLine(equipo.nombre + " - "+equipo.pais);
            }

            
            Console.ReadKey();


        }
    }
}
