using Gtk;

namespace CairoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init ();
			Window win = new Window ("Cairo with Gtk# 3");
			win.SetDefaultSize (400, 400);
			win.DeleteEvent += delegate { Application.Quit (); };
			win.Add (new CairoSample ());
			win.ShowAll ();
			Application.Run ();
        }
    }
}
