using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Hvac.Views
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Hvac.IO Home Page!" }
				}
			};
		}
	}
}