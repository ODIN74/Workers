using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class WorkersArray
    {
        private WorkerBasic[] workersArray;

        public WorkersArray(WorkerBasic[] workersArray)
        {
            this.workersArray = workersArray;
        }

        public WorkerBasic this[int i]
        {
            get => workersArray[i];
            set
            {
                workersArray[i] = value;
            }
        }
    }
}
