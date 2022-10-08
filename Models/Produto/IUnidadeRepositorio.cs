namespace AppEngSoft.Models.Produto
{
  internal interface IUnidadeRepositorio
  {
    void Adicionar(UnidadeModel unidadeModel);
    void Editar(UnidadeModel unidadeModel);
    void Deletar(uint unidadeId);
    IEnumerable<UnidadeModel> ObterTodos();
    IEnumerable<UnidadeModel> ObterPorValor(string valor);
  }
}
