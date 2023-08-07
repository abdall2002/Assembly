using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CException
{
    public class InvalidAddressExcption : Exception
    {
        public string Location { get; set; }

        public InvalidAddressExcption(string message) : base(message) 
        {
        }
    }
}
