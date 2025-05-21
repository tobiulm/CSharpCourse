using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DemoGenericType<T> where T : struct
    {
        public void DemoMethod(T item)
        {
            Console.WriteLine(item.GetType().ToString());
        }

    }
}
