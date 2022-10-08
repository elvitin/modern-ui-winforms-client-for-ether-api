namespace AppEngSoft.Models.Vendedor
{
  internal interface IVendedorRepositorio
  {
    void Adicionar(VendedorModel clienteModel);
    void Editar(VendedorModel clienteModel);
    void Deletar(uint vendedorId);
    IEnumerable<VendedorModel> ObterTodos();
    IEnumerable<VendedorModel> ObterPorValor(string valor);
  }
}
