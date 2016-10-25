using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeladaFC
{
	public class TimeManager
	{

		iRestService<Time> restService;

		public TimeManager(iRestService<Time> service)
		{
			restService = service;
		}

		public Task<List<Time>> GetTimesAsync()
		{
			return restService.RefreshDataAsync();
		}
	}
}
