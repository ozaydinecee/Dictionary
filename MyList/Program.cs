using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
		 * Dictionary Example
		 * @author Ece Ozaydin
		 * @since 31.01.2021
		 *
		 */
            MyDictionary<string, int> citys = new MyDictionary<string, int>();
            citys.Add("ankara", 06);
            citys.Add("istanbul", 34);
            citys.Add("izmir", 35);
        }
        class MyDictionary<T, A> //generic class
        {
            T[] _array;
            A[] _array2;
            T[] tempArray;
            A[] tempArray2;
            public MyDictionary()//constructor//when we create new MyDictionary ,this ctor work
            {
                _array = new T[0];//key
                _array2 = new A[0];//value

            }
            public void Add(T Key, A Value)
            {
                tempArray = _array;
                tempArray2 = _array2;
                _array = new T[_array.Length + 1];
                _array2 = new A[_array2.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    _array[i] = tempArray[i];

                }
                _array[_array.Length - 1] = Key;

                for (int i = 0; i < tempArray2.Length; i++)
                {
                    _array2[i] = tempArray2[i];
                }
                _array2[_array2.Length - 1] = Value;


                Console.WriteLine("City : " + Key + " No : " + Value);
            }

            
        }
    }
}
