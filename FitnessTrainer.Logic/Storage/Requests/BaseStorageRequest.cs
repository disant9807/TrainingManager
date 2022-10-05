using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Storage.Requests
{
	public abstract class BaseStorageRequest<T>
	{
		protected readonly StorageContext context;
		public BaseStorageRequest(StorageContext context)
		{
			this.context = context;
		}
		public abstract Task<T> ExecuteAsync();
	}
}
