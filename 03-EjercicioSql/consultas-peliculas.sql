/* Consultas de integridad y analisis sobre peliculas, actores y productoras. */
/* 1. Peliculas sin director asociado. */
/* 2. Peliculas sin productora asociada. */
/* 3. Peliculas sin actuaciones registradas. */
/* 4. Actores sin papeles registrados. */
/* 5. Cantidad y recaudacion por productora para peliculas exitosas. */
/* 6. Directores ordenados por la mayor recaudacion obtenida. */
/* 7. Directores con mayor recaudacion durante la decada de 1980. */

/*1. listar peliculas sin director */
select *
from Peliculas
where id_director is null

/*2. listar peliculas sin productora */
select *
from Peliculas
where id_productora is null

/*3. listar peliculas sin actores */
select  *
from Peliculas
 left join Actuaciones ON Actuaciones.id_pelicula = Peliculas.id_pelicula
 left join Actores ON Actores.id_actor = Actuaciones.id_actor
 where Actores.id_actor is null

/*4. listar actores sin papeles */
select *
from Actores
left join Actuaciones ON Actuaciones.id_actor = Actores.id_actor
where papel is null

/*5. listar cantidad peliculas por productora con recaudacion > $100.000.000 */
select Productoras.nombre Nombre, count(*) CantidadPeliculas, format(sum(Peliculas.recaudacion),'C0') Recaudacion
from Peliculas
inner join Productoras ON Productoras.id_productora = Peliculas.id_productora
where recaudacion > 100000000
group by Productoras.id_productora, Productoras.nombre

/*6. listar los directores con mayor recaudaci�n */
select Directores.nombre Nombre, format(MAX(recaudacion),'C0') Recaudacion
from Directores
inner join Peliculas on Peliculas.id_director = Directores.id_director
group by Peliculas.id_director, Directores.nombre
order by max(Peliculas.recaudacion) desc

/*7. listar los directores con mayor recaudaci�n en los a�os 80*/
select Directores.nombre Nombre, format(MAX(recaudacion),'C0') Recaudacion
from Directores
inner join Peliculas on Peliculas.id_director = Directores.id_director
where Peliculas.a�o_estreno between '1980' and '1989'
group by Peliculas.id_director, Directores.nombre
order by max(Peliculas.recaudacion) desc