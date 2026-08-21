using PracticaJson.Resolucion_Act_Joaquin_Correa;
using PracticaJson.Solutions.Ejercicio_3;
using System.Text.Json;

namespace PracticaJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Carga del directorio de los JSON
            string pathEjercicioUno = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio1.json");
            string pathEjercicioDos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio2.json");
            string pathEjercicioTres = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio3.json");
            string pathEjercicioCuatro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio4.json");
            #endregion

            string ejercicio1 = File.ReadAllText(pathEjercicioUno);

            string ejercicio2 = File.ReadAllText(pathEjercicioDos);

            string ejercicio3 = File.ReadAllText(pathEjercicioTres);

            string ejercicio4 = File.ReadAllText(pathEjercicioCuatro);

            #region Sensibilidad de mayusculas-minusculas variables
            var normalizacionVariables = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            #endregion

            //Ejercicio 1
            Persona EjercicioEj1 = JsonSerializer.Deserialize<Persona>(ejercicio1, normalizacionVariables);
            Console.WriteLine($"Nombre: {EjercicioEj1.Nombre}\nEdad: {EjercicioEj1.Edad}\nPais: {EjercicioEj1.Pais}\nActivo: {EjercicioEj1.Activo}.");

            //Ejercicio 2
            Usuarios EjercicioEj2 = JsonSerializer.Deserialize<Usuarios>(ejercicio2, normalizacionVariables);
            Console.WriteLine($"Usuario: {EjercicioEj2.Usuario}\nAmigos del Usuario: {EjercicioEj2.MostrarAmigos()}\nNotificaciones del Usuario: {EjercicioEj2.NotificacionesUsuario}");

            //Ejercicio 3
            PartidaEst EjercicioEj3 = JsonSerializer.Deserialize<PartidaEst>(ejercicio3, normalizacionVariables);
            foreach (var Estadistica in EjercicioEj3.Estadisticas)
            {
                Console.WriteLine($"Equipo: {Estadistica.Equipo}\nCampeon: {Estadistica.Campeon}\nJugadores:\n");
                foreach (var Jugador in Estadistica.Jugadores)
                {
                    Console.WriteLine($"\tNombre: {Jugador.Nombre}\n\tKills: {Jugador.Kills}\n\tDeath: {Jugador.Death}\n\n");
                }
            }

            //Ejercicio 4
            ProductosLista EjercicioEj4 = JsonSerializer.Deserialize<ProductosLista>(ejercicio4, normalizacionVariables);
            foreach (var productos in EjercicioEj4.Productos)
            {
                Console.WriteLine($"Nombre:{productos.Nombre}\nPrecio:{productos.Precio}\nExistencias:{productos.Existencias}\nDescuento disponible:{productos.DescuentoDisponible}\nEtiquetas:");

                foreach (var etiquetasc in productos.Etiquetas)
                {
                    Console.WriteLine($"\t{etiquetasc}");
                }
                Console.WriteLine($"Detalles:\n\tPeso:{productos.Detalles.Peso}\n\tDimensiones:\n\t\tAlto:{productos.Detalles.Dimensiones.Alto}\n\t\tAncho:{productos.Detalles.Dimensiones.Ancho}\n\t\tProfundidad:{productos.Detalles.Dimensiones.Profundidad}\n");
            }

        }
    }
}