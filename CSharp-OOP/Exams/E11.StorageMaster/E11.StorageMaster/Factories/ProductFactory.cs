﻿using E11.StorageMaster.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace E11.StorageMaster.Factories
{
    public class ProductFactory
    {
        public Product CreateProduct(string type, double price)
        {
            var productType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(x => !x.IsAbstract && x.Name == type)
                .FirstOrDefault();

            if (productType == null)
            {
                throw new InvalidOperationException("Invalid product type!");
            }

            Product product = null;

            try
            {
                product = (Product)Activator.CreateInstance(productType, price);
            }
            catch (TargetInvocationException tie)
            {
                throw new InvalidOperationException(tie.InnerException.Message);
            }

            return product;
        }
    }
}
