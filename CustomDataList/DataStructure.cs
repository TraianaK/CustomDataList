using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataList
{
    interface DataStructure
    {
        void AddFrog(string frog);
        void GetByIndex(int index);
        void RemoveByIndex(int index);
        void RemoveFirst();
        void RemoveLast();
        void FindLenght();
        void FindFirst();
        void Sorting();
    }
}
