using System.Runtime.InteropServices;

namespace AppEngSoft
{
  public partial class FormPrincipal : Form
  {
    private Button CurrentBtn;
    private Button PreviousBtn;
    private Form _ActiveForm;

    public FormPrincipal()
    {
      InitializeComponent();
      this.Text = String.Empty;
      this.ControlBox = false;
      BtnCloseChildForm.Visible = false;
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int wParam, int lParam);

    private void Reset()
    {
      DisableBtn(CurrentBtn);
      LabelHeader.Text = "Ether ERP";
      PreviousBtn = CurrentBtn = null;
      BtnCloseChildForm.Visible = false;
    }

    private void ActivateBtn(object btnSender)
    {
      if (btnSender != null && CurrentBtn != (Button)btnSender)
      {
        PreviousBtn = CurrentBtn;
        DisableBtn(PreviousBtn);
        CurrentBtn = (Button)btnSender;
        CurrentBtn.BackColor = Color.FromArgb(123, 227, 206);
        CurrentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 227, 206);
        BtnCloseChildForm.Visible = true;
      }
    }

    private void DisableBtn(Button btn) //Set normal state button
    {
      if (btn == null) return;
      btn.BackColor = Color.White;
      btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 246, 239);
    }

    private void OpenChildForm(Form childForm, object btnSender)
    {

      if (_ActiveForm != null)
      {
        _ActiveForm.Close();
      }
      ActivateBtn(btnSender);
      _ActiveForm = childForm;
      childForm.TopLevel = false; // [ ] Ver oque faz
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      this.PanelDesktop.Controls.Add(childForm); // Adiciona um formulário como um de seus filhos
      this.PanelDesktop.Tag = childForm; // [ ] Ver oque faz
      childForm.BringToFront(); // Traz para frente
      childForm.Show();
      LabelHeader.Text = childForm.Text;
    }

    private void VendaBtn_Click(object sender, EventArgs e)
    {
      OpenChildForm(new Forms.Venda(), sender);
    }

    private void ProdutoBtn_Click(object sender, EventArgs e)
    {
      OpenChildForm(new Forms.Produto(), sender);
    }

    private void ClienteBtn_Click(object sender, EventArgs e)
    {
      //ActivateBtn(sender);
      OpenChildForm(new Forms.Cliente(), sender);
    }

    private void VendedoresBtn_Click(object sender, EventArgs e)
    {
      ActivateBtn(sender);
    }

    private void BtnCloseChildForm_Click(object sender, EventArgs e)
    {
      if (_ActiveForm != null)
        _ActiveForm.Close();
      Reset();
    }



    private void LabelHeader_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
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

    private void BtnMinimize_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }
  }
}