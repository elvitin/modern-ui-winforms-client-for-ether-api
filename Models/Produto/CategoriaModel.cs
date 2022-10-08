namespace AppEngSoft.Models.Produto
{
  internal class CategoriaModel
  {
    public int Id { get; set; }
    public string Nome { get; set; }

    public CategoriaModel(int id, string nome)
    {
      Id = id;
      Nome = nome;
    }

    public CategoriaModel()
    {

    }
  }
}
