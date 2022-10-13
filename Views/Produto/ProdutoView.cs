using AppEngSoft.Models.Cliente;
using AppEngSoft.Models.Produto;

namespace AppEngSoft.Views.Produto
{
  public partial class ProdutoView : Form, IProdutoView
  {
    //Campos
    private static ProdutoView instancia;
    private bool _eEdicao = false;
    private bool _eEdicaoUnidade = false;

    public ProdutoView()
    {
      InitializeComponent();
      TrocarPainel(PanelDetalhes, PanelLista);
      AssociarEventos();
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
    public string UnidadeID { get => TxtBoxUnidadeID.Texts; set => TxtBoxUnidadeID.Texts = value; }
    public string UnidadeNome { get => TxtBoxUnidadeNome.Texts; set => TxtBoxUnidadeNome.Texts = value; }

    public string Mensagem { get; set; }
    public string ValorBusca { get => TxtBoxProcurar.Texts; set => TxtBoxProcurar.Texts = value; }

    public bool eSucessoOperacao { get; set; }

    public bool eEdicao
    {
      get => _eEdicao;
      set
      {
        eTrocaUnidade = !value;
        BtnTrocarUnidade.Visible = value;
        TxtBoxProdutoUnidadeID.ReadOnly = !value;
        TxtBoxProdutoUnidadeNome.ReadOnly = !value;
        _eEdicao = value;
      }
    }

    public bool eEdicaoUnidade
    {
      get => _eEdicaoUnidade;
      set { _eEdicaoUnidade = value; }
    }


    public event EventHandler ProcurarEvento;
    public event EventHandler AdicionarEvento;
    public event EventHandler EditarEvento;
    public event EventHandler DeletarEvento;
    public event EventHandler SalvarEvento;
    public event EventHandler CancelarEvento;

    //-----EVENTOS DE UNIDADE----- 
    public event EventHandler AdicionarEventoUnidade;
    public event EventHandler ProcurarEventoUnidade;
    public event EventHandler EditarEventoUnidade;
    public event EventHandler DeletarEventoUnidade;
    public event EventHandler SalvarEventoUnidade;
    public event EventHandler CancelarEventoUnidade;

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
        CancelarEvento?.Invoke(this, EventArgs.Empty);
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

      //------EVENTOS DE UNIDADE------
      BtnNovoUnidade.Click += delegate
      {
        TxtBoxUnidadeNome.Texts = "";
        TxtBoxUnidadeNome.Enabled = true;
        DgvUnidades.Enabled = false;
        AdicionarEventoUnidade?.Invoke(this, EventArgs.Empty);
      };

      BtnSalvarUnidade.Click += delegate
      {
        SalvarEventoUnidade?.Invoke(this, EventArgs.Empty);
        if (eSucessoOperacao)
        {
          TxtBoxUnidadeNome.Enabled = false;
          DgvUnidades_SelectionChanged(this, EventArgs.Empty);
        }
        MessageBox.Show(Mensagem);
      };

      BtnEditarUnidade.Click += delegate
      {
        if (DgvUnidades.RowCount <= 0) return;
        DgvUnidades.Enabled = false;
        TxtBoxUnidadeNome.Enabled = true;
        EditarEventoUnidade?.Invoke(this, EventArgs.Empty);
      };

      BtnExcluirUnidade.Click += delegate
      {
        if (DgvUnidades.RowCount <= 0) return;
        int id = int.Parse(UnidadeID);

        DialogResult result = MessageBox.Show(
          $"Você realmente quer excluir a unidade ID: {id}?",
          "Atenção",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
        );

        if (result == DialogResult.Yes)
        {
          DeletarEventoUnidade?.Invoke(this, EventArgs.Empty);
          MessageBox.Show(Mensagem);
        }
      };

      /*
      BtnCancelarUnidade.Click += delegate
      {

      }
      */
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


    private bool eTrocaUnidade = false;
    private void DgvUnidades_SelectionChanged(object sender, EventArgs e)
    {
      if (DgvUnidades.SelectedRows.Count <= 0) return;
      if (eTrocaUnidade)
      {
        ProdutoUnidadeID = DgvUnidades.SelectedRows[0].Cells[0].Value.ToString();
        ProdutoUnidadeNome = DgvUnidades.SelectedRows[0].Cells[1].Value.ToString();
      }
      UnidadeID = DgvUnidades.SelectedRows[0].Cells[0].Value.ToString();
      UnidadeNome = DgvUnidades.SelectedRows[0].Cells[1].Value.ToString();
    }

    private void BtnTrocarUnidade_Click(object sender, EventArgs e)
    {
      eTrocaUnidade = !eTrocaUnidade;
      TxtBoxProdutoUnidadeID.Enabled = !TxtBoxProdutoUnidadeID.Enabled;
      TxtBoxProdutoUnidadeNome.Enabled = !TxtBoxProdutoUnidadeNome.Enabled;

      TxtBoxProdutoUnidadeID.ReadOnly = !TxtBoxProdutoUnidadeID.ReadOnly;
      TxtBoxProdutoUnidadeNome.ReadOnly = !TxtBoxProdutoUnidadeNome.ReadOnly;
      BtnTrocarUnidade.Text = eTrocaUnidade ? "Ok" : "Trocar Unidade";
      DgvUnidades_SelectionChanged(this, EventArgs.Empty);
    }

    private void BtnCancelarUnidade_Click(object sender, EventArgs e)
    {
      TxtBoxUnidadeNome.Texts = "";
      TxtBoxUnidadeNome.Enabled = false;
      DgvUnidades.Enabled = true;
      DgvUnidades_SelectionChanged(this, EventArgs.Empty);
    }
  }
}
