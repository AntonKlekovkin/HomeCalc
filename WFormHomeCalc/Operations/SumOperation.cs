using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFormHomeCalc.Interfaces;

namespace WFormHomeCalc.Operations
{
    class SumOperation : IOperation
    { 
        public string Name
        {
            get
            {
                return "sum";
            }

        }

        public double Exec(double[] args)
        {
            return args.Sum();
        }
    }
}
