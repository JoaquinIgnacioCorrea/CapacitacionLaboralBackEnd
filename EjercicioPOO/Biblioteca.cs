using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    class Biblioteca
    {
        public List<Libro> ListaLibros { get; set; }

        public Biblioteca()
        {
            ListaLibros = new List<Libro>();
        }

        public void PrestarLibro(string libro, string estudiante)
        {
            Libro LibroEncontrado = ListaLibros.Find(LibroBuscado => LibroBuscado.Titulo == libro);

            if(LibroEncontrado.Prestado == false) 
            {
                Console.WriteLine($"Libro {LibroEncontrado.Titulo} prestado a {estudiante}.");
                LibroEncontrado.Prestado = true; 
            }
            else Console.WriteLine("El libro seleccionado no esta disponible.");
        }

        public void DevolverLibro(string libro, string estudiante)
        {
            Libro LibroEncontrado = ListaLibros.Find(LibroBuscado => LibroBuscado.Titulo == libro);

            if (LibroEncontrado.Prestado == true)
            {
                Console.WriteLine($"Libro {LibroEncontrado.Titulo} devueldo del estudiante {estudiante}.");
                LibroEncontrado.Prestado = false;
            }
            else Console.WriteLine("El libro esta disponible, no puede devolverse.");
        }

        public void ListarLibros()
        {
            Console.WriteLine("Libros Disponibles:\n");
            foreach (var libro in ListaLibros)
            {
                if(libro.Prestado == false) Console.WriteLine($"Libro: {libro.Titulo}\nAutor: {libro.Autor}\nDescripcion: {libro.Descripcion}\n\n");
            }
            Console.WriteLine("Libros Prestados:\n");
            foreach (var libro in ListaLibros)
            {
                if (libro.Prestado == true) Console.WriteLine($"Libro: {libro.Titulo}\nAutor: {libro.Autor}\nDescripcion: {libro.Descripcion}\n\n");
            }
        }

        public void ListarLibrosPrestadosAlumno(string alumno)
        {
            StringBuilder ListadoLibrosPrestados = new StringBuilder();
            var cant = ListaLibros.Count(libro => libro.Prestado == true);
            foreach(var libros in ListaLibros)
            {
                if(libros.Prestado == true)
                {
                    ListadoLibrosPrestados.Append($"Titulo: {libros.Titulo}\nAutor: {libros.Autor}\nDescripcion: {libros.Descripcion}\n\n");
                }
            }
            Console.WriteLine($"El estudiante {alumno} tiene {cant} libros prestados:\n{ListadoLibrosPrestados}");
        }

        public void AgregarLibro(Libro libroAdd)
        {
            ListaLibros.Add(libroAdd);
        }
    }
}
