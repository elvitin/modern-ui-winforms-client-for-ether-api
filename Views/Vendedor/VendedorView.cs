using EtherAPI.Models.Cliente;

namespace AppEngSoft.Views.Vendedor
{
  /*
   * [ ] Criar classe abstrata do vendedor, de forma que ele implemente
   * metodos repetidos, exemplo:
   * 
   * ObterInstancia();
   * TrocarPainel();
   * LigarFonteDados();
   */

  public partial class VendedorView : Form, IVendedorView
  {
    private static VendedorView instancia;
    private string mensagem;
    private bool _eEdicao;

    public VendedorView()
    {
      InitializeComponent();
      TrocarPainel(PanelDetalhes, PanelLista);
      AssociarEventos();
    }


    public string Id { get => TxtBoxVendedorID.Texts; set => TxtBoxVendedorID.Texts = value; }
    public string Nome { get => TxtBoxVendedorNome.Texts; set => TxtBoxVendedorNome.Texts = value; }
    public string ValorBusca { get => TxtBoxProcurar.Texts; set => TxtBoxProcurar.Texts = value; }

    public string Mensagem { get => mensagem; set => mensagem = value; }
    public bool eSucessoOperacao { get; set; }
    public bool eEdicao { get => _eEdicao; set => _eEdicao = value; }

    public event EventHandler ProcurarEvento;
    public event EventHandler AdicionarEvento;
    public event EventHandler EditarEvento;
    public event EventHandler DeletarEvento;
    public event EventHandler SalvarEvento;
    public event EventHandler CancelarEvento;

    public void AssociarEventos()
    {
      BtnEditar.Click += delegate
      {
        if (DgvVendedores.RowCount <= 0) return;
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
        if (DgvVendedores.RowCount <= 0) return;
        DialogResult result = MessageBox.Show(
          "Você realmente quer deletar o vendedor?",
          "Atenção",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
        );

        if (result == DialogResult.Yes)
        {
          DeletarEvento?.Invoke(this, EventArgs.Empty);
          MessageBox.Show(Mensagem);
        }
      };

      BtnSalvar.Click += delegate
      {
        SalvarEvento?.Invoke(this, EventArgs.Empty);
        if (eSucessoOperacao)
          TrocarPainel(PanelDetalhes, PanelLista);
        MessageBox.Show(Mensagem);
      };

      TxtBoxProcurar.KeyDown += (s, e) =>
      {
        if (e.KeyCode == Keys.Enter)
        {
          //********* retira som do Enter ao buscar um registro*********
          //e.Handled = true;
          e.SuppressKeyPress = true;

          ProcurarEvento?.Invoke(this, EventArgs.Empty);
        }
      };

      BtnProcurar.Click += delegate
      {
        ProcurarEvento?.Invoke(this, EventArgs.Empty);
      };

      BtnProcurar.Click += delegate
      {
        ProcurarEvento?.Invoke(this, EventArgs.Empty);
      };

      BtnNovo.Click += delegate
      {
        AdicionarEvento?.Invoke(this, EventArgs.Empty);
        TrocarPainel(PanelLista, PanelDetalhes);
      };
    }

    public static VendedorView ObterInstancia()
    {
      return instancia == null || instancia.IsDisposed ? new VendedorView() : instancia;
    }

    public void TrocarPainel(Panel atual, Panel novo)
    {
      PanelVendedor.Controls.Remove(atual);
      PanelVendedor.Controls.Add(novo);
      novo.BackColor = Color.FromArgb(246, 246, 246);
      novo.Dock = DockStyle.Fill;
    }

    //Transformar em interface principal
    public void LigarFonteDados(BindingSource VendedoresLista)
    {
      DgvVendedores.DataSource = VendedoresLista;
    }
  }
}
