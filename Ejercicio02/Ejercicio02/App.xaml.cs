using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Ejercicio02
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new TabbedPage1();

            MainPage = new NavigationPage(new MainPage());
            //MainPage = new MasterDetailPage1();
            //MainPage = new CarouselPage1();
            //MainPage = new TabbedPage1();
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new TabbedPageExample();
            //MainPage = new CarouselExamplexaml();

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
