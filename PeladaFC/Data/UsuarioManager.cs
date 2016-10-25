using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PeladaFC
{
	public class UsuarioManager
	{
		iRestServiceUsuario restService;

		public UsuarioManager(iRestServiceUsuario restService)
		{
			this.restService = restService;
		}

		public Task<List<Usuario>> GetUsuariosAsync() {
			return restService.RefreshDataAsync();
		}
	}
}
