using Gtk;

namespace ExpanderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();


            //Create new Window objects and do stuff
            Window myWin = new Window("Main Window");
            myWin.DeleteEvent += delegate { Application.Quit(); };
            
            
            DemoExpander dialog = new DemoExpander();

            //It may be obsolete, but I didn't find a better way
            //Dialog will open first.
            //Close dialog and parent window will open.
            //Close parent to quit
            dialog.Reparent(myWin);

            myWin.ShowAll();
        

            //Start the app in order to display windows   
            Application.Run();
        }
    }
}
