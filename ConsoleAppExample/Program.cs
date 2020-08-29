using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinnesLogic busines = new BusinnesLogic();
            var adults = busines.GetAdults();


            string respuesta = "Los adultos son: {0}";
            Console.WriteLine(string.Format(respuesta, adults.Count));

            adults.ForEach(item => {
                Console.WriteLine($"Nombre {item.Nombre} , Apellidos: {item.Appellidos}, Edad: {item.Edad}");
            });

             var tecla = Console.ReadKey();
            var response = true;
        }

       
    }
}
