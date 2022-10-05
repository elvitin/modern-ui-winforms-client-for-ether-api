using System.Security.Cryptography;

namespace AppEngSoft.Views
{
  public partial class ClienteView : Form, IClienteView
  {
    public ClienteView()
    {
      InitializeComponent();

      //Transformar em metodo
      /*
      PanelCliente.Controls.Remove(PanelDetalhes);
      PanelCliente.Controls.Add(PanelLista);
      PanelLista.Dock = DockStyle.Fill;
      */
      TrocarPainel(PanelDetalhes, PanelLista);
      AssociarEventos();
    }

    private static ClienteView instancia;

    public string Id { get => TxtBoxID.Texts; set => TxtBoxID.Texts = value; }
    public string Nome { get => TxtBoxNome.Texts; set => TxtBoxNome.Texts = value; }
    public string Email { get => TxtBoxEmail.Texts; set => TxtBoxEmail.Texts = value; }
    public string Fone { get => TxtBoxFone.Texts; set => TxtBoxFone.Texts = value; }
    //public string TipoPessoa { get => ; set => TxtBoxID.Texts = value; }

    public event EventHandler ProcurarEvento;
    public event EventHandler AdicionarEvento;
    public event EventHandler RemoverEvento;
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
