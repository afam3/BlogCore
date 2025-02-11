using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Accesodatos.Data.Repositorio.IRepositorio
{
    public interface IContenedorTrabajo : IDisposable
    {
        //aqui se deben ir agregando los diferentes repositorios
        ICategoriaRepositorio Categoria{ get; }

        //metodo para guardar cambios 
        void Save();
    }
}
