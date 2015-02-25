using System;
using Xamarin.Forms;

namespace Actividad4
{
	public class App
	{
		public static Page GetMainPage ()
		{    
			Label label = new Label{

				Text = "Utilizando inicializadores de objetos en lugar de propiedades",
				TextColor = Color.Red,
				YAlign = TextAlignment.Center};

			ContentPage contentPage = new ContentPage();
			contentPage.Content = label;

			return contentPage;

		}
	}

}

