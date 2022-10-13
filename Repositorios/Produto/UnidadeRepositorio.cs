using AppEngSoft.Models.Produto;
using EtherAPI.Control;
using Newtonsoft.Json;

namespace AppEngSoft.Repositorios.Produto
{
  internal class UnidadeRepositorio : RepositorioBase, IUnidadeRepositorio
  {

    public UnidadeRepositorio(string stringConexao)
    {
      base.stringConexao = stringConexao;
    }

    public void Adicionar(UnidadeModel unidadeModel)
    {
      UnidadeControl unidadeControl = new();
      unidadeModel.Id = 0;
      string unidadeSerializada = JsonConvert.SerializeObject(
        unidadeModel,
        Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
      );
      bool operacao = unidadeControl.Salvar(unidadeSerializada);
      if (!operacao)
        throw new Exception("(Adição Unidade)\nErro no banco, não especificado pela API.");
    }

    public void Deletar(uint unidadeId)
    {
      UnidadeControl unidadeControl = new();
      bool operacao = unidadeControl.Excluir(checked((int)unidadeId));
      if (!operacao)
        throw new Exception(
          $"Falha ao deletar unidade ID {unidadeId}\nErro no banco, não especificado pela API");
    }

    public void Editar(UnidadeModel unidadeModel)
    {
      UnidadeControl unidadeControl = new();
      string unidadeStringify = JsonConvert.SerializeObject(
        unidadeModel,
        Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
      );
      bool operacao = unidadeControl.Salvar(unidadeStringify);
      if (!operacao)
        throw new Exception($"(Edição Unidade)\nErro no banco ao editar unidade ID {unidadeModel.Id}.\nErro não especificado pela API.");
    }

    public IEnumerable<UnidadeModel> ObterPorValor(string valor)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<UnidadeModel> ObterTodos()
    {
      UnidadeControl unidadeControl = new();
      string unidadesJson = unidadeControl.ObterTodos();
      List<UnidadeModel> unidades = JsonConvert.DeserializeObject<List<UnidadeModel>>(unidadesJson);
      return unidades;
    }
  }
}
