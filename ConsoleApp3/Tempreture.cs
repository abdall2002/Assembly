using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Tempreture: IComparable
    {
        private int _value;

        public Tempreture(int value)
        {
            _value = value;
        }
        public int Value => _value;

        public int CompareTo(object obj)
        {
            if(obj is null)
                return 1;
            var temp = obj as Tempreture;
            if(temp is null)
            {
                throw new ArgumentException("object is not a tempreture object");
            }
            return _value.CompareTo(temp.Value);
        }
    }
}
