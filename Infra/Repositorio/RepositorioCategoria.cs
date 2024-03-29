using Domain.Interfaces.ICategoria;
using Entities.Entidades;
using Infra.Repositorio.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioCategoria: RepositoryGeneric<Categoria>, InterfaceCategoria
    {
        public Task<IList<Categoria>> ListarCategoriasUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
