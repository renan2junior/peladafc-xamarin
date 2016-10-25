using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace PeladaFC
{
	public class UsuarioListViewModel : INotifyPropertyChanged
	{
		public static UsuarioManager Umanager { get; set; }
		private ObservableCollection<Usuario> usuarios;

		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<Usuario> Usuarios
		{
			get
			{

				return usuarios;

			}
			set
			{
				if (value != usuarios)
				{
					usuarios = value;
					OnProPertyChanged("Usuarios");
				}

			}
		}

		protected async void PegaUsuarios()
		{
			Usuarios = new ObservableCollection<Usuario>(await Umanager.GetUsuariosAsync());
		}


		public UsuarioListViewModel()
		{
			Umanager = new UsuarioManager(new UsuarioWS());
			PegaUsuarios();
			/*
			Usuario u = new Usuario();
			u.Id = "1";
			u.Nome = "Joao";
			Time t = new Time();
			t.ID = "1";
			t.Nome = "Botafogo";
			u.Time = t;
			
			Usuarios = new ObservableCollection<Usuario>();
			Usuarios.Add(u);
			*/

		}

		private void OnProPertyChanged(string nome) {
			PropertyChanged(this, new PropertyChangedEventArgs(nome));
		}


	}
}
