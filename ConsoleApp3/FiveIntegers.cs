using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class FiveIntegers : IEnumerable
    {
        int[] _value;

        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            _value = new int[] {n1, n2, n3, n4, n5};
        }

        //public IEnumerator GetEnumerator() => new Enumerator(this);
        // دي بدال كلاس Enumerator كلها
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _value)
            { 
                yield return item;
                
            }
        }


        class Enumerator: IEnumerator
        {
            int currentIndex = -1;
            FiveIntegers _integers;

            public Enumerator(FiveIntegers integers)
            {
                _integers = integers;
            }

            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException($"Enumeration not started");
                    if (currentIndex == _integers._value.Length)
                        throw new InvalidOperationException($"Enumeration has Ended");
                    return _integers._value[currentIndex];  
                }
            }
            public bool MoveNext()
            {
                if (currentIndex >= _integers._value.Length - 1)
                    return false;
                return ++currentIndex < _integers._value.Length;
            }

            public void Reset()  => currentIndex = -1;
        }
       
    }
}
