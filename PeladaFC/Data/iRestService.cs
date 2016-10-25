using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeladaFC
{
	public interface iRestService<T>
	{
		Task<List<T>> RefreshDataAsync();
		Task SaveDataObjAsync(T obj, bool isNewItem);
		Task DeleteObjAsync(string id);
	}
}
