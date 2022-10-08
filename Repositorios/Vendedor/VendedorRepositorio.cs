using AppEngSoft.Models.Vendedor;
using EtherAPI.Control;
using Newtonsoft.Json;

namespace AppEngSoft.Repositorios.Vendedor
{
  internal class VendedorRepositorio : RepositorioBase, IVendedorRepositorio
  {
    public VendedorRepositorio(string stringConexao)
    {
      base.stringConexao = stringConexao;
    }

    public void Adicionar(VendedorModel vendedorModel)
    {
      VendedorControl vendedorControl = new();
      vendedorModel.Id = 0;
      string vendedorJson = JsonConvert.SerializeObject(
        vendedorModel,
        Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
      );
      bool operacao = vendedorControl.Salvar(vendedorJson);
      if (!operacao)
        throw new Exception("(Adição)\nErro no banco ao adicionar vendedor, não especificado pela API.");
    }

    public void Deletar(uint vendedorId)
    {
      VendedorControl vendedorControl = new();

      bool operacao = vendedorControl.Excluir(checked((int)vendedorId));
      if (!operacao)
        throw new Exception("(Deleção)\nErro no banco ao deletar vendedor, não especificado pela API.");
    }

    public void Editar(VendedorModel vendedorModel)
    {
      VendedorControl vendedorControl = new();

      string vendedorJson = JsonConvert.SerializeObject(
        vendedorModel,
        Formatting.Indented,
        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
      );

      bool operacao = vendedorControl.Salvar(vendedorJson);
      if (!operacao)
        throw new Exception("(Edição)\nErro no banco ao editar vendedor, não especificado pela API.");
    }

    public IEnumerable<VendedorModel> ObterPorValor(string valor)
    {
      VendedorControl vendedorControl = new();
      string vendedoresJson = vendedorControl.ObterPorValor(valor);
      List<VendedorModel> vendedores = JsonConvert.DeserializeObject<List<VendedorModel>>(vendedoresJson);
      return vendedores;
    }

    public IEnumerable<VendedorModel> ObterTodos()
    {
      VendedorControl vendedorControl = new();
      string vendedoresJson = vendedorControl.ObterTodos();
      List<VendedorModel> vendedores = JsonConvert.DeserializeObject<List<VendedorModel>>(vendedoresJson);
      return vendedores;
    }
  }
}
