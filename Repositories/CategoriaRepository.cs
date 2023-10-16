using nihongo2.Context;
using nihongo2.Models;
using nihongo2.Repositories.Interfaces;

namespace nihongo2.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context){
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}