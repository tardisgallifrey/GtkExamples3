using Gtk;

namespace TextViewDemo
{
    public class Program
    {
                public static void Main(string[] args)
                {
                    Application.Init();

                    //Create new Window objects and do stuff
                    new DemoTextView();
        

                    //Start the app in order to display windows   
                    Application.Run();
                }
        
    }
}