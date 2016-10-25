using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;

namespace PeladaFC
{
	public class RestService : iRestService<Time>
	{
		HttpClient client;
		public List<Time> Times { get; set; }

		public RestService()
		{
			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
		}

		public async Task<List<Time>> RefreshDataAsync()
		{
				Times = new List<Time>();
				var uri = new Uri(string.Format(Constants.RestUrl+"time/", string.Empty));
				try
				{
					var response = await client.GetAsync(uri);
					if (response.IsSuccessStatusCode)
					{
						var content = await response.Content.ReadAsStringAsync();
						Times = JsonConvert.DeserializeObject<List<Time>>(content);
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(@"ERROR {0}", ex.Message);
				}
				return Times;
		}

		public Task SaveDataObjAsync(Time obj, bool isNewItem)
		{
			throw new NotImplementedException();
		}

		public Task DeleteObjAsync(string id)
		{
			throw new NotImplementedException();
		}
	}
}
