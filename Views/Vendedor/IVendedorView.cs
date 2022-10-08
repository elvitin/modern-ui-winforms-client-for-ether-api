namespace AppEngSoft.Views.Vendedor
{
  internal interface IVendedorView : IViewPadrao
  {
    //Atributos da model/view
    public string Id { get; set; }
    public string Nome { get; set; }
  }
}
