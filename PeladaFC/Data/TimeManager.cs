using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeladaFC
{
	public class TimeManager
	{

		iRestService restService;

		public TimeManager(iRestService service)
		{
			restService = service;
		}

		public Task<List<Time>> GetTimesAsync()
		{
			return restService.RefreshDataAsync();
		}
	}
}
