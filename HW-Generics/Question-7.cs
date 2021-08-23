using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    interface IHaveName
    {
        string Name { get; set; }
    }
    class HandleNames<TD> where TD: IHaveName
    {
        public void PrintNameAndType(TD td)
        {
            Console.WriteLine(td.GetType());
            Console.WriteLine(td.Name);
        }
    }
}
