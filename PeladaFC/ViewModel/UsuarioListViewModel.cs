using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace PeladaFC
{
	public class UsuarioListViewModel
	{
		public static UsuarioManager Umanager { get; set; }
		private ObservableCollection<Usuario> usuarios;
		public ObservableCollection<Usuario> Usuarios
		{
			get
			{
				if (usuarios == null) {
					PegaUsuarios();		
				}
				
				return usuarios;
			}
			set
			{
				usuarios = value;
			}
		}

		protected async void PegaUsuarios()
		{
			List<Usuario> lista = await Umanager.GetUsuariosAsync();
			usuarios = new ObservableCollection<Usuario>(lista);
		}


		public UsuarioListViewModel()
		{
			Umanager = new UsuarioManager(new UsuarioWS());
			PegaUsuarios();
		}

	}
}
