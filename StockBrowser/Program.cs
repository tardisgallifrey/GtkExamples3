using Gtk;


namespace StockBrowser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application.Init();

            //Create new Window objects and do stuff
            new DemoStockBrowser();


            //Start the app in order to display windows   
            Application.Run();
        }

    }
}