using System;
using Xamarin.Forms;

namespace Actividad2
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Actividad2",
					XAlign = TextAlignment.End,
					YAlign = TextAlignment.End,
					TextColor = Color.Green
				},
			};
		}
	}
}

