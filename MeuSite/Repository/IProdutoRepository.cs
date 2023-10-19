using MeuSite.Models;

namespace MeuSite.Repository
{
    public interface IProdutoRepository
    {
        List<Produto> PegarTodos();
        Produto BuscarPorId(int id);
        Produto Comprar(int id);
    }
}
