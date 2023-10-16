using nihongo2.Models;

namespace nihongo2.ViewModel
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Itens{get; set;}
        public string CategoriaAtual{get; set;}
    }
}