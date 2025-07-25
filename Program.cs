namespace soccer_csharp;

internal class Program
{
  private static void Main(string[] args)
  {
    MenuPrincipal menu = new MenuPrincipal();
    menu.MostrarBienvenida();
    menu.EjecutarMenuMain();
  }
}