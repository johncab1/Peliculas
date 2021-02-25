﻿

using BlazorPeliculas.Shared.Entidades;
using System.Collections.Generic;

namespace BlazorPeliculas.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Pelicula> obtenerPeliculas();
    }
}
