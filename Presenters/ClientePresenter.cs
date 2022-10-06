using AppEngSoft.Models;
using AppEngSoft.Models.Utils;
using AppEngSoft.Views;

namespace AppEngSoft.Presenters
{
  internal class ClientePresenter
  {
    private IClienteView view;
    private IClienteRepositorio repositorio;
    private BindingSource ClientesBinding;
    private IEnumerable<ClienteModel> clientes;

    public ClientePresenter(IClienteView view, IClienteRepositorio repositorio)
    {
      ClientesBinding = new();
      this.view = view;
      this.repositorio = repositorio;

      //Assinando eventos
      view.ProcurarEvento += ProcurarCliente;
      view.EditarEvento += CarregarEditarCliente;
      view.CancelarEvento += CancelarOperacao;
      view.DeletarEvento += DeletarClienteSelecionado;
      view.AdicionarEvento += AdicionarCliente;
      view.SalvarEvento += SalvarCliente;

      //Ligando fonte de dados
      view.LigarFonteDados(ClientesBinding);

      //Carregando Lista
      AtualizarListaClientes();

      //Exibindo view
      view.Show();
    }

    

    private void SalvarCliente(object? sender, EventArgs e)
    {
      ClienteModel cliente = new()
      {
        Id = Convert.ToUInt32(view.Id),
        Nome = view.Nome,
        Email = view.Email,
        Fone = view.Fone,
        TipoPessoa = "F"
      };

      try
      {
        new ModelValidacao().Validar(cliente);
        if (view.eEdicao)
        {
          MessageBox.Show("Edição");
          view.Mensagem = "Editado com sucesso!";
        }
        else
        {
          MessageBox.Show("Adição");
          view.Mensagem = "Registro salvo com sucesso!";
        }
        view.SucessoOperacao = true;
        AtualizarListaClientes();
        LimparCampos();
      }
      catch (Exception ex)
      {
        view.SucessoOperacao = false;
        view.Mensagem = ex.Message;
      }
    }

    private void AdicionarCliente(object? sender, EventArgs e)
    {
      view.eEdicao = false;
    }

    private void DeletarClienteSelecionado(object? sender, EventArgs e)
    {
      view.Mensagem = "Deletado com sucesso!";
      AtualizarListaClientes();
    }

    private void LimparCampos()
    {
      view.Id = "0";
      view.Fone = view.Email = view.Nome = "";
    }

    private void CancelarOperacao(object? sender, EventArgs e)
    {
      LimparCampos();
    }

    private void CarregarEditarCliente(object? sender, EventArgs e)
    {
      ClienteModel cliente = (ClienteModel)ClientesBinding.Current;

      view.Id = cliente.Id.ToString();
      view.Nome = cliente.Nome;
      view.Fone = cliente.Fone;
      view.Email = cliente.Nome;
      view.eEdicao = true;
    }

    private void AtualizarListaClientes()
    {
      clientes = repositorio.ObterTodos();
      ClientesBinding.DataSource = clientes;
    }

    private void ProcurarCliente(object? sender, EventArgs e)
    {
      bool eValorVazio = string.IsNullOrEmpty(view.ValorBusca);
      clientes = !eValorVazio ? repositorio.ObterPorValor(view.ValorBusca) : repositorio.ObterTodos();
      ClientesBinding.DataSource = clientes;
    }
  }
}
