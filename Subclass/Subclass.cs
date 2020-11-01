// Subclass.cs - Widget subclass Test 
//
// Author: Mike Kestner <mkestner@ximian.com>
//
// (c) 2001-2003 Mike Kestner, Novell, Inc.


using Gtk;
using System;

//Was supposed to be a class about Subclasses,
//But I think they were doing it with the main loop 
//as the subclass, which isn't done like that (as I learned anyway)

//However, it is a good lesson on Gdk button binding features.

namespace Subclass
{
        [Binding(Gdk.Key.Escape, "HandleBinding", "Escape")]
        [Binding(Gdk.Key.Left, "HandleBinding", "Left")]
        [Binding(Gdk.Key.Right, "HandleBinding", "Right")]
        [Binding(Gdk.Key.Up, "HandleBinding", "Up")]
        [Binding(Gdk.Key.Down, "HandleBinding", "Down")]
        public class MyButton : Gtk.Button
        {

            public MyButton() : base("I'm a base class button") { }

            protected override void OnClicked()
            {
                Console.WriteLine("Button::Clicked default handler fired.");
            }

            private void HandleBinding(string text)
            {
                //Switch-Case could be used here to take action upon bound buttons.
                Console.WriteLine("Got a bound keypress: " + text);
            }
        }
    
}
