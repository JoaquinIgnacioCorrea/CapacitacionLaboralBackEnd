# Capacitacion BackEnd CDA

Repositorio con ejercicios practicos de desarrollo backend en C# y SQL.

## Ejercicios

### 1. Programacion orientada a objetos

Gestion de una biblioteca: carga libros desde un archivo JSON, registra prestamos y devoluciones, lista los libros disponibles y consulta los libros prestados por un estudiante.

[Ver Ejercicio POO](./01-EjercicioPoo/)

### 2. JSON

Practica de lectura y deserializacion de archivos JSON. Incluye ejercicios sobre personas, usuarios y amigos, estadisticas de partidas y productos con detalles, dimensiones y etiquetas.

[Ver Ejercicio JSON](./02-EjercicioJson/)

### 3. SQL

Consultas SQL sobre peliculas, directores, actores y productoras. Se buscan registros incompletos y se generan agrupaciones y ordenamientos segun recaudacion y periodo de estreno.

[Ver Ejercicio SQL](./03-EjercicioSql/consultas-peliculas.sql)

### 4. Archivos y ADO.NET

Lee usuarios desde un archivo de texto, transforma sus datos en objetos, los inserta en SQL Server, consulta los registros y finalmente limpia la tabla.

[Ver Ejercicio File ADO](./04-EjercicioFileAdo/)

### 5. Ejercicio integrador

Procesa un archivo de ventas de formato fijo, valida sus datos, guarda ventas y rechazos mediante Entity Framework Core y SQL Server, y consulta resultados segun importe, tipo de empresa y rechazos.

[Ver Ejercicio Integrador](./05-EjercicioIntegrador/)

## Acceso rapido

- [Solucion POO](./01-EjercicioPoo/EjercicioPoo/)
- [Solucion JSON](./02-EjercicioJson/PracticaJson/)
- [Consultas SQL](./03-EjercicioSql/consultas-peliculas.sql)
- [Solucion File ADO](./04-EjercicioFileAdo/Clase6/)
- [Solucion Integrador](./05-EjercicioIntegrador/EjercicioIntegrador/)

## Requisitos generales

- .NET 6.0 SDK.
- SQL Server para los ejercicios File ADO e Integrador.
- Base de datos y tablas configuradas segun cada ejercicio.

## Configuracion

Los archivos de datos se copian automaticamente al directorio de salida de sus respectivos proyectos, por lo que ya no dependen de una ruta especifica de Windows ni de la carpeta donde se clone el repositorio.

Los ejercicios File ADO e Integrador requieren una instancia local de SQL Server y la base de datos `PruebasCapacitacion` con sus tablas. Por defecto utilizan `localhost` y autenticacion integrada de Windows. Si la configuracion local es diferente, se puede indicar otra cadena de conexion mediante la variable de entorno `CAPACITACION_SQL_CONNECTION` antes de ejecutar el proyecto.

> Nota: SQL Server, la base de datos y sus tablas no pueden incluirse en este repositorio. Deben crearse previamente en el entorno donde se ejecuten los ejercicios que trabajan con base de datos.
