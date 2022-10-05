namespace AppEngSoft.Forms
{
  public partial class Cliente : Form
  {
    public Cliente()
    {
      InitializeComponent();

      for (int i = 0; i < 100; i++)
      {
        LabGrid.Rows.Add(new object[] { i, "Victor", "victortavi@gmail.com" });
      }
    }
  }
}
