using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PeladaFC
{
	public partial class UsuarioListPage : ContentPage
	{
		public UsuarioListPage()
		{
			InitializeComponent();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			listView.ItemsSource = await App.Umanager.GetUsuariosAsync();
		}
	}
}
