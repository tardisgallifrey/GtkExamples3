using Gtk;

namespace EntryCompletionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            //Create new Window objects and do stuff

            //This one will not Quit() correctly
            //Ctrl-C to quit after closing.
            new DemoEntryCompletion();

            //Start the app in order to display windows   
            Application.Run();
        }
    }
}
