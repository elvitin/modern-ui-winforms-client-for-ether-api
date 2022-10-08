using System.Runtime.InteropServices;

namespace AppEngSoft.Views
{
  public partial class PrincipalView : Form, IPrincipalView
  {

    private Button BotaoAtivo;
    public Form FormularioEmContexto { get; set; }

    public event EventHandler ExibirClientesView;
    public event EventHandler ExibirCategoriasView;
    public event EventHandler ExibirVendedoresView;

    public PrincipalView()
    {
      InitializeComponent();
      Text = String.Empty;
      ControlBox = false;
      BtnCloseChildForm.Visible = false;
      
      BtnCliente.Click += delegate
      {
        ExibirClientesView?.Invoke(this, EventArgs.Empty);
        ActivateBtn(BtnCliente);
      };

      BtnVendedores.Click += delegate
      {
        ExibirVendedoresView?.Invoke(this, EventArgs.Empty);
        ActivateBtn(BtnVendedores);
      };
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
  }
}
