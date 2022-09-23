using System.Runtime.InteropServices;

namespace FlatUI
{
  public partial class Principal : Form
  {
    private Button CurrentBtn;
    private Random Rand;
    private int TmpIndex; //falta iniciar
    private Form _ActiveForm;

    public Principal()
    {
      InitializeComponent();
      Rand = new();
      this.Text = String.Empty;
      this.ControlBox = false;
      BtnCloseChildForm.Visible = false;
      //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int wParam, int lParam);

    private Color SelectThemeColor()
    {
      int index = Rand.Next(ThemeColor.ColorList.Count);
      while (TmpIndex == index)
      {
        index = Rand.Next(ThemeColor.ColorList.Count);
      }
      TmpIndex = index;
      string color = ThemeColor.ColorList[index];
      return ColorTranslator.FromHtml(color);
    }

    private void ActivateBtn(object btnSender)
    {
      if (btnSender != null)
      {
        if (CurrentBtn != (Button)btnSender)
        {
          DisableBtn();
          //Color color = SelectThemeColor();
          //Color color = outraPressionada;
          CurrentBtn = (Button)btnSender;
          CurrentBtn.BackColor = Color.FromArgb(123, 227, 206);
          CurrentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 227, 206);
          BtnCloseChildForm.Visible = true;
          
          //this.VendaBtn.FlatAppearance.MouseOverBackColor
          //CurrentBtn.ForeColor = Color.White;
          //new System.Drawing.Font("JetBrains Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
          //CurrentBtn.Font = new System.Drawing.Font("JetBrains Mono", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
      }
    }

    private void DisableBtn()
    {
      /*
       * [ ] MUDAR ESSE FOR, GUARDA O ESTADO DO ULTIMO BOTÃO CLICADOS
       */
      foreach (Control previousBtn in MenuPanel.Controls)
      {
        if (previousBtn.GetType() == typeof(Button))
        {
          //211; 246; 239 //Cor Hover
          previousBtn.BackColor = Color.White; //colocar variaveis globais aqui.
          ((Button)previousBtn).FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 246, 239);
          //previousBtn.ForeColor = Color.White;        //colocar variaveis globais aqui.
          //previousBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
      }
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
      this.PanelDesktop.Controls.Add(childForm); // [ ] Ver oque faz
      this.PanelDesktop.Tag = childForm; // [ ] Ver oque faz
      childForm.BringToFront(); // [ ] Ver oque faz
      childForm.Show();
      LabelHeader.Text = childForm.Text;
    }

    private void VendaBtn_Click(object sender, EventArgs e)
    {

      //ActivateBtn(sender);
      OpenChildForm(new Forms.Venda(), sender);
    }

    private void ProdutoBtn_Click(object sender, EventArgs e)
    {
      OpenChildForm(new Forms.Produto(), sender);
    }

    private void ClienteBtn_Click(object sender, EventArgs e)
    {
      ActivateBtn(sender);
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

    private void Reset()
    {
      DisableBtn();
      LabelHeader.Text = "Ether ERP";
      CurrentBtn = null;
      BtnCloseChildForm.Visible = false;
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
      if(WindowState == FormWindowState.Normal)
      {
        BtnMaximizeRestore.Image = global::FlatUI.Properties.Resources.icons8_restore_down_32;
        this.WindowState = FormWindowState.Maximized;
      } 
      else
      {
        BtnMaximizeRestore.Image = global::FlatUI.Properties.Resources.icons8_maximize_button_32;
        this.WindowState = FormWindowState.Normal;
      }
    }

    private void BtnMinimize_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }
  }
}