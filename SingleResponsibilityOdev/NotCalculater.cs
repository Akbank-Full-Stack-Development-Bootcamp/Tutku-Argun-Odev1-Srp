using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityOdev
{
    class NotCalculater
    {
        public double Calculate(int not1, int not2)
        {
            double result = (not1 * 0.4) + (not2 * 0.6);
            return result;
        }
    }
}
