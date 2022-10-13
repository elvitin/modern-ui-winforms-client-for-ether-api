using AppEngSoft.Models.Produto;
using AppEngSoft.Models.Utils;
using AppEngSoft.Views.Produto;
using EtherAPI.Models.Produto;

namespace AppEngSoft.Presenters
{
  internal class ProdutoPresenter
  {
    private IProdutoView view;
    private IProdutoRepositorio produtoRepositorio;
    private IUnidadeRepositorio unidadeRepositorio;

    private BindingSource ProdutosBinding;
    private BindingSource UnidadesBinding;

    private IEnumerable<ProdutoModel> produtos;
    private IEnumerable<UnidadeModel> unidades;

    public ProdutoPresenter(IProdutoView view, IProdutoRepositorio produtoRepositorio, IUnidadeRepositorio unidadeRepositorio)
    {
      ProdutosBinding = new();
      UnidadesBinding = new();

      this.view = view;
      this.produtoRepositorio = produtoRepositorio;
      this.unidadeRepositorio = unidadeRepositorio;

      //Assinando eventos
      view.AdicionarEvento += AdicionarProduto;
      view.SalvarEvento += SalvarProduto;
      view.ProcurarEvento += ProcurarProduto;
      view.EditarEvento += CarregarEditarProduto;
      view.CancelarEvento += CancelarOperacao;
      view.DeletarEvento += DeletarProdutoSelecionado;



      //Assinando eventos da Unidade
      view.AdicionarEventoUnidade += AdicionarUnidade;
      view.SalvarEventoUnidade += SalvarUnidade;
      view.EditarEventoUnidade += CarregarEditarUnidade;
      view.DeletarEventoUnidade += DeletarUnidadeSelecionada;

      //Ligando fonte de dados
      view.LigarFonteDados(ProdutosBinding);
      view.LigarFonteDados_Unidades(UnidadesBinding);

      //Carregando Lista - [ ] Prover Interface para esse método
      AtualizarListaProdutos();
      AtualizarListaUnidades();


      view.Show();
    }

    private void DeletarUnidadeSelecionada(object? sender, EventArgs e)
    {
      try
      {
        UnidadeModel unidade = (UnidadeModel)UnidadesBinding.Current;
        unidadeRepositorio.Deletar(unidade.Id);
        view.eSucessoOperacao = true;
        view.Mensagem = $"Unidade ID {unidade.Id}, Deletado com sucesso!";
        AtualizarListaUnidades();
        view.eSucessoOperacao = true;
      }
      catch (Exception)
      {

      }
    }

    private void CarregarEditarUnidade(object? sender, EventArgs e)
    {
      //Não precisando enviar os dados para a view, pq já estaram lá.
      view.eEdicaoUnidade = true;
    }

    private void AdicionarUnidade(object? sender, EventArgs e)
    {
      view.eEdicaoUnidade = false;
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
          produtoRepositorio.Editar(produto);
          view.Mensagem = $"Produto ID {produto.Id}, Editado com sucesso!";
        }
        else
        {
          produtoRepositorio.Adicionar(produto);
          view.Mensagem = $"Produto adicionado com sucesso!";
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

    private void SalvarUnidade(object? sender, EventArgs e)
    {
      uint id = int.TryParse(view.UnidadeID, out _) ? Convert.ToUInt32(view.UnidadeID) : 0;
      UnidadeModel unidade = new()
      {
        Id = id,
        Nome = view.UnidadeNome
      };

      try
      {
        new ModelValidacao().Validar(unidade);

        if (view.eEdicaoUnidade)
        {
          unidadeRepositorio.Editar(unidade);
          view.Mensagem = $"Unidade ID {unidade.Id}, Editado com sucesso!";
        }
        else
        {
          unidadeRepositorio.Adicionar(unidade);
          view.Mensagem = $"Unidade adicionada com sucesso!";
        }
        view.eSucessoOperacao = true;
        AtualizarListaUnidades();
        view.UnidadeNome = "";
      }
      catch (Exception ex)
      {
        view.eSucessoOperacao = false;
        view.Mensagem = ex.Message;
      }
    }

    private void AtualizarListaUnidades()
    {
      unidades = unidadeRepositorio.ObterTodos();
      if (unidades.Any())
      {
        view.UnidadeID = unidades.ElementAt(0).Id.ToString();
        view.UnidadeNome = unidades.ElementAt(0).Nome.ToString();
      }
      else
      {
        view.UnidadeID = view.UnidadeNome = "";
      }
      UnidadesBinding.DataSource = unidades;
    }

    private void AtualizarListaProdutos()
    {
      produtos = produtoRepositorio.ObterTodos();
      ProdutosBinding.DataSource = produtos;
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
        produtoRepositorio.Deletar(produto.Id);
        view.eSucessoOperacao = true;
        view.Mensagem = $"Produto ID {produto.Id} Deletado com sucesso!";
        AtualizarListaProdutos();
      }
      catch (Exception ex)
      {
        view.eSucessoOperacao = false;
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

      ProdutoModel restanteDadosProduto = produtoRepositorio.ObterPorValor(produto.Id.ToString()).FirstOrDefault();

      view.ProdutoUnidadeID = restanteDadosProduto.Unidade.Id.ToString();
      view.ProdutoUnidadeNome = restanteDadosProduto.Unidade.Nome;
    }

    private void ProcurarProduto(object? sender, EventArgs e)
    {
      bool eValorVazio = string.IsNullOrEmpty(view.ValorBusca);
      produtos = !eValorVazio ? produtoRepositorio.ObterPorValor(view.ValorBusca) : produtoRepositorio.ObterTodos();
      ProdutosBinding.DataSource = produtos;
    }
  }
}
