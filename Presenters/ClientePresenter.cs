using AppEngSoft.Models;
using AppEngSoft.Models.Utils;
using AppEngSoft.Views;
using EtherAPI.Models.Cliente;

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
      uint id = int.TryParse(view.Id, out _) ? Convert.ToUInt32(view.Id) : 0;

      ClienteModel cliente = new()
      {
        Id = id,
        Nome = view.Nome,
        Email = view.Email,
        Fone = view.Fone,
      };

      if (view.ePessoaJuridica)
      {
        cliente.TipoPessoa = "J";
        cliente.Fisica = null;
        cliente.Juridica = new()
        {
          ClienteId = id,
          Cnpj = view.CNPJ,
          InscEstadual = view.InscricaoEstadual,
          InscMunicipal = view.InscricaoMunicipal
        };
      }
      else
      {
        cliente.TipoPessoa = "F";
        cliente.Juridica = null;
        cliente.Fisica = new()
        {
          ClienteId = id,
          Cpf = view.CPF,
          Rg = view.RG,
          Sexo = view.eFeminino ? "F" : "M"
        };
      }

      try
      {
        new ModelValidacao().Validar(cliente);
        if (view.eEdicao)
        {
          repositorio.Editar(cliente);
          view.Mensagem = "Editado com sucesso!";
        }
        else
        {
          repositorio.Adicionar(cliente);
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
      try
      {
        ClienteModel cliente = (ClienteModel)ClientesBinding.Current;
        repositorio.Deletar(cliente.Id);
        view.SucessoOperacao = true;
        view.Mensagem = "Deletado com sucesso!";
        AtualizarListaClientes();
      } 
      catch (Exception ex)
      {
        view.SucessoOperacao = true;
        view.Mensagem = ex.Message;
      }
    }

    private void LimparCampos()
    {
      view.ValorBusca = "";
      view.Id = "0";
      view.Fone = "";
      view.Email = "";
      view.Nome = "";
      view.CNPJ = "";
      view.CPF = "";
      view.RG = "";
      view.InscricaoEstadual = "";
      view.InscricaoMunicipal = "";
      view.ePessoaJuridica = false;
      view.eFeminino = false;
    }

    private void CancelarOperacao(object? sender, EventArgs e)
    {
      LimparCampos();
    }

    private void CarregarEditarCliente(object? sender, EventArgs e)
    {
      view.eEdicao = true;

      ClienteModel cliente = (ClienteModel)ClientesBinding.Current;

      view.Id = cliente.Id.ToString();
      view.Nome = cliente.Nome;
      view.Email = cliente.Email;
      view.Fone = cliente.Fone;

      ClienteModel dados = repositorio.ObterPorValor(cliente.Id.ToString()).FirstOrDefault();

      if (cliente.TipoPessoa == "F")
      {
        view.ePessoaJuridica = false;
        view.RG = dados.Fisica.Rg;
        view.CPF = dados.Fisica.Cpf;
        view.eFeminino = dados.Fisica.Sexo == "F";
      }
      else
      {
        view.ePessoaJuridica = true;
        view.CNPJ = dados.Juridica.Cnpj;
        view.InscricaoEstadual = dados.Juridica.InscEstadual;
        view.InscricaoMunicipal = dados.Juridica.InscMunicipal;
      }
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
