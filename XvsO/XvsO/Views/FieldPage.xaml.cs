using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XvsO
{
	public partial class FieldPage : ContentPage
	{
		public FieldPage ()
		{
			InitializeComponent ();
			BindingContext = new FieldViewModel ();
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
		}
	}
}

