namespace AppEngSoft.Models.Cliente
{
  internal interface IClienteRepositorio
  {
    void Adicionar(ClienteModel clienteModel);
    void Editar(ClienteModel clienteModel);
    void Deletar(uint clienteId);
    IEnumerable<ClienteModel> ObterTodos();
    IEnumerable<ClienteModel> ObterPorValor(string valor);
  }
}
