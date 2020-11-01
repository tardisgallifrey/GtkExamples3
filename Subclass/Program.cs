using Gtk;
using System;


namespace Subclass
{
    public class Program
    {
        public static int Main (string[] args)
		{
			Application.Init ();
			Window win = new Window ("Button Tester");
			win.SetDefaultSize(400,200);
			win.DeleteEvent += new DeleteEventHandler (Quit);
			Button btn = new MyButton ();
			win.Add (btn);
			win.ShowAll ();
			Application.Run ();
			return 0;
		}

		static void Quit (object sender, DeleteEventArgs args)
		{
			Application.Quit();
		}
    }
}