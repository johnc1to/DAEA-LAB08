﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Business
{
    public class BProduct
    {
        public List<Product> GetByName(string Name)
        {

            DProduct data = new DProduct();
            var products = data.Get();

            var result= products.Where(x=> x.Name.Contains(Name)).ToList();
            //lambda
            //flecha
            

            return result;
        }

        public bool InsertProduct(Product product)
        {
            DProduct data = new DProduct();
            return data.Insert(product);
        }

        public bool DeleteProduct(int productId)
        {
            DProduct data = new DProduct();

            bool deleteSuccess = data.Delete(productId);

            return deleteSuccess;
        }

    }
}
