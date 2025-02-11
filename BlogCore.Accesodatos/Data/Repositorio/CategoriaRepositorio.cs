using BlogCore.Accesodatos.Data.Repositorio.IRepositorio;
using BlogCore.Data;
using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Accesodatos.Data.Repositorio
{
    public class CategoriaRepositorio : Repositorio<Categoria>, ICategoriaRepositorio
    {

        private readonly ApplicationDbContext _db;

        public CategoriaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria categoria)
        {
            var objDesdeDB = _db.Categorias.FirstOrDefault(s => s.Id == categoria.Id);
            objDesdeDB.Nombre = categoria.Nombre;
            objDesdeDB.Orden = categoria.Orden;

            _db.SaveChanges();
        }
    }
}
