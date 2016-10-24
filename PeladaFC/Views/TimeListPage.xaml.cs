using Xamarin.Forms;

namespace PeladaFC
{
	public partial class TimeListPage : ContentPage
	{

		public TimeListPage()
		{
			InitializeComponent();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			listView.ItemsSource = await App.Tmanager.GetTimesAsync();
		}
	}
}
