using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace AppEngSoft.CustomControls
{
  [DefaultEvent("_TextChanged")]
  public partial class KpmTextBox : UserControl
  {
    //Fields
    //Fonte maneirinha: this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
    private Color borderColor = Color.FromArgb(153, 153, 153);
    private Color borderFocusColor = Color.FromArgb(30, 133, 111);
    private bool isFocused = false;
    private int borderSize = 1;
    private bool underlinedStyle = false;
    private int borderRadius = 5;
    private Color placeHolderColor = Color.FromArgb(152, 152, 165);
    private string placeHolderText = "";
    private bool isPlaceHolder = false;
    private bool isPasswordChar = false;

    //Events
    public event EventHandler _TextChanged;

    //Constructor
    public KpmTextBox()
    {
      InitializeComponent();
      ForeColor = Color.FromArgb(29, 29, 27);
      Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
    }



    //Properties
    [Category("Kpm Custom Properties")]
    public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

    [Category("Kpm Custom Properties")]
    public Color BorderColor { get => borderColor; set { borderColor = value; Invalidate(); } }

    [Category("Kpm Custom Properties")]
    public int BorderSize { get => borderSize; set => borderSize = value; }

    [Category("Kpm Custom Properties")]
    public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }

    [Category("Kpm Custom Properties")]
    public bool PasswordChar
    {
      get => isPasswordChar;
      set
      {
        isPasswordChar = value;
        TxtBox.UseSystemPasswordChar = value;
      }
    }

    [Category("Kpm Custom Properties")]
    public bool Multiline { get => TxtBox.Multiline; set => TxtBox.Multiline = value; }

    [Category("Kpm Custom Properties")]
    public override Color BackColor
    {
      get => base.BackColor;
      set
      {
        base.BackColor = value;
        TxtBox.BackColor = value;
        this.Invalidate();
      }
    }

    [Category("Kpm Custom Properties")]
    public override Color ForeColor
    {
      get => base.ForeColor;
      set
      {
        base.ForeColor = value;
        TxtBox.ForeColor = value;
      }
    }

    [Category("Kpm Custom Properties")]
    public override Font Font
    {
      get => base.Font;
      set
      {
        base.Font = value;
        TxtBox.Font = value;
        if (this.DesignMode)
          UpdateControlHeight();
      }
    }

    [Category("Kpm Custom Properties")]
    public string Texts
    {
      get
      {
        if (isPlaceHolder)
          return "";
        return TxtBox.Text;
      }
      set
      {
        TxtBox.Text = value;
        isPlaceHolder = false;
        ForeColor = Color.FromArgb(29, 29, 27);
        SetPlaceHolder();
      }
    }

    [Category("Kpm Custom Properties")]
    public int BorderRadius
    {
      get => borderRadius;
      set
      {
        if (value >= 0)
        {
          borderRadius = value;
          this.Invalidate(); //Redraw control
        }
      }
    }

    [Category("Kpm Custom Properties")]
    public Color PlaceHolderColor
    {
      get => placeHolderColor;
      set
      {
        placeHolderColor = value;
        if (isPlaceHolder)
          TxtBox.ForeColor = value;
      }
    }

    [Category("Kpm Custom Properties")]
    public string PlaceHolderText
    {
      get => placeHolderText;
      set
      {
        placeHolderText = value;
        TxtBox.Text = "";
        SetPlaceHolder();
      }
    }

    private void SetPlaceHolder()
    {
      if (string.IsNullOrWhiteSpace(TxtBox.Text) && placeHolderText != "")
      {
        isPlaceHolder = true;
        TxtBox.Text = placeHolderText;
        TxtBox.ForeColor = placeHolderColor;

        if (isPasswordChar)
          TxtBox.UseSystemPasswordChar = false;
      }
    }

    private void RemovePlaceHolder()
    {
      if (isPlaceHolder && placeHolderText != "")
      {
        isPlaceHolder = false;
        TxtBox.Text = "";
        TxtBox.ForeColor = this.ForeColor;

        if (isPasswordChar)
          TxtBox.UseSystemPasswordChar = true;
      }
    }

    private static GraphicsPath GetFigurePath(RectangleF rect, int radius)
    {
      GraphicsPath path = new();
      float curveSize = radius * 2F;

      path.StartFigure();
      path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
      path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
      path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
      path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
      path.CloseFigure();
      return path;
    }

    //Overriden methods
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      Graphics graph = e.Graphics;

      if (borderRadius > 1) //Rounded TextBox
      {
        Rectangle rectBorderSmooth = this.ClientRectangle;
        Rectangle rectBorder = Rectangle.Inflate(rectBorderSmooth, -BorderSize, -BorderSize);
        int smoothSize = borderSize > 0 ? borderSize : 1;

        using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
        using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
        using (Pen penBorderSmooth = new(this.Parent.BackColor, smoothSize))
        using (Pen penBorder = new(borderColor, borderSize))
        {
          //Drawing
          this.Region = new(pathBorderSmooth); //Set the rounded region of UserControl
          if (borderRadius > 15)
            SetTextBoxRoundedRegion(); //Set the rounded region of TextBox component

          graph.SmoothingMode = SmoothingMode.AntiAlias;

          penBorder.Alignment = PenAlignment.Center;

          if (isFocused)
            penBorder.Color = BorderFocusColor;

          if (underlinedStyle) //Line Style
          {
            //Draw border smoothing
            graph.DrawPath(penBorderSmooth, pathBorderSmooth);

            //Draw border
            graph.SmoothingMode = SmoothingMode.None;
            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
          }
          else //Normal style
          {
            //Draw border smoothing
            graph.DrawPath(penBorderSmooth, pathBorderSmooth);

            //Draw border
            graph.DrawPath(penBorder, pathBorder);
          }

        }
      }
      else //Squere Normal TextBox
      {
        //Draw border
        using (Pen penBorder = new(borderColor, borderSize))
        {
          this.Region = new(this.ClientRectangle);
          penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

          if (isFocused)
            penBorder.Color = BorderFocusColor;

          if (underlinedStyle) //Line Style
            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
          else //Normal style
            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
        }
      }
    }

    private void SetTextBoxRoundedRegion()
    {
      GraphicsPath pathTxt;
      if (Multiline)
      {
        pathTxt = GetFigurePath(TxtBox.ClientRectangle, borderRadius - borderSize);
        TxtBox.Region = new(pathTxt);
      }
      else
      {
        pathTxt = GetFigurePath(TxtBox.ClientRectangle, borderSize * 2);
        TxtBox.Region = new(pathTxt);
      }
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      this.Invalidate();
      if (this.DesignMode)
        UpdateControlHeight();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateControlHeight();
    }

    //Private methods
    private void UpdateControlHeight()
    {
      if (TxtBox.Multiline == false)
      {
        int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
        TxtBox.Multiline = true;
        TxtBox.MinimumSize = new Size(0, txtHeight);
        TxtBox.Multiline = false;
        this.Height = TxtBox.Height + this.Padding.Top + this.Padding.Bottom;
      }
    }

    private void TxtBox_TextChanged(object sender, EventArgs e)
    {
      _TextChanged?.Invoke(sender, e);
    }

    private void TxtBox_Click(object sender, EventArgs e)
    {
      this.OnClick(e);
    }

    private void TxtBox_MouseEnter(object sender, EventArgs e)
    {
      this.OnMouseEnter(e);
    }

    private void TxtBox_MouseLeave(object sender, EventArgs e)
    {
      this.OnMouseLeave(e);
    }

    private void TxtBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.OnKeyPress(e);
    }

    private void TxtBox_Enter(object sender, EventArgs e)
    {
      isFocused = true;
      this.Invalidate();
      RemovePlaceHolder();
    }

    private void TxtBox_Leave(object sender, EventArgs e)
    {
      isFocused = false;
      this.Invalidate();
      SetPlaceHolder();
    }

    private void TxtBox_KeyDown(object sender, KeyEventArgs e)
    {
      this.OnKeyDown(e);
    }

    private void TxtBox_EnabledChanged(object sender, EventArgs e)
    {
      if (Enabled)
      {
        //MessageBox.Show("Ativo!!!: " + PlaceHolderText);
        BackColor = Color.White;
      } 
      else
      {
        //MessageBox.Show("Desativado!!!: " + PlaceHolderText);
        BackColor = Color.FromArgb(240, 240, 240);
      }
    }



    //BackColor = Color.FromArgb(240, 240, 240);
    //Anexar outros eventos aqui.
  }
}
