using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class StatusUpdateDTO
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int ProjectID { get; set; }
        public int StatusID { get; set; }
        public int IncidentID { get; set; }
        public int RequestID { get; set; }
        public int ChangeID { get; set; }
        public string StatusText { get; set; }
        public DateTime DatePerformed { get; set; }
        public DateTime DateRecorded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsNew { get; set; }
        public bool IsDeleted { get; set; }
    }
}
