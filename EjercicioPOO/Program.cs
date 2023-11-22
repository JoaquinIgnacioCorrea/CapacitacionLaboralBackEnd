using System.Text.Json;
using System.Text.Json.Serialization;

namespace EjercicioPoo
{
    internal class Program
    {
        static void Main()
        {
            #region Carga de datos
            string data = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"data.json")   );
                  
            #endregion
            
            //Gestionar los prestamos de libros de una biblioteca
            // se debe poder prestar libros a estudiantes: 
            //  *  solo hay una copia por libro y hay que verificar a la hora de prestarlo si lo tenemos disponible o no
            // Se debe poder devolver libros 
            // Se debe poder listar todos los libros  y los que se prestaron
            // Se debe poder consultar los libros que tiene prestado un estudiante en particular


        }


    }
}