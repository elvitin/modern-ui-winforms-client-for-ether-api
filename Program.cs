using AppEngSoft.Presenters;
using AppEngSoft.Views;

namespace AppEngSoft
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      /*
      ApplicationConfiguration.Initialize();
      Application.Run(new FormPrincipal());
      */

      
      //string stringConexao = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
      ApplicationConfiguration.Initialize();
      IPrincipalView view = new PrincipalView();
      new PrincipalPresenter(view, "");
      Application.Run((Form)view);
    }
  }
}