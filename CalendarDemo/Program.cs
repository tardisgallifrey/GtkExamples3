using System;
using Gtk;

namespace CalendarDemo
{
    class Program
    {

		public static int Main (string[] args)
		{
			Application.Init ();
			Window win = new Window ("Calendar Tester");
			win.DefaultWidth = 200;
			win.DefaultHeight = 150;
			win.DeleteEvent += new DeleteEventHandler (Window_Delete);
			Calendar cal = CreateCalendar();
			cal.DaySelected += new EventHandler (DaySelected);
			win.Add (cal);
			win.ShowAll ();
			Application.Run ();
			return 0;
		}

		static void DaySelected (object obj, EventArgs args)
		{
			Calendar activatedCalendar = (Calendar) obj;
			Console.WriteLine (activatedCalendar.GetDate ().ToString ("yyyy/MM/dd"));
		}

		static void Window_Delete (object obj, DeleteEventArgs args)
		{
			Application.Quit ();
			args.RetVal = true;
		}

        public static Calendar CreateCalendar ()
		{
			Calendar cal = new Calendar();
			cal.DisplayOptions = CalendarDisplayOptions.ShowHeading    |
					     		 CalendarDisplayOptions.ShowDayNames   |
					     		 CalendarDisplayOptions.ShowWeekNumbers;
			return cal;
		}
    }
}
