using System;
using Gtk;

namespace Scribble
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init ();
			Window win = new Window ("Scribble");
			win.DeleteEvent += delegate { Application.Quit (); };
			win.BorderWidth = 8;
			Frame frm = new Frame (null);
			frm.ShadowType = ShadowType.In;
			frm.Add (new ScribbleArea ());
			win.Add (frm);
			win.ShowAll ();
			Application.Run ();
        }
    }
}
