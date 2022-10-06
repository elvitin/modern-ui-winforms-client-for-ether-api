using System.Security.Cryptography;

namespace AppEngSoft.Views
{
  public partial class ClienteView : Form, IClienteView
  {
    private static ClienteView instancia;
    private string mensagem;
    private bool isEdicao;
    public ClienteView()
    {
      InitializeComponent();
      TrocarPainel(PanelDetalhes, PanelLista);
      AssociarEventos();
    }

    

    public string Id { get => TxtBoxID.Texts; set => TxtBoxID.Texts = value; }
    public string Nome { get => TxtBoxNome.Texts; set => TxtBoxNome.Texts = value; }
    public string Email { get => TxtBoxEmail.Texts; set => TxtBoxEmail.Texts = value; }
    public string Fone { get => TxtBoxFone.Texts; set => TxtBoxFone.Texts = value; }
    public string Mensagem { get => mensagem; set => mensagem = value; }
    public bool eEdicao { get => isEdicao; set => isEdicao = value; }
    public bool SucessoOperacao { get; set; }
    public string ValorBusca { get => TxtBoxProcurar.Texts; set => TxtBoxProcurar.Texts = value; }

    //public string TipoPessoa { get => ; set => TxtBoxID.Texts = value; }

    public event EventHandler ProcurarEvento;
    public event EventHandler AdicionarEvento;
    public event EventHandler EditarEvento;
    public event EventHandler DeletarEvento;
    public event EventHandler SalvarEvento;
    public event EventHandler CancelarEvento;

    private void AssociarEventos()
    {
      BtnEditar.Click += delegate 
      {
        //Transformar em metodo
        EditarEvento?.Invoke(this, EventArgs.Empty);
        TrocarPainel(PanelLista, PanelDetalhes);
      };

      BtnCancelar.Click += delegate
      {
        CancelarEvento?.Invoke(this, EventArgs.Empty);
        TrocarPainel(PanelDetalhes, PanelLista);
      };

      BtnExcluir.Click += delegate 
      {
        DialogResult result = MessageBox.Show("Você realmente quer deletar o registro?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
          DeletarEvento?.Invoke(this, EventArgs.Empty);
          MessageBox.Show(Mensagem);
        }
      };

      BtnSalvar.Click += delegate
      {
        SalvarEvento?.Invoke(this, EventArgs.Empty);
        if (SucessoOperacao)
          TrocarPainel(PanelDetalhes, PanelLista);
        MessageBox.Show(Mensagem);
      };

      BtnNovo.Click += delegate
      {
        AdicionarEvento?.Invoke(this, EventArgs.Empty);
        TrocarPainel(PanelLista, PanelDetalhes);
      };

      TxtBoxProcurar.KeyDown += (s, e) =>
      {
        if (e.KeyCode == Keys.Enter)
        {
          //retira som do Enter
          //e.Handled = true;
          e.SuppressKeyPress = true;

          ProcurarEvento?.Invoke(this, EventArgs.Empty);
        }
      };

      BtnProcurar.Click += delegate { ProcurarEvento?.Invoke(this, EventArgs.Empty); };
    }

    private void TrocarPainel(Panel atual, Panel novo)
    {
      PanelCliente.Controls.Remove(atual);
      PanelCliente.Controls.Add(novo);
      novo.Dock = DockStyle.Fill;
    }
    public static ClienteView ObterInstancia()
    {
      return instancia == null || instancia.IsDisposed ? new ClienteView() : instancia;
    }

    public void LigarFonteDados(BindingSource ClientesLista)
    {
      DgvClientes.DataSource = ClientesLista;
    }
  }
}
