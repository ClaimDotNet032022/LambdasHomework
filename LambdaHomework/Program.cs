using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        #region StaticFields
        private static List<int> _integers = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5, 9 };

        private static List<string> _strings = new List<string> {
            "Hello",
            "World!",
            "I",
            "am",
            "a",
            "list",
            "of",
            "strings",
        };

        #endregion

        #region StaticMethods
        static int Aggregate(Func<int, int, int> f, List<int> list)
        {
            int result = list[0];
            for (int i = 1; i < list.Count; ++i)
            {
                result = f(result, list[i]);
            }

            return result;
        }

        static IEnumerable<int> Select(Func<int, int> f, IEnumerable<int> list)
        {
            List<int> result = new List<int>();
            foreach (int val in list)
            {
                result.Add(f(val));
            }
            return result;
        }

        static void ForEach<T>(Action<T> f, IEnumerable<T> list)
        {
            foreach (T val in list)
            {
                f(val);
            }
        }

        #endregion

        static void Main(string[] args)
        {
        }
    }
}