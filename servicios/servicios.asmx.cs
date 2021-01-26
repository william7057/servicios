using servicios.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace servicios
{
    /// <summary>
    /// Descripción breve de servicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class servicios : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod(Description ="Saludo a la Persona")]
        public string saludar(string nombre)
        {
            return "Hola :"+nombre;
        }
        [WebMethod(Description = "Suma de dos numeros")]
        public string sumar(int numero01, int numero02)
        {
            int resultado = 0;
            resultado = numero01 + numero02;
            return "La suma es :" + resultado;
        }
        [WebMethod(Description = "Aumentar el valor del Numero")]
        public string aumentar(int numero)
        {
            int resultado = 0;
            resultado = numero + 10;
            return "El numero Aumento en :" + resultado;
        }
        [WebMethod(Description = "Creacion de Log")]
        public string GuardarLog(string mensaje)
        {
            Funciones.logs("LogServicios", mensaje);
            return "ok";
        }
        [WebMethod]
        public int Sumar3N(int num_01,int num_02, int num_03)
        {
            int suma = num_01 + num_02 + num_03;
            return suma;
        }
        [WebMethod]
        public string[] ObtenerFrutas()
        {
            string[] frutas = { "fresa", "limon", "Melon" };
            return frutas;
        }

        [WebMethod]
        public string GuardarFrutas(string[] frutas)
        {
            foreach (var fruta in frutas)
            {
                Funciones.logs("Frutas", fruta);
            }

            
            return "Realizado con Exito";
        }
        [WebMethod]
        public List<Equipos> ObtenerEquipos()
        {
            var equipos = new List<Equipos>();

            equipos.Add(new Equipos { nombre = "Milan", pais = "Italia" });
            equipos.Add(new Equipos { nombre = "Alianza", pais = "Pais" });
            equipos.Add(new Equipos { nombre = "Ajax", pais = "Holanda" });
            return equipos;
        }
        [WebMethod]
        public string GuardarEquipos( Equipos[] equipos)
        {
            foreach (var equipo in equipos)
            {
                Funciones.logs("Equipos", equipo.nombre + " -" + equipo.pais);
            }

            return "Realizado con Exito";
        }
    }
}
