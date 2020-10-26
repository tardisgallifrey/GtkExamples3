using Gtk;

namespace AssistantSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            //Create new Window objects and do stuff
            new SampleAssistant();
        

            //Start the app in order to display windows   
            Application.Run();
        }
    }
}
