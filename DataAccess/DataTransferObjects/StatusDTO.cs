using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class StatusDTO
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public string StatusText { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsNew { get; set; }
        public bool IsDeleted { get; set; }
    }
}
