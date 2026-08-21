using System.ComponentModel.Design;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EjercicioPoo
{
    internal class Program
    {
        static void Main()
        {
            #region Carga de datos
            string data = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"data.json"));

            #endregion
            #region Normalizacion de Variables
            var normalizacionVariables = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            #endregion

            //Gestionar los prestamos de libros de una biblioteca
            // se debe poder prestar libros a estudiantes: 
            //  *  solo hay una copia por libro y hay que verificar a la hora de prestarlo si lo tenemos disponible o no
            // Se debe poder devolver libros 
            // Se debe poder listar todos los libros y los que se prestaron
            // Se debe poder consultar los libros que tiene prestado un estudiante en particular

            List<Libro> ColeccionLibros = JsonSerializer.Deserialize<List<Libro>>(data,normalizacionVariables);
            Biblioteca BibliotecaEj = new Biblioteca();
            foreach (var Libros in ColeccionLibros) BibliotecaEj.AgregarLibro(Libros);

            BibliotecaEj.PrestarLibro("Cien años de soledad", "Joaquin");
            BibliotecaEj.PrestarLibro("1984", "Joaquin");
            BibliotecaEj.DevolverLibro("Harry Potter y la piedra filosofal", "Joaquin");
            BibliotecaEj.DevolverLibro("Crónica de una muerte anunciada", "Joaquin");
            BibliotecaEj.ListarLibros();
            BibliotecaEj.ListarLibrosPrestadosAlumno("Joaquin");



        Console.ReadKey();
        }

    }
}