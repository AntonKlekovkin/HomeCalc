using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFormHomeCalc.Interfaces;

namespace Google.Credit
{
    public class CreditOperation : IOperation
    {
        public string Name => "credit";
        

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => x*1.095 / y);
        }
    }
}
