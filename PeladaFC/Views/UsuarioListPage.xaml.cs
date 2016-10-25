using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PeladaFC
{
	public partial class UsuarioListPage : ContentPage
	{
		public UsuarioListPage()
		{
			BindingContext = new UsuarioListViewModel();
			InitializeComponent();
		}

	}
}
