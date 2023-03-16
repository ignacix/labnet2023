using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void add(Shippers newalgo)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public List<Shippers> GetAll() => context.Shippers.ToList();
       
    }
}
