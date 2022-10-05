namespace AppEngSoft.Forms
{
  public partial class Venda : Form
  {
    public Venda()
    {
      InitializeComponent();

      for (int i = 0; i < 100; i++)
      {
        LabGrid.Rows.Add(new object[] { i, "Victor", "victortavi@gmail.com" });
      }
    }
  }
}
