using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public void add(Categories newalgo)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetAll() => context.Categories.ToList();
    }
}
