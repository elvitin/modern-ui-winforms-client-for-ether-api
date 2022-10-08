namespace AppEngSoft.Models.Produto
{
  internal class UnidadeModel
  {
    public uint Id { get; set; }
    public string Nome { get; set; }

    public UnidadeModel(uint id, string nome)
    {
      Id = id;
      Nome = nome;
    }

    public UnidadeModel()
    {

    }
  }
}
