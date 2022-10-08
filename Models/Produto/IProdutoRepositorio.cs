using AppEngSoft.Models.Cliente;

namespace AppEngSoft.Models.Produto
{
  internal interface IProdutoRepositorio
  {
    void Adicionar(ProdutoModel produtoModel);
    void Editar(ProdutoModel produtoModel);
    void Deletar(uint id);
    IEnumerable<ProdutoModel> ObterTodos();
    IEnumerable<ProdutoModel> ObterPorValor(string valor);
  }
}
