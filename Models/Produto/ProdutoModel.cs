
using System.ComponentModel;

namespace AppEngSoft.Models.Produto
{
  internal class ProdutoModel
  {
    [DisplayName("ID")]
    public uint Id { get; set; }

    [DisplayName("Nome")]
    public string Nome { get; set; }

    [DisplayName("Preço")]
    public decimal Preco { get; set; }

    [DisplayName("Qtde. Estoque")]
    public decimal Estoque { get; set; }

    [Browsable(false)]
    public UnidadeModel Unidade { get; set; }

    [Browsable(false)]
    public List<CategoriaModel> Categorias { get; set; }

    public ProdutoModel()
    {
      Unidade = new UnidadeModel();
    }

    public ProdutoModel(uint id, string nome, decimal preco, decimal estoque, List<CategoriaModel> categoria, UnidadeModel unidade)
    {
      this.Id = id;
      this.Nome = nome;
      this.Preco = preco;
      this.Estoque = estoque;
      this.Unidade = unidade;
      this.Categorias = categoria;
    }
  }
}
