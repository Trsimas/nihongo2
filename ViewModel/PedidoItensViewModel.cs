using nihongo2.Models;

namespace nihongo2.ViewModel
{
    public class PedidoItensViewModel
    {
        public Pedido Pedidos { get; set; }
        public IEnumerable<PedidoItem> PedidoItens { get; set; }
    }
}