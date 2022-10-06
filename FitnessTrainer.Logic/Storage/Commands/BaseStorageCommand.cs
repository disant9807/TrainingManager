using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Storage;

namespace TrainingManager.Logic.Storage.Commands
{
	public abstract class BaseStorageCommand
	{
		protected readonly StorageContext context;
		public BaseStorageCommand(StorageContext context)
		{
			this.context = context;
		}
		public abstract Task ExecuteAsync();
	}
}
