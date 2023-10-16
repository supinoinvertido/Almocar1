using AlmoCar.Models;

namespace AlmoCar.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        
            public IEnumerable<Categoria> Categorias { get; }
        }
    }
