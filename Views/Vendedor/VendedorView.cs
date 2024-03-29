﻿namespace AppEngSoft.Views.Vendedor
{

  public partial class VendedorView : Form, IVendedorView
  {
    //Campos
    private static VendedorView instancia;

    //Construtor
    public VendedorView()
    {
      InitializeComponent();
      TrocarPainel(PanelDetalhes, PanelLista);
      AssociarEventos();
    }

    //Singleton da VendedorView
    public static VendedorView ObterInstancia
    {
      get
      {
        if (instancia == null || instancia.IsDisposed)
        {
          //MessageBox.Show("Nova instancia de VendedorView");
          instancia = new();
        }
        //else MessageBox.Show("Retornando instancia de VendedorView");


        return instancia;
      }
    }

    //Propriedades da model/view
    public string Id { get => TxtBoxVendedorID.Texts; set => TxtBoxVendedorID.Texts = value; }
    public string Nome { get => TxtBoxVendedorNome.Texts; set => TxtBoxVendedorNome.Texts = value; }

    //Propriedades de comportamento
    public string ValorBusca { get => TxtBoxProcurar.Texts; set => TxtBoxProcurar.Texts = value; }
    public string Mensagem { get; set; }
    public bool eSucessoOperacao { get; set; }
    public bool eEdicao { get; set; }

    //Eventos
    public event EventHandler ProcurarEvento;
    public event EventHandler AdicionarEvento;
    public event EventHandler EditarEvento;
    public event EventHandler DeletarEvento;
    public event EventHandler SalvarEvento;
    public event EventHandler CancelarEvento;

    //Metodos da interface
    public void LigarFonteDados(BindingSource VendedoresLista)
    {
      DgvVendedores.DataSource = VendedoresLista;
    }



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

    public void TrocarPainel(Panel atual, Panel novo)
    {
      PanelVendedor.Controls.Remove(atual);
      PanelVendedor.Controls.Add(novo);
      novo.BackColor = Color.FromArgb(246, 246, 246);
      novo.Dock = DockStyle.Fill;
    }

    //Metodos de suporte
  }
}
