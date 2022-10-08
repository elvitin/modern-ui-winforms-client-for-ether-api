using AppEngSoft.Models.Cliente;
using AppEngSoft.Models.Produto;
using EtherAPI.Control;
using Newtonsoft.Json;

namespace AppEngSoft.Repositorios.Produto
{
  internal class ProdutoRepositorio : RepositorioBase, IProdutoRepositorio
  {

    public ProdutoRepositorio(string stringConexao)
    {
      base.stringConexao = stringConexao;
    }

    public void Adicionar(ProdutoModel produtoModel)
    {
      throw new NotImplementedException();
    }

    public void Deletar(uint id)
    {
      ProdutoControl produtoControl = new();
      bool operacao = produtoControl.Excluir(checked((int)id));

      if (!operacao)
        throw new Exception(
          $@"Falha ao deletar produto id {id}
                     Erro no banco, não especificado pela API");
    }

    public void Editar(ProdutoModel produtoModel)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ProdutoModel> ObterPorValor(string valor)
    {
      ProdutoControl produtoControl = new();
      string produtosJson = produtoControl.ObterPorValor(valor);
      List<ProdutoModel> produtos = JsonConvert.DeserializeObject<List<ProdutoModel>>(produtosJson);
      return produtos;
    }

    public IEnumerable<ProdutoModel> ObterTodos()
    {
      ProdutoControl produtoControl = new();
      string produtosJson = produtoControl.ObterTodos();
      List<ProdutoModel> produtos = JsonConvert.DeserializeObject<List<ProdutoModel>>(produtosJson);
      return produtos;
    }
  }
}
