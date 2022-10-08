namespace AppEngSoft.Views.Produto
{
  public partial class ProdutoView : Form, IProdutoView
  {
    //Campos
    private static ProdutoView instancia;
    public ProdutoView()
    {
      InitializeComponent();
      TrocarPainel(PanelDetalhes, PanelLista);
      AssociarEventos();

      //DgvUnidades.DataSource = new object[] { "victor", "taveira"};
    }

    //Singleton da ProdutoView
    public static ProdutoView ObterInstancia()
    {
      if (instancia == null || instancia.IsDisposed)
      {
        instancia = new();
      }
      return instancia;
    }

    public string Id { get => TxtBoxProdutoID.Texts; set => TxtBoxProdutoID.Texts = value; }
    public string Nome { get => TxtBoxProdutoNome.Texts; set => TxtBoxProdutoNome.Texts = value; }
    public string Preco { get => TxtBoxProdutoPreco.Texts; set => TxtBoxProdutoPreco.Texts = value; }
    public string Estoque { get => TxtBoxProdutoQtde.Texts; set => TxtBoxProdutoQtde.Texts = value; }
    public string ProdutoUnidadeID { get => TxtBoxProdutoUnidadeID.Texts; set => TxtBoxProdutoUnidadeID.Texts = value; }
    public string ProdutoUnidadeNome { get => TxtBoxProdutoUnidadeNome.Texts; set => TxtBoxProdutoUnidadeNome.Texts = value; }


    public string Mensagem { get; set; }
    public string ValorBusca { get => TxtBoxProcurar.Texts; set => TxtBoxProcurar.Texts = value; }

    public bool eSucessoOperacao { get; set; }
    public bool eEdicao { get; set; }


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
        if (DgvProdutos.RowCount <= 0) return;
        EditarEvento?.Invoke(this, EventArgs.Empty);
        TrocarPainel(PanelLista, PanelDetalhes);
      };

      BtnCancelar.Click += delegate
      {
        //CancelarEvento?.Invoke(this, EventArgs.Empty);
        TrocarPainel(PanelDetalhes, PanelLista);
      };

      BtnExcluir.Click += delegate
      {
        int index = ObterIndexPorNome(DgvProdutos, "Id");

        if (DgvProdutos.RowCount <= 0 || index == -1)
          return;

        uint id = (uint)DgvProdutos.SelectedRows[0].Cells[index].Value;

        DialogResult result = MessageBox.Show(
          $"Você realmente quer excluir o produto ID: {id}?",
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

      BtnNovo.Click += delegate
      {
        AdicionarEvento?.Invoke(this, EventArgs.Empty);
        TrocarPainel(PanelLista, PanelDetalhes);
      };
    }

    private int ObterIndexPorNome(DataGridView dgv, string nome)
    {
      int index;
      try
      {
        index = dgv.Columns[nome].Index;
      }
      catch
      {
        index = -1;
      }
      return index;
    }

    public void LigarFonteDados(BindingSource ProdutosLista)
    {
      DgvProdutos.DataSource = ProdutosLista;
    }

    public void LigarFonteDados_Unidades(BindingSource UnidadesLista)
    {
      DgvUnidades.DataSource = UnidadesLista;
    }

    public void TrocarPainel(Panel atual, Panel novo)
    {
      PanelProduto.Controls.Remove(atual);
      PanelProduto.Controls.Add(novo);
      novo.BackColor = Color.FromArgb(246, 246, 246);
      novo.Dock = DockStyle.Fill;
    }

    
  }
}
