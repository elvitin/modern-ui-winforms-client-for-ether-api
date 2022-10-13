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
      ProdutoControl produtoControl = new();
      produtoModel.Id = 0;
      string produtoSerializado = JsonConvert.SerializeObject(
        produtoModel,
        Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
      );
      bool operacao = produtoControl.Salvar(produtoSerializado);
      if (!operacao)
        throw new Exception("(Adição Produto)\nErro no banco, não especificado pela API.");
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
      ProdutoControl produtoControl = new();

      string produtoStringify = JsonConvert.SerializeObject(
        produtoModel,
        Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
      );

      bool operacao = produtoControl.Salvar(produtoStringify);
      if (!operacao)
        throw new Exception("(Edição)\nErro no banco ao editar produto, não especificado pela API.");
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
