using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    using System.Collections;

    internal class WorkersArray : IEnumerable
    {
        private WorkerBasic[] workersArray;

        public WorkersArray(WorkerBasic[] workersArray)
        {
            this.workersArray = new WorkerBasic[workersArray.Length];
            Array.Copy(workersArray, this.workersArray, workersArray.Length);
        }

        public IEnumerator GetEnumerator()
        {
            return this.workersArray.GetEnumerator();
        }
    }
}
