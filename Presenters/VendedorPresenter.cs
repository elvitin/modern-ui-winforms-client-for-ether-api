using AppEngSoft.Models.Utils;
using AppEngSoft.Models.Vendedor;
using AppEngSoft.Views.Vendedor;

namespace AppEngSoft.Presenters
{
  internal class VendedorPresenter
  {
    private IVendedorView view;
    private IVendedorRepositorio repositorio;
    private BindingSource VendedoresBinding;
    private IEnumerable<VendedorModel> vendedores;

    public VendedorPresenter(IVendedorView view, IVendedorRepositorio repositorio)
    {
      VendedoresBinding = new();
      this.view = view;
      this.repositorio = repositorio;

      //Assinando eventos
      view.ProcurarEvento += ProcurarVendedor;
      view.EditarEvento += CarregarEditarVendedor;
      view.CancelarEvento += CancelarOperacao;
      view.DeletarEvento += DeletarVendedorSelecionado;
      view.AdicionarEvento += AdicionarVendedor;
      view.SalvarEvento += SalvarVendedor;

      // Ligando fonte de dados
      view.LigarFonteDados(VendedoresBinding);

      AtualizarListaVendedores();

      view.Show();
    }



    private void SalvarVendedor(object? sender, EventArgs e)
    {
      uint id = int.TryParse(view.Id, out _) ? Convert.ToUInt32(view.Id) : 0;
      VendedorModel vendedor = new()
      {
        Id = id,
        Nome = view.Nome
      };

      try
      {
        new ModelValidacao().Validar(vendedor);
        if (view.eEdicao)
        {
          repositorio.Editar(vendedor);
          view.Mensagem = "Vendedor editado com sucesso!";
        }
        else
        {
          repositorio.Adicionar(vendedor);
          view.Mensagem = "Vendedor salvo com sucesso!";
        }
        view.eSucessoOperacao = true;
        AtualizarListaVendedores();
        LimparCampos();
      }
      catch (Exception ex)
      {
        view.eSucessoOperacao = false;
        view.Mensagem = ex.Message;
      }
    }

    private void AdicionarVendedor(object? sender, EventArgs e)
    {
      view.eEdicao = false;
    }

    private void DeletarVendedorSelecionado(object? sender, EventArgs e)
    {
      try
      {
        VendedorModel vendedor = (VendedorModel)VendedoresBinding.Current;
        repositorio.Deletar(vendedor.Id);
        view.eSucessoOperacao = true;
        view.Mensagem = "Vendedor deletado com sucesso!";
        AtualizarListaVendedores();
      }
      catch (Exception ex)
      {
        view.eSucessoOperacao = true;
        view.Mensagem = ex.Message;
      }
    }

    private void CancelarOperacao(object? sender, EventArgs e)
    {
      LimparCampos();
    }

    private void LimparCampos()
    {
      view.ValorBusca = "";
      view.Id = "0";
      view.Nome = "";
    }

    private void CarregarEditarVendedor(object? sender, EventArgs e)
    {
      view.eEdicao = true;
      VendedorModel cliente = (VendedorModel)VendedoresBinding.Current;
      view.Id = cliente.Id.ToString();
      view.Nome = cliente.Nome;
    }

    private void ProcurarVendedor(object? sender, EventArgs e)
    {
      bool eValorVazio = string.IsNullOrEmpty(view.ValorBusca);
      vendedores = !eValorVazio ? repositorio.ObterPorValor(view.ValorBusca) : repositorio.ObterTodos();
      VendedoresBinding.DataSource = vendedores;
    }

    private void AtualizarListaVendedores()
    {
      vendedores = repositorio.ObterTodos();
      VendedoresBinding.DataSource = vendedores;
    }
  }
}
