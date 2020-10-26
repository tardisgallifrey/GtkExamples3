using Gtk;

namespace CustomWidget
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init ();
		    Window win = new Window ("Custom Widget Test");
		    win.DeleteEvent += new DeleteEventHandler (OnQuit);
		
		    VPaned paned = new VPaned ();
		    CustomWidget cw = new CustomWidget ();
		    cw.Label = "This one contains a button";
		    Button button = new Button ("Ordinary button");
		    cw.Add (button);
		    paned.Pack1 (cw, true, false);

		    cw = new CustomWidget ();
		    cw.Label = "And this one a TextView";
		    cw.StockId = Stock.JustifyLeft;
		    ScrolledWindow sw = new ScrolledWindow (null, null);
		    sw.ShadowType = ShadowType.In;
		    sw.HscrollbarPolicy = PolicyType.Automatic;
		    sw.VscrollbarPolicy = PolicyType.Automatic;
		    TextView textView = new TextView ();
		    sw.Add (textView);
		    cw.Add (sw);
		    paned.Pack2 (cw, true, false);
		
		    win.Add (paned);
		    win.ShowAll ();
		    Application.Run ();
	    }

	    static void OnQuit (object sender, DeleteEventArgs args)
	    {
		    Application.Quit ();
	    }
    
    }
}
