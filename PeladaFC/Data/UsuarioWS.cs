using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PeladaFC
{
	public class UsuarioWS : iRestService<Usuario>
	{
		HttpClient client;
		public List<Usuario> Usuarios { get; set; }

		public UsuarioWS()
		{
			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
		}

		public async Task<List<Usuario>> RefreshDataAsync()
		{
			Usuarios = new List<Usuario>();
			var uri = new Uri(string.Format(Constants.RestUrl + "usuario/", string.Empty));

			try
			{
				var response =  await client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					Usuarios = JsonConvert.DeserializeObject<List<Usuario>>(content);

				}
			}
			catch (Exception e)
			{
				Debug.WriteLine(@"ERROR {0}", e.Message);	
			}
			return Usuarios;
		}

		public Task SaveDataObjAsync(Usuario obj, bool isNewItem)
		{
			throw new NotImplementedException();
		}

		public Task DeleteObjAsync(string id)
		{
			throw new NotImplementedException();
		}
	}
}
