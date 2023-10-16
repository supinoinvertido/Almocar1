using AlmoCar.Context;
using AlmoCar.Models;
using AlmoCar.Repositories.Interfaces;

namespace AlmoCar.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}