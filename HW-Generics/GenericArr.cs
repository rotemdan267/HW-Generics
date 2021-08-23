using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    class GenericArr<TD>
    {
        TD[] arr = new TD[100];
        bool isReadOnly;
        
        public int Count { get; set; } = 0;

        public GenericArr()
        {
        }

        public GenericArr(TD[] arr, int count)
        {  // לא בטוח שזה הכי הגיוני לקבל את ה-count
            // מבחוץ אבל זה היה לי נוח לבצע בדיקות ככה
            this.arr = arr;
            Count = count;
        }

        public void Add(TD td)
        {
            if (!isReadOnly)
            {
                arr[Count] = td;
                Count++;
            }
            else
            {
                throw new InvalidOperationException("ReadOnly Mode is activated");
            }
        }
        public void Delete(TD td)
        {
            if (!isReadOnly)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (arr[i].Equals(td))
                    {
                        arr[i] = default(TD);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("ReadOnly Mode is activated");
            }
        }
        public void ActivateReadOnlyMode()
        {
            isReadOnly = true;
        }
        public void CancelReadOnlyMode()
        {
            isReadOnly = false;
        }
    }
}
