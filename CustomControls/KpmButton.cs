using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace AppEngSoft.CustomControls
{
  public partial class KpmButton : Button
  {
    private int borderSize = 0;
    private int borderRadius = 10;
    private Color borderColor = Color.FromArgb(30, 133, 111);

    [Category("Custom properties")]
    public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

    [Category("Custom properties")]
    public int BorderRadius
    {
      get => borderRadius; 

      set
      {
        borderRadius = value <= this.Height ? value : this.Height;
        this.Invalidate();
      }
    }

    [Category("Custom properties")]
    public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }

    [Category("Custom properties")]
    public Color BackgroundColor { get => this.BackColor; set => this.BackColor = value; }

    [Category("Custom properties")]
    public Color TextColor { get => this.ForeColor; set => this.ForeColor = value; }

    public KpmButton()
    {
      this.FlatStyle = FlatStyle.Flat;
      this.FlatAppearance.BorderSize = 0;
      this.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 209, 174);
      this.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 109, 92);
      this.Size = new(150, 40);
      this.BackColor = Color.FromArgb(30, 133, 111);
      this.ForeColor = Color.FromArgb(255, 255, 255);
      this.Font = new Font("JetBrains Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
      this.Resize += new EventHandler(Button_Resize);
      this.Margin = new Padding(0);
    }

    private void Button_Resize(object? sender, EventArgs e)
    {
      if(borderRadius > this.Height)
        BorderRadius = this.Height; 
    }

    private static GraphicsPath GetFigurePath(RectangleF rect, float radius)
    {
      GraphicsPath path = new();
      path.StartFigure();
      path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
      path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
      path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
      path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
      path.CloseFigure();
      return path;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
      base.OnPaint(pevent);
      pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      RectangleF rectSurface = new(0, 0, this.Width, this.Height);
      RectangleF rectBorder = new(1, 1, this.Width - 0.8F, this.Height - 1);

      if (borderRadius > 2)
      {
        using GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius);
        using GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F);
        using Pen penSurface = new(this.Parent.BackColor, 2);
        using Pen penBorder = new(borderColor, borderSize);
        penBorder.Alignment = PenAlignment.Inset;
        this.Region = new(pathSurface);

        //Draw surface border for HD result
        pevent.Graphics.DrawPath(penSurface, pathSurface);

        //Button border
        if (borderSize >= 1)
          //Draw control border
          pevent.Graphics.DrawPath(penBorder, pathBorder);
      }
      else //Normal button
      {
        //Button surface
        this.Region = new(rectSurface);
        //Button border
        if (borderSize >= 1)
        {
          using Pen penBorder = new(borderColor, borderSize);
          penBorder.Alignment = PenAlignment.Inset;
          pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
        }
      }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
      base.OnHandleCreated(e);
      this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
    }

    private void Container_BackColorChanged(object? sender, EventArgs e)
    {
      if (this.DesignMode)
        this.Invalidate();
    }
  }
}
