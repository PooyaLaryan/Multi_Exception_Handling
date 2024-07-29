using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    internal class CustomException1 : Exception
    {
        public override string Message => "Exception 1";
    }
}
