using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.InMemory
{
	using System.Diagnostics;

	using FizzWare.NBuilder;

	public class StatusDAL
	{
		static readonly IList<StatusDTO> Data;

		static StatusDAL()
		{
			Data = Builder<StatusDTO>.CreateListOfSize(5)
				.Build();

		}

		public List<StatusDTO> GetAllStatus()
		{
			var result = Data.ToArray().ToList();
			Debug.Assert(ReferenceEquals(result, Data) == false);
			return result;
		}

		 
	}
}
