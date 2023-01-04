using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDataEntities.GeneralEntities
{
    public abstract class Base
    {
        public OperationTypes OperationType { get; set; }
        public DateTime OperationDate { get; set; }
    }

    public enum OperationTypes
    {
        Unknown = 0,
        Added = 1,
        Updated = 2,
        Deleted = 3,
    }
}
