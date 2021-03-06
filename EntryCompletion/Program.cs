﻿using Gtk;

namespace EntryCompletionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            //Create new Window objects and do stuff
            Window myWin = new Window("Main Window");
            myWin.DeleteEvent += delegate { Application.Quit(); };

            //See the project Expander for an explanation
            DemoEntryCompletion dialog = new DemoEntryCompletion();
            dialog.Reparent(myWin);

            myWin.ShowAll();

            //Start the app in order to display windows   
            Application.Run();
        }
    }
}
