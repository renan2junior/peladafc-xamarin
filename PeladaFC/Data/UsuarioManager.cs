using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PeladaFC
{
	public class UsuarioManager
	{
		iRestService<Usuario> restService;

		public UsuarioManager(iRestService<Usuario> restService)
		{
			this.restService = restService;
		}

		public Task<List<Usuario>> GetUsuariosAsync() {
			return restService.RefreshDataAsync();
		}
	}
}
