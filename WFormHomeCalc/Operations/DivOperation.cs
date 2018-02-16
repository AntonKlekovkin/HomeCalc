using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFormHomeCalc.Interfaces;

namespace WFormHomeCalc.Operations
{
    class DivOperation : IOperation
    { 
        public string Name
        {
            get
            {
                return "div";
            }

        }

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => x / y);
        }
    }
}
