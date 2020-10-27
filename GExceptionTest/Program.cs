// HelloWorld.cs - GTK Window class Test implementation
//
// Author: Mike Kestner <mkestner@speakeasy.net>
//
// (c) 2001-2002 Mike Kestner

//modified 10/27/2020
//moved from class definition to Program.cs definition
using Gtk;


namespace GExceptionTest
{

    class Program
    {
        public static int Main(string[] args)
        {
            Application.Init();
            Window win = new Window("GException");

            //This is a better way to handle the exception than the original
            try
            {
                win.SetIconFromFile("this.filename.does.not.exist");
                // Notreached, GException should throw on above call.

            }
            finally
            {
                Application.Quit();
            }


            return 0;
        }
    }
}
