using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongs.Views
{
    public static class OutputUtils<T>
    {
        public static void DisplayMany(List<T> listToDisplay)
        {
            foreach (T instance in listToDisplay)
            {
                Console.WriteLine(instance.ToString());
            }
        }
    }
}
