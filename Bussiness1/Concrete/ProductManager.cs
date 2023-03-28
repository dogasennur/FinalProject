using Bussiness1.Abstract;
using DataAccess1.Abstract;
using DataAccess1.Concrete.InMemory;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness1.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal) 
        { 
            _productDal = productDal;
        
        }
        public List<Product> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
        }
    }
}
