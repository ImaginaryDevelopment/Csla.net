using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace DataAccess
{
    /// <summary>
    /// Author: Dean Bortell 01/26/2013 Main body used in CSLA examples.
    /// This will be a common exception thrown by any concrete DAL such as the DalMock or DalSql projects.
    /// </summary>
    [Serializable]
    public class DataNotFoundException : Exception
    {
        public DataNotFoundException(string message)
            : base(message)
        { }

        public DataNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        { }

        protected DataNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        { }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(
          System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
