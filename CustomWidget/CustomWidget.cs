using Gtk;
using Gdk;
using System;

namespace CustomWidget
{

	class CustomWidget : Bin 
	{
		private Pixbuf icon;
		private string label;
		private Pango.Layout layout;
		private string stockid;

		public CustomWidget () : base ()
		{
			icon = null;
			label = "CustomWidget";
			layout = null;
			stockid = Stock.Execute;
		
			HasWindow = false;
		}

		private Pixbuf Icon 
		{
			get 
			{
				if (icon == null)
				{
					icon = RenderIconPixbuf (stockid, IconSize.Menu);
				}
			
				return icon;
			}
		}

		public string Label 
		{
			get 
			{
				return label;
			}

			set 
			{
				label = value;
				Layout.SetText (label);
			}
		}

		private Pango.Layout Layout 
		{
			get 
			{
				if (layout == null)
				{
					layout = CreatePangoLayout (label);
				}
			
				return layout;
			}
		}

		public string StockId 
		{
			get 
			{
				return stockid;
			}

			set 
			{
				stockid = value;
				icon = RenderIconPixbuf (stockid, IconSize.Menu);
			}
		}

		private Gdk.Rectangle TitleArea 
		{
			get 
			{
				Rectangle area;
				area.X = Allocation.X + (int)BorderWidth;
				area.Y = Allocation.Y + (int)BorderWidth;
				area.Width = (Allocation.Width - 2 * (int)BorderWidth);
			
				int layoutWidth, layoutHeight;
				Layout.GetPixelSize (out layoutWidth, out layoutHeight);
				area.Height = Math.Max (layoutHeight, icon.Height);
			
				return area;
			}
		}

		protected override bool OnDrawn (Cairo.Context cr)
		{
			Rectangle titleArea = TitleArea;

			//The namespace is required here because of 
			//Gtk.CairoHelper & Gdk.CairoHelper
			Gdk.CairoHelper.SetSourcePixbuf (cr, Icon, 0, 0);
			cr.Paint ();
		
			int layout_x = icon.Width + 1;
			titleArea.Width -= icon.Width - 1;
		
			int layoutWidth, layoutHeight;
			Layout.GetPixelSize (out layoutWidth, out layoutHeight);
		
			int layout_y = (titleArea.Height - layoutHeight) / 2;
		
			StyleContext.RenderLayout (cr, layout_x, layout_y, Layout);
	
			return base.OnDrawn (cr);
		}

		protected override void OnSizeAllocated (Gdk.Rectangle allocation)
		{
			base.OnSizeAllocated (allocation);
	
			int bw = (int)BorderWidth;

			Rectangle titleArea = TitleArea;

			if (Child != null) 
			{
				Rectangle childAllocation;
				childAllocation.X = allocation.X + bw;
				childAllocation.Y = allocation.Y + bw + titleArea.Height;
				childAllocation.Width = allocation.Width - 2 * bw;
				childAllocation.Height = allocation.Height - 2 * bw - titleArea.Height;
				Child.SizeAllocate (childAllocation);
			}
		}

        protected override void OnGetPreferredWidth(out int minimum_width, out int natural_width)
        {
            minimum_width = natural_width = (int)BorderWidth * 2 + Icon.Width + 1;
            int layoutWidth, layoutHeight;
            Layout.GetPixelSize(out layoutWidth, out layoutHeight);

            if (Child != null && Child.Visible)
            {
                int child_min_width, child_nat_width;
                Child.GetPreferredWidth(out child_min_width, out child_nat_width);

                minimum_width += Math.Max(layoutWidth, child_min_width);
                natural_width += Math.Max(layoutWidth, child_nat_width);
            }
            else
            {
                minimum_width += layoutWidth;
                natural_width += layoutWidth;
            }
        }

        protected override void OnGetPreferredHeight(out int minimum_height, out int natural_height)
        {
            minimum_height = natural_height = (int)BorderWidth * 2;

            int layoutWidth, layoutHeight;
            Layout.GetPixelSize(out layoutWidth, out layoutHeight);
            minimum_height += layoutHeight;
            natural_height += layoutHeight;

            if (Child != null && Child.Visible)
            {
                int child_min_height, child_nat_height;
                Child.GetPreferredHeight(out child_min_height, out child_nat_height);

                minimum_height += Math.Max(layoutHeight, child_min_height);
                natural_height += Math.Max(layoutHeight, child_nat_height);
            }
        }
	}
}