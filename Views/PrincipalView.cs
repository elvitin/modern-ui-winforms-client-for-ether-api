using AppEngSoft.Properties;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace AppEngSoft.Views
{
  public partial class PrincipalView : Form, IPrincipalView
  {
    private class Profiles
    {
      public string Nome { get; set; }
      public string Imagem { get; set; }
      public string Link { get; set; }
    }
    int perfil_atual = 0;
    Profiles[] perfis = new Profiles[] {
      new Profiles()
      {
        Nome = "Victor Rodrigues",
        Imagem = "victor_profile",
        Link = "https://github.com/src-rodrigues"
      },
      new Profiles()
      {
        Nome = "Vinicius Breda",
        Imagem = "breda_profile",
        Link = "https://www.linkedin.com/in/vin%C3%ADcius-breda-444b52112/"
      },
      new Profiles()
      {
        Nome = "Guilherme Jurazek",
        Imagem = "gui_profile",
        Link = "https://github.com/guilherme-jurazek"
      },
      new Profiles()
      {
        Nome = "Enzo Vannucci",
        Imagem = "enzo_profile",
        Link = "https://www.linkedin.com/in/enzo-benvengo-517a3b224/"
      },
      new Profiles()
      {
        Nome = "Melhor da FIPP 🥰",
        Imagem = "maracci_profile",
        Link = "https://www.linkedin.com/in/francisco-virginio-maracci-30b6632a"
      },
    };
    

    string[] navegadores = {
        "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe",
        "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe",
        "C:\\Program Files\\Mozilla Firefox\\firefox.exe",
    };

    private Button BotaoAtivo;
    public Form FormularioEmContexto { get; set; }

    public event EventHandler ExibirClientesView;
    public event EventHandler ExibirCategoriasView;
    public event EventHandler ExibirVendedoresView;
    public event EventHandler ExibirProdutosView;

    public PrincipalView()
    {
      InitializeComponent();
      Text = String.Empty;
      ControlBox = false;
      BtnCloseChildForm.Visible = false;
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int wParam, int lParam);

    public void PrepareChildForm(Form formularioFilho)
    {
      FechaFormularioEmContexto();
      FormularioEmContexto = formularioFilho;
      formularioFilho.TopLevel = false; //[ ] Pesquisar metodo
      formularioFilho.FormBorderStyle = FormBorderStyle.None;
      formularioFilho.Dock = DockStyle.Fill;
      formularioFilho.BringToFront();
      PanelDesktop.Controls.Add(formularioFilho);
      PanelDesktop.Tag = formularioFilho;
      LabelHeader.Text = formularioFilho.Tag?.ToString();
    }

    private void ActivateBtn(Button btnSender)
    {
      if (btnSender != null && btnSender != BotaoAtivo)
      {
        DisableBtn(BotaoAtivo);
        BotaoAtivo = btnSender;
        BotaoAtivo.BackColor = Color.FromArgb(123, 227, 206);
        BotaoAtivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 227, 206);
        BtnCloseChildForm.Visible = true;
      }
    }

    private void DisableBtn(Button btn) //Set normal state button
    {
      if (btn == null) return;
      btn.BackColor = Color.White;
      btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 246, 239);
    }

    private void Reset()
    {
      DisableBtn(BotaoAtivo);
      LabelHeader.Text = "Ether ERP";
      BotaoAtivo = null;
      BtnCloseChildForm.Visible = false;
    }

    private void FechaFormularioEmContexto()
    {
      if (FormularioEmContexto != null)
      {
        FormularioEmContexto.Close();
        FormularioEmContexto = null;
      }

    }

    private void BtnCloseChildForm_Click(object sender, EventArgs e)
    {
      FechaFormularioEmContexto();
      Reset();
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void BtnMaximizeRestore_Click(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Normal)
      {
        BtnMaximizeRestore.Image = Properties.Resources.icons8_restore_down_32;
        this.WindowState = FormWindowState.Maximized;
      }
      else
      {
        BtnMaximizeRestore.Image = Properties.Resources.icons8_maximize_button_32;
        this.WindowState = FormWindowState.Normal;
      }
    }

    private void LabelHeader_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void BtnMinimize_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }


    //Eventos dos botões
    private void BtnCliente_Click(object sender, EventArgs e)
    {
      if (sender == BotaoAtivo) return;
      ExibirClientesView?.Invoke(this, EventArgs.Empty);
      ActivateBtn((Button)sender);
    }

    private void BtnVendedores_Click(object sender, EventArgs e)
    {
      if (sender == BotaoAtivo) return;
      ExibirVendedoresView?.Invoke(this, EventArgs.Empty);
      ActivateBtn((Button)sender);
    }

    private void BtnProduto_Click(object sender, EventArgs e)
    {
      if (sender == BotaoAtivo) return;
      ExibirProdutosView?.Invoke(this, EventArgs.Empty);
      ActivateBtn((Button)sender);
    }

    private void LinkLabelPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int tentativa = 0;
      while (tentativa < navegadores.Length)
      {
        try
        {
          Process.Start(navegadores[tentativa], perfis[perfil_atual].Link);
          tentativa = navegadores.Length;
        }
        catch (Exception)
        {
          tentativa++;
        }
      }
    }

    private void CircularPicBoxPerfil_Click(object sender, EventArgs e)
    {
      perfil_atual++;
      if (perfil_atual == perfis.Length)
        perfil_atual = 0;

      CircularPicBoxPerfil.Image = (Bitmap)Resources.ResourceManager.GetObject(perfis[perfil_atual].Imagem);
      LinkLabelPerfil.Text = perfis[perfil_atual].Nome;
    }
  }
}

/*
 this.CircularPicBoxPerfil.Image = global::AppEngSoft.Properties.Resources.victor_profile;

 internal static System.Drawing.Bitmap victor_profile
    {
      get
      {
        object obj = ResourceManager.GetObject("victor_profile", resourceCulture);
        return ((System.Drawing.Bitmap)(obj));
      }
    }
 */