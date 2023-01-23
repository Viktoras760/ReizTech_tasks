using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_task
{
    class Branch
    {
        public List<Branch> branches;
        public Branch()
        {
            branches = new List<Branch>();
        }
    }
}
