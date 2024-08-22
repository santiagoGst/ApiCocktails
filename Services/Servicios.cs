using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCocktails.Models;
using MongoDB.Driver;

namespace ApiCocktails.Services
{
    public class Servicios : IServicios
    {
        MongoClient cliente;
        IMongoDatabase db;
        IMongoCollection<Usuario> user;
        IMongoCollection<Cocktel> cocteles;
        IMongoCollection<Bar> bares;
        IMongoCollection<CategoriaCocktel> categoriasCockteles;
        IMongoCollection<Vidrio> vidrios;

        public Servicios()
        {
            cliente = new MongoClient("mongodb+srv://Agust:A.gus2701@agustcluster.v0jia6t.mongodb.net/db_cocteles");
            db = cliente.GetDatabase("db_cocteles");
            user = db.GetCollection<Usuario>("Usuarios");
            cocteles = db.GetCollection<Cocktel>("Cocteles");
            bares = db.GetCollection<Bar>("Bares");
            categoriasCockteles = db.GetCollection<CategoriaCocktel>("CategoriasCockteles");
            vidrios = db.GetCollection<Vidrio>("Vidrio");
        }


        // -------------------------------------------  Inicio  -------------------------------------------
        public Usuario ValidarUsuario(Usuario u)
        {
            Usuario usuario = user.Find(x => x.NombreUsuario == u.NombreUsuario && x.Pwd == u.Pwd).FirstOrDefault();
            return usuario;
        }

        public bool RegistrarUsuario(Usuario u)
        {
            bool resultado = false;
            try
            {
                user.InsertOne(u);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }


        // -------------------------------------------  Cocktel  -------------------------------------------
        public bool ActualizarCocktel(Cocktel c)
        {
            bool resultado = false;
            try
            {
                cocteles.ReplaceOne(ant => ant.Id == c.Id, c);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public bool EliminarCocktel(string Id)
        {
            bool resultado = false;
            try
            {
                cocteles.DeleteOne(ant => ant.Id == Id);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public bool InsertarCocktel(Cocktel c)
        {
            bool resultado = false;
            try
            {
                cocteles.InsertOne(c);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public List<Cocktel> ObtenerCockteles()
        {
            List<Cocktel> listaCockteles = cocteles.Find(f => true).ToList();
            return listaCockteles;
        }

        public Cocktel ObtenerCocktel(string Id)
        {
            Cocktel cocktel = cocteles.Find(x => x.Id == Id).FirstOrDefault();
            return cocktel;
        }



        // -------------------------------------------  Bar  -------------------------------------------
        public bool ActualizarBar(Bar b)
        {
            bool resultado = false;
            try
            {
                bares.ReplaceOne(ant => ant.Id == b.Id, b);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public bool EliminarBar(string Id)
        {
            bool resultado = false;
            try
            {
                bares.DeleteOne(ant => ant.Id == Id);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public bool InsertarBar(Bar b)
        {
            bool resultado = false;
            try
            {
                bares.InsertOne(b);
                resultado = true;
            }
            catch (System.Exception)
            {
                throw;
            }
            return resultado;
        }

        public List<Bar> ObtenerBares()
        {
            List<Bar> listaBares = bares.Find(f => true).ToList();
            return listaBares;
        }

        public Bar ObtenerBar(string Id)
        {
            Bar bar = bares.Find(x => x.Id == Id).FirstOrDefault();
            return bar;
        }



        // -------------------------------------------  Categoria Cocktel  -------------------------------------------
        public List<CategoriaCocktel> ObtenerCategoriasCockteles()
        {
            List<CategoriaCocktel> listaCategoriasCockteles = categoriasCockteles.Find(f => true).ToList();
            return listaCategoriasCockteles;
        }
        
        
        // -------------------------------------------  Vidrio Cocktel  -------------------------------------------
        public List<Vidrio> ObtenerVidrios()
        {
            List<Vidrio> listaVidrios = vidrios.Find(f => true).ToList();
            return listaVidrios;
        }



    }
}