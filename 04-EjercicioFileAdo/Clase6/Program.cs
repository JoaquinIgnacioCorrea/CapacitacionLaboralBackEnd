using Microsoft.Data.SqlClient;
using System.Text.Json;

namespace Clase6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convierte cada registro delimitado del archivo en un objeto de usuario.
            string DireccionArchivo = Path.Combine(AppContext.BaseDirectory, "usuarios-delimitados.txt");
            List<UsuarioPracticaJC> ListaUsuariosEscritura = new List<UsuarioPracticaJC>();
            string[] ListaUsuarios = File.ReadAllLines(DireccionArchivo);
            
            foreach(var Usuario in ListaUsuarios)
            {
                string[] DatosUsuarios = Usuario.Split(';');
                UsuarioPracticaJC NuevoUsuario = new UsuarioPracticaJC(DatosUsuarios[0].ToLower().Trim(), DatosUsuarios[1].ToLower().Trim(), DatosUsuarios[2].ToLower().Trim());
                ListaUsuariosEscritura.Add(NuevoUsuario);
            }

            // Usa la conexion configurada por el entorno o una configuracion local predeterminada.
            string ConexionBddString = Environment.GetEnvironmentVariable("CAPACITACION_SQL_CONNECTION")
                ?? @"Data Source=localhost;Initial Catalog=PruebasCapacitacion;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection ConexionBdd = new SqlConnection(ConexionBddString);

            ConexionBdd.Open();
            // Inserta los usuarios procesados en SQL Server.
            SqlCommand UsuariosBaseDatos = ConexionBdd.CreateCommand();
            foreach (var Usuario in ListaUsuariosEscritura)
            {
                try
                {
                    UsuariosBaseDatos.CommandText = $"insert into Usuario(id,nombre,apellido) values('{Usuario.IdUsuario}','{Usuario.Nombre}','{Usuario.Apellido}')";
                    int Columna = UsuariosBaseDatos.ExecuteNonQuery();
                    if (Columna > 0) Console.WriteLine($"Se agrego usuario {Usuario.Nombre} con exito");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar los usuarios.");
                }
            }

            // Lee los usuarios almacenados y los transforma nuevamente en objetos.
            SqlCommand UsuariosBaseDatosLec = ConexionBdd.CreateCommand();
            UsuariosBaseDatosLec.CommandText = @"select *  from Usuario";
            using (SqlDataReader LectorUsuarios = UsuariosBaseDatosLec.ExecuteReader())
            {
                List<UsuarioPracticaJC> ListaUsuariosLectura = new List<UsuarioPracticaJC>();

                while (LectorUsuarios.Read())
                {
                    UsuarioPracticaJC NuevoUsuario = new UsuarioPracticaJC(LectorUsuarios["id"].ToString(), LectorUsuarios["nombre"].ToString(), LectorUsuarios["apellido"].ToString());
                    ListaUsuariosLectura.Add(NuevoUsuario);
                    Console.WriteLine($"Usuario: {NuevoUsuario.IdUsuario} {NuevoUsuario.Nombre} {NuevoUsuario.Apellido}");
                }
            }

            UsuariosBaseDatos.CommandText = $"truncate table usuario";
            int ColumnaT = UsuariosBaseDatos.ExecuteNonQuery();
            if (ColumnaT == -1) Console.WriteLine($"Se reseteo tabla con exito");

            ConexionBdd.Close();
        }
    }
}