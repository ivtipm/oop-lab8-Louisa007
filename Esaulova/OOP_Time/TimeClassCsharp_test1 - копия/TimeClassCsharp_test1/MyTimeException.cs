using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClassCsharp_test1
{
    public class MyTimeException: Exception
    {
        public MyTimeException(string message) : base(message)
        {

        }
    }
}
