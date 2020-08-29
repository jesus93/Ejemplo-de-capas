using DAL_NET;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinnesLogic
    {

        /// <summary>
        /// Obtiene los adultos 
        /// </summary>
        /// <returns></returns>
        public List<Alumno> GetAdults()
        {
            DAL _datos = new DAL();
            List<Alumno> allStudents = _datos.GetAllStudents().ToList();
            List<Alumno> adults = new List<Alumno>();

            #region 1er Método
            //for(var i = 0; i<allStudents.Count; i++)
            //{
            //    Alumno student = allStudents[i];
            //    if (student.EsAdulto)
            //    {
            //        adults.Add(student);
            //    }

            //}

            #endregion

            #region 2do Método
            //Uso de Linq, sitaxis Method
            //return allStudents.Where(i => i.EsAdulto).ToList();


            #endregion

            #region 3er método

            //Uso de Linq, sitaxis 
            var resultado = from estudiantes in allStudents
                            where estudiantes.EsAdulto
                            select estudiantes;

            return resultado.ToList();
            #endregion

        }
    }
}
