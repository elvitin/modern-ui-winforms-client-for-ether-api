using AppEngSoft.Models.Produto;
using AppEngSoft.Models.Utils;
using AppEngSoft.Views.Produto;

namespace AppEngSoft.Presenters
{
  internal class ProdutoPresenter
  {
    private IProdutoView view;
    private IProdutoRepositorio repositorio;
    private IUnidadeRepositorio unidadeRepositorio;

    private BindingSource ProdutosBinding;
    private BindingSource UnidadesBinding;

    private IEnumerable<ProdutoModel> produtos;
    private IEnumerable<UnidadeModel> unidades;

    public ProdutoPresenter(IProdutoView view, IProdutoRepositorio repositorio, IUnidadeRepositorio unidadeRepositorio)
    {
      ProdutosBinding = new();
      UnidadesBinding = new();

      this.view = view;
      this.repositorio = repositorio;
      this.unidadeRepositorio = unidadeRepositorio;

      //Assinando eventos
      view.ProcurarEvento += ProcurarProduto;
      view.EditarEvento += CarregarEditarProduto;
      view.CancelarEvento += CancelarOperacao;
      view.DeletarEvento += DeletarProdutoSelecionado;
      view.AdicionarEvento += AdicionarProduto;
      view.SalvarEvento += SalvarProduto;

      //Ligando fonte de dados
      view.LigarFonteDados(ProdutosBinding);
      view.LigarFonteDados_Unidades(UnidadesBinding);

      //Carregando Lista - [ ] Prover Interface para esse método
      AtualizarListaProdutos();
      AtualizarListaUnidades();


      view.Show();
    }

    private void AtualizarListaUnidades()
    {
      unidades = unidadeRepositorio.ObterTodos();
      UnidadesBinding.DataSource = unidades;
    }

    private void AtualizarListaProdutos()
    {
      produtos = repositorio.ObterTodos();
      ProdutosBinding.DataSource = produtos;
    }

    private void SalvarProduto(object? sender, EventArgs e)
    {
      uint id = int.TryParse(view.Id, out _) ? Convert.ToUInt32(view.Id) : 0;

      ProdutoModel produto = new()
      {
        Id = id,
        Nome = view.Nome,
        Estoque = decimal.Parse(view.Estoque),
        Preco = decimal.Parse(view.Preco),
        Unidade = new()
        {
          Id = Convert.ToUInt32(view.ProdutoUnidadeID),
          Nome = view.ProdutoUnidadeNome
        }
      };

      try
      {
        new ModelValidacao().Validar(produto);

        if (view.eEdicao)
        {
          repositorio.Editar(produto);
          view.Mensagem = $"Produto ID {produto.Id}, Editado com sucesso!";
        }
        else
        {
          repositorio.Adicionar(produto);
          view.Mensagem = "Produto salvo com sucesso!";
        }

        view.eSucessoOperacao = true;
        AtualizarListaProdutos();
        LimparCampos();
      }
      catch (Exception ex)
      {
        view.eSucessoOperacao = false;
        view.Mensagem = ex.Message;
      }
    }

    private void LimparCampos()
    {
      view.ValorBusca = "";
      view.Id = "";
      view.Nome = "";
      view.Preco = "";
      view.ProdutoUnidadeID = "";
      view.ProdutoUnidadeNome = "";
    }

    private void AdicionarProduto(object? sender, EventArgs e)
    {
      view.eEdicao = false;
    }

    private void DeletarProdutoSelecionado(object? sender, EventArgs e)
    {
      try
      {
        ProdutoModel produto = (ProdutoModel)ProdutosBinding.Current;
        repositorio.Deletar(produto.Id);
        view.eSucessoOperacao = true;
        view.Mensagem = $"Produto ID {produto.Id} Deletado com sucesso!";
        AtualizarListaProdutos();
      }
      catch (Exception ex)
      {
        view.eSucessoOperacao = true;
        view.Mensagem = ex.Message;
      }
    }

    private void CancelarOperacao(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void CarregarEditarProduto(object? sender, EventArgs e)
    {
      view.eEdicao = true;

      ProdutoModel produto = (ProdutoModel)ProdutosBinding.Current;
      if (produto == null) return;
      view.Id = produto.Id.ToString();
      view.Nome = produto.Nome;
      view.Preco = produto.Preco.ToString();
      view.Estoque = produto.Estoque.ToString();

      ProdutoModel restanteDadosProduto = repositorio.ObterPorValor(produto.Id.ToString()).FirstOrDefault();

      view.ProdutoUnidadeID = restanteDadosProduto.Unidade.Id.ToString();
      view.ProdutoUnidadeNome = restanteDadosProduto.Unidade.Nome;
    }

    private void ProcurarProduto(object? sender, EventArgs e)
    {
      bool eValorVazio = string.IsNullOrEmpty(view.ValorBusca);
      produtos = !eValorVazio ? repositorio.ObterPorValor(view.ValorBusca) : repositorio.ObterTodos();
      ProdutosBinding.DataSource = produtos;
    }
  }
}
