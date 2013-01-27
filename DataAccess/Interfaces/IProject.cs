using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public interface IProject
    {
        List<ProjectDTO> GetAllProjects();
    }
}
