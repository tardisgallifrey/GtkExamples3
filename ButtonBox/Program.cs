using Gtk;

namespace ButtonBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            DemoButtonBox mybox = new DemoButtonBox();

            //Start the app in order to display windows   
            Application.Run();
        }
    }
}
