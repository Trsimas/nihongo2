using nihongo2.Models;

namespace nihongo2.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias {get;}
    }
}