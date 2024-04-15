using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    public class DefektException : Exception
    {
        public DefektException(string message) : base(message)
        { 
        
        }
    }
}
