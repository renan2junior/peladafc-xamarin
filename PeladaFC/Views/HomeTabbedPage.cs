using System;

using Xamarin.Forms;

namespace PeladaFC
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage()
		{
			UsuarioListPage telaUsuario = new UsuarioListPage();
			TimeListPage telaTime = new TimeListPage();

			this.Children.Add(telaUsuario);
			this.Children.Add(telaTime);
		}
	}
}

