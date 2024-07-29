using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    internal class CustomException2 : Exception
    {
        public override string Message => "Exception 2";
    }
}
