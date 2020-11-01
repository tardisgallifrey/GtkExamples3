using Gtk;


namespace SpinnerDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application.Init();
            Window myWin = new DemoSpinner();
            myWin.DeleteEvent += delegate { Application.Quit(); };
            myWin.ShowAll();
            Application.Run();
                }

    }
}