using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Hello, Forms!",
					BackgroundColor = Color.White,
					TextColor = Color.Green,
					VerticalOptions = LayoutOptions.End,
					HorizontalOptions = LayoutOptions.StartAndExpand,
				},
			};
		}
	}
}
	