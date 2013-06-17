using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.InMemory
{
	using System.Diagnostics;

	using FizzWare.NBuilder;

	public class RolesDAL:IRoles
	{
		static readonly IList<RolesDTO> Data;

		static RolesDAL()
		{
			Data = Builder<RolesDTO>.CreateListOfSize(5)
				.Build();

		}

		public List<RolesDTO> GetAllRoles()
		{
			var result = Data.ToArray().ToList();
			Debug.Assert(ReferenceEquals(result, Data) == false);
			return result;
		}
	}
}
