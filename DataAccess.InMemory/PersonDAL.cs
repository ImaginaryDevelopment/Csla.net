namespace DataAccess.InMemory
{
	using System;
	using System.Collections.Generic;
	using System.Data.SqlClient;
	using System.Diagnostics;
	using System.Linq;
	using DataAccess;
	using FizzWare.NBuilder;

	public class PersonDAL : IPersonDAL
	{

		static readonly IList<PersonDTO> Data;

		static PersonDAL()
		{
			Data = Builder<PersonDTO>.CreateListOfSize(5)
				.Build();

		}

		public List<PersonDTO> Fetch()
		{

			var result = Data.ToArray().ToList();
			Debug.Assert(ReferenceEquals(result, Data) == false);
			return result;
		}

		public PersonDTO Fetch(int id)
		{
			return Data.FirstOrDefault(a => a.ID == id);
		}

		public PersonDTO Update(PersonDTO data)
		{

			data.DateLastUpdated = DateTime.Now;

			//if it is deleted enter here because we still have the 'IsNew' to figure in later
			if (data.IsDeleted)
			{
				//new data won't be in the database so save the work and 'do nothing' ;)
				if (!data.IsNew)
				{

					//delete the data actually we mark notactive in db to preserve past entries :)
					data.IsActive = false;
					data.IsNew = false;
					var existing = Data.FirstOrDefault(a => a.ID == data.ID);
					if (existing == null)
						throw new DataNotFoundException("DeletePerson failed");
					Data.Remove(existing);
					Data.Add(data);
				}
				//reset the primary key either way ?
				//data.ID = -1;
			}
			//otherwise maybe it is new
			else if (data.IsNew)
			{
				//set primary key to database-generated (here scope_identity) value
				var maxId = Data.Max(a => a.ID) + 1;
				data.ID = maxId;
				data.IsNew = false;
				data.IsDeleted = false;
				Data.Add(data);
			}
			//end of logic tree.  It is an update.
			else
			{
				//update the data
				var existing = Data.FirstOrDefault(a => a.ID == data.ID);
				if (existing == null)
				{
					throw new DataNotFoundException("UpdatePerson failed");
				}

				data.IsNew = false;
				data.IsDeleted = false;
				Data.Add(data);
			}

			return data;
		}

	}
}

