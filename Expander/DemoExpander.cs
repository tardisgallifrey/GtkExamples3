/* Expander
 *
 * GtkExpander allows to provide additional content that is initially hidden.
 * This is also known as "disclosure triangle".
 *
 */
using System;
using Gtk;

namespace ExpanderDemo
{
	[Demo ("Expander", "DemoExpander.cs")]
	public class DemoExpander : Gtk.Dialog
	{
		public DemoExpander () : base ("Demo Expander", null, DialogFlags.Modal)
		{
			Resizable = false;

			VBox vbox = new VBox (false, 5);
			this.ContentArea.PackStart (vbox, true, true, 0);
			vbox.BorderWidth = 5;

			vbox.PackStart (new Label ("Expander demo. Click on the triangle for details."), false, false, 0);

			// Create the expander
			Expander expander = new Expander ("Details");
			expander.Add (new Label ("Details can be shown or hidden."));
			vbox.PackStart (expander, false, false, 0);

			AddButton (Stock.Close, ResponseType.Close);

			ShowAll ();
			this.Run ();
			this.Dispose(true);
		}
	}
}

