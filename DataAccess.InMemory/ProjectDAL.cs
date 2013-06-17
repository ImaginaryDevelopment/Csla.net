using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.InMemory
{
	using System.Diagnostics;

	using FizzWare.NBuilder;

	public class ProjectDAL : IProject
	{

		static readonly IList<ProjectDTO> Data;

		static ProjectDAL()
		{
			Data = Builder<ProjectDTO>.CreateListOfSize(5)
				.Build();

		}

		public List<ProjectDTO> GetAllProjects()
		{
			var result = Data.ToArray().ToList();
			Debug.Assert(ReferenceEquals(result, Data) == false);
			return result;
		}
	}
}
