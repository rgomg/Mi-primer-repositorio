using System;

using Xamarin.Forms;

namespace Actividad11
{
	public class App : Application
	{

		public App()
		{
			MainPage = new NavigationPage (new Contenido());
		}


	}
}

