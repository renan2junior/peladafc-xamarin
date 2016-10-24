using Xamarin.Forms;

namespace PeladaFC
{
	public partial class App : Application
	{

		public static TimeManager Tmanager { get; set; }

		public App()
		{
			Tmanager = new TimeManager(new RestService());

			InitializeComponent();

			MainPage = new TimeListPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
