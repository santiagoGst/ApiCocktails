using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCocktails.Models;

namespace ApiCocktails.Services
{
    public interface IServicios
    {
        // -----------------  Inicio  -----------------
        Usuario ValidarUsuario(Usuario u);
        bool RegistrarUsuario(Usuario u);


        // -----------------  Cocktel  -----------------
        bool InsertarCocktel(Cocktel c);
        List<Cocktel> ObtenerCockteles();
        bool ActualizarCocktel(Cocktel c);
        bool EliminarCocktel(string Id);
        Cocktel ObtenerCocktel(string Id);


        // -----------------  Bar  -----------------
        bool InsertarBar(Bar b);
        List<Bar> ObtenerBares();
        
        bool ActualizarBar(Bar b);
        bool EliminarBar(string Id);
        Bar ObtenerBar(string Id);


        // -----------------  Categoria Cocktel  -----------------
        List<CategoriaCocktel> ObtenerCategoriasCockteles();
        
        
        // -----------------  Vidrio Cocktel  -----------------
        List<Vidrio> ObtenerVidrios();
        


    }
}