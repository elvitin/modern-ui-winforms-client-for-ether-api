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
      throw new NotImplementedException();
    }

    public void Deletar(uint unidadeId)
    {
      throw new NotImplementedException();
    }

    public void Editar(UnidadeModel unidadeModel)
    {
      throw new NotImplementedException();
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
