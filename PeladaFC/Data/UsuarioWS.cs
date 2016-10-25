using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PeladaFC
{
	public class UsuarioWS : iRestServiceUsuario
	{
		HttpClient client;
		public List<Usuario> Usuarios { get; set; }

		public UsuarioWS()
		{
			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
		}

		public Task DeleteTimeAsync(string id)
		{
			throw new NotImplementedException();
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

		public Task SaveDataTimeAsync(Usuario usuario, bool isNewItem)
		{
			throw new NotImplementedException();
		}
	}
}
