using Gtk;

namespace HelloWorld
{
    class Program
    {
        public static int Main (string[] args)
		{
			Application.Init ();
			Window win = new Window ("Gtk# Hello World");
			win.DeleteEvent += new DeleteEventHandler (Window_Delete);
			win.ShowAll ();
			Application.Run ();
			return 0;
		}

		static void Window_Delete (object obj, DeleteEventArgs args)
		{
			Application.Quit ();
			args.RetVal = true;
		}
    }
}
