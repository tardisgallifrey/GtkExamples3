using Gtk;

namespace DialogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init ();
			new DemoDialog();
			Application.Run ();
        }
    }
}
