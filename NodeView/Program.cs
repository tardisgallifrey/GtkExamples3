using Gtk;
using System;

//This is a useful app
//Shows all the namespaces and 
//classes in the system.

namespace DemoNodeView
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
			Application.Init ();
			Gtk.Window win = new NodeViewDemo ();	
			win.ShowAll ();
			Console.WriteLine (DemoTreeNode.Count + " nodes created.");
			Console.WriteLine ("startup time: " + DateTime.Now.Subtract (start));
			Application.Run ();
        }
    }
}
