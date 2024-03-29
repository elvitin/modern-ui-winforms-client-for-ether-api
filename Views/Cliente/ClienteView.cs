﻿using AppEngSoft.Views.Cliente;

namespace AppEngSoft.Views
{
  public partial class ClienteView : Form, IClienteView
  {
    //Campos
    private static ClienteView instancia;
    private bool _eFeminino;
    private bool _ePessoaJuridica;

    //Construtor
    public ClienteView()
    {
      InitializeComponent();
      TrocarPainel(PanelDetalhes, PanelLista);
      AssociarEventos();

      ePessoaJuridica = false;
      eFeminino = false;
    }

    //Singleton da ClienteView
    public static ClienteView ObterInstancia()
    {
      if (instancia == null || instancia.IsDisposed)
      {
        instancia = new();
      }
      return instancia;
    }

    //Propriedades da model/view
    public string Id { get => TxtBoxID.Texts; set => TxtBoxID.Texts = value; }
    public string Nome { get => TxtBoxNome.Texts; set => TxtBoxNome.Texts = value; }
    public string Email { get => TxtBoxEmail.Texts; set => TxtBoxEmail.Texts = value; }
    public string Fone { get => TxtBoxFone.Texts; set => TxtBoxFone.Texts = value; }

    public string CNPJ { get => TxtBoxCNPJ.Texts; set => TxtBoxCNPJ.Texts = value; }
    public string InscricaoEstadual { get => TxtBoxInsEst.Texts; set => TxtBoxInsEst.Texts = value; }
    public string InscricaoMunicipal { get => TxtBoxInsMun.Texts; set => TxtBoxInsMun.Texts = value; }

    public string CPF { get => TxtBoxCPF.Texts; set => TxtBoxCPF.Texts = value; }
    public string RG { get => TxtBoxRG.Texts; set => TxtBoxRG.Texts = value; }

    //Propriedades de comportamento
    public string ValorBusca { get => TxtBoxProcurar.Texts; set => TxtBoxProcurar.Texts = value; }
    public string Mensagem { get; set; }

    public bool eFeminino
    {
      get => _eFeminino;
      set
      {
        _eFeminino = value;
        RadioBtnSexoFeminino.Checked = value;
        RadioBtnSexoMasculino.Checked = !value;
      }
    }
    public bool ePessoaJuridica
    {
      get => _ePessoaJuridica;
      set
      {
        _ePessoaJuridica = value;

        TlpPesJur.Enabled = value;
        TlpPesFis.Enabled = !value;

        RadioBtnPesJur.Checked = value;
        RadioBtnPesFis.Checked = !value;
      }
    }
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
    public void LigarFonteDados(BindingSource ClientesLista)
    {
      DgvClientes.DataSource = ClientesLista;
    }

    public void TrocarPainel(Panel atual, Panel novo)
    {
      PanelCliente.Controls.Remove(atual);
      PanelCliente.Controls.Add(novo);
      novo.Dock = DockStyle.Fill;
    }

    public void AssociarEventos()
    {
      RadioBtnPesJur.CheckedChanged += delegate
      {
        if (ePessoaJuridica != RadioBtnPesJur.Checked)
        {
          ePessoaJuridica = !ePessoaJuridica;
        }
      };

      RadioBtnSexoFeminino.CheckedChanged += delegate
      {
        if (eFeminino != RadioBtnSexoFeminino.Checked)
          eFeminino = !eFeminino;
      };

      BtnEditar.Click += delegate
      {
        //Desativa troca de tipo pessoa (Isso é regra de negocio, deixarque que a controler mude isso)
        //RadioBtnPesFis.Enabled = RadioBtnPesJur.Enabled = false;
        if (DgvClientes.RowCount <= 0) return;
        PanelTipoPessoa.Enabled = false;
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
        int index = ObterIndexPorNome(DgvClientes, "Id");

        if (DgvClientes.RowCount <= 0 || index == -1)
          return;

        uint id = (uint)DgvClientes.SelectedRows[0].Cells[index].Value;

        DialogResult result = MessageBox.Show(
          $"Você realmente quer excluir o cliente ID: {id}?",
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

      BtnNovo.Click += delegate
      {
        //Ativa troca de tipo pessoa (Isso é regra de negocio, tem que remover daqui)
        PanelTipoPessoa.Enabled = true;
        ePessoaJuridica = false;
        AdicionarEvento?.Invoke(this, EventArgs.Empty);
        TrocarPainel(PanelLista, PanelDetalhes);
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
    }

    //Metodos de suporte
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
  }
}
