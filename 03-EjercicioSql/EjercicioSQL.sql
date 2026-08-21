/*Actividades*/
/*1. listar peliculas sin director */
/*2. listar peliculas sin productora */
/*3. listar peliculas sin actores */
/*4. listar actores sin papeles */
/*5. listar cantidad peliculas por productora con recaudacion > $100.000.000 */
/*6. listar los directores con mayor recaudación */
/*7. listar los directores con mayor recaudación en los años 80*/

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

/*6. listar los directores con mayor recaudación */
select Directores.nombre Nombre, format(MAX(recaudacion),'C0') Recaudacion
from Directores
inner join Peliculas on Peliculas.id_director = Directores.id_director
group by Peliculas.id_director, Directores.nombre
order by max(Peliculas.recaudacion) desc

/*7. listar los directores con mayor recaudación en los años 80*/
select Directores.nombre Nombre, format(MAX(recaudacion),'C0') Recaudacion
from Directores
inner join Peliculas on Peliculas.id_director = Directores.id_director
where Peliculas.año_estreno between '1980' and '1989'
group by Peliculas.id_director, Directores.nombre
order by max(Peliculas.recaudacion) desc