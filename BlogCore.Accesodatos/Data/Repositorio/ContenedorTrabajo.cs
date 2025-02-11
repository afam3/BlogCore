using BlogCore.Accesodatos.Data.Repositorio.IRepositorio;
using BlogCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Accesodatos.Data.Repositorio
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Categoria = new CategoriaRepositorio(_db);
            //aqui se agrega articulos, slider

        }

        //se debe duplicar esta linea en relación como se agrega la linea comentada anterior
        public ICategoriaRepositorio Categoria {get ; private set;}

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
