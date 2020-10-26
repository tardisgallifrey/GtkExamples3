using Gtk;

namespace CustomScrollableWidget
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init ();
			Window win = new Window ("Custom Scrollable Widget Test");
			win.DeleteEvent += new DeleteEventHandler (OnQuit);
		
			VPaned paned = new VPaned ();
		
			ScrolledWindow scroll = new ScrolledWindow ();
			scroll.HscrollbarPolicy = PolicyType.Automatic;
			scroll.VscrollbarPolicy = PolicyType.Automatic;
		
			var cw = new DerivedScrollableWidget<string> ("This one label that is repeated");
			scroll.Add (cw);
			paned.Pack1 (scroll, true, false);

			scroll = new ScrolledWindow ();
			scroll.HscrollbarPolicy = PolicyType.Automatic;
			scroll.VscrollbarPolicy = PolicyType.Automatic;
		
			var cw2 = new DerivedScrollableWidget<object> ("Another label that is repeated");
			scroll.Add (cw2);
			paned.Pack2 (scroll, true, false);

			win.Add (paned);
			win.DefaultWidth = 600;
			win.DefaultHeight = 400;
			win.ShowAll ();
			Application.Run ();
			
        }

        static void OnQuit (object sender, DeleteEventArgs args)
	    {
		    Application.Quit ();
	    }
    }
}
