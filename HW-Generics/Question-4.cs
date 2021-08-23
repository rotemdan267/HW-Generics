using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    interface IIdable
    {
        double ID { get; set; }
    }
    class HandleID<TD> where TD : IIdable
    {
        public void ResetID(TD td)
        {
            td.ID = 0;
        }
    }
    public class Student : IIdable, IHaveName
    {
        public double ID { get; set; }
        public string Name { get; set; }
    }
}
