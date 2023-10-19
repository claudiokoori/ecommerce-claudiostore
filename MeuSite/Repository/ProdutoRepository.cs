using MeuSite.Context;
using MeuSite.Models;

namespace MeuSite.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Produto BuscarPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public Produto Comprar(int id)
        {
            var conteudo = _context.Produtos.FirstOrDefault(op => op.Id == id);
            if(conteudo != null && conteudo.QuantidadeEmEstoque >= 0)
            {
                conteudo.QuantidadeEmEstoque -= 1;
                _context.SaveChanges();
            }
            
            return conteudo;
        }

        public List<Produto> PegarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}
