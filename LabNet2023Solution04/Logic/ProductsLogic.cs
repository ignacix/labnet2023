using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();   
        } 
    }
}
