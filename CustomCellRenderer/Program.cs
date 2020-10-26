using Gtk;

namespace CellRendererDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init ();
			Window myWin = new Driver();
            myWin.DeleteEvent += delegate{ Application.Quit(); };
            myWin.ShowAll();
			Application.Run ();
        }
    }
}
