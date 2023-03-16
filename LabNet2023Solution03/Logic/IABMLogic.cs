using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal interface IABMLogic<T>
    {
        List<T> GetAll();
        void add(T newalgo);

        void delete(int id);
    }
}
