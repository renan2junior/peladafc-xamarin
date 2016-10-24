using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeladaFC
{
	public interface iRestService
	{
		Task<List<Time>> RefreshDataAsync();

		Task SaveDataTimeAsync(Time time, bool isNewItem);

		Task DeleteTimeAsync(string id);
	}
}
