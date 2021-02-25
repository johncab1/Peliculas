using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> obtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula() { Titulo = "Spiderman", Lanzamiento = new DateTime(2019, 7, 2) },
                new Pelicula() {Titulo = "Moon", Lanzamiento = new DateTime(2016, 11, 3)},
                new Pelicula() {Titulo = "Inception", Lanzamiento = new DateTime(2010, 7, 6)}
            };
        }
    }
}
