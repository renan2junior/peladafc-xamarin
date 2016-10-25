using Xamarin.Forms;

namespace PeladaFC
{
	public partial class App : Application
	{

		public static TimeManager Tmanager { get; set; }
		public static UsuarioManager Umanager { get; set; }

		public App()
		{
			Tmanager = new TimeManager(new RestService());
			Umanager = new UsuarioManager(new UsuarioWS());
			InitializeComponent();

			MainPage = new HomeTabbedPage();
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
