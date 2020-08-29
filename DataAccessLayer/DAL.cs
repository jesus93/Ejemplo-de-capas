using DAL_NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Clase que se conecta a base de datos 
    /// </summary>
    public class DAL
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Alumno GetStudentByName(string nombre)
        {
            return new Alumno()
            {
                Nombre = "Moy",
                Appellidos = "Arenas",
                Edad = 21,
                EsAdulto = true
            };
        }

        /// <summary>
        /// Interfaz es como un contrato, dice que quiere pero no como
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Alumno> GetAllStudents()
        {
            List<Alumno> alumnos = new List<Alumno>()
            {
                new Alumno()
                {
                    Nombre = "Beto",
                    Appellidos = "Cortez",
                    Edad = 23,
                    EsAdulto = true
                },
                new Alumno()
                {
                    Nombre = "Moy",
                    Appellidos = "Arenas",
                    Edad = 21,
                    EsAdulto = true
                },
                new Alumno()
                {
                    Nombre = "Alexis",
                    Appellidos = "No sé"
                },
                    new Alumno()
                    {
                        Nombre = "Rufo",
                        Appellidos = "Arenas "
                    }
                };

            return alumnos;
        }


    }
}
