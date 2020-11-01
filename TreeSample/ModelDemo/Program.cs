using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using Gtk;


namespace TreeSample.ModelDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Application.Init();
            Gtk.Window win = new TreeModelDemo();
            win.DeleteEvent += delegate { Application.Quit(); };
            win.Show();
            Application.Run();
        }

    }
}