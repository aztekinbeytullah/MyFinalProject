using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product
                {
                    CategoryId=1,
                    ProductId=1,
                    ProductName="Laptop",
                    UnitPrice=15,
                    UnitsInStock=15
                },

                new Product
                {
                    CategoryId=1,
                    ProductId=2,
                    ProductName="Mouse",
                    UnitPrice=500,
                    UnitsInStock=3
                },

                new Product
                {
                    CategoryId=1,
                    ProductId=3,
                    ProductName="Ekran",
                    UnitPrice=1500,
                    UnitsInStock=2
                },
                new Product
                {
                    CategoryId=1,
                    ProductId=4,
                    ProductName="Kamere",
                    UnitPrice=150,
                    UnitsInStock=65
                },
                new Product
                {
                    CategoryId=1,
                    ProductId=5,
                    ProductName="Telefon",
                    UnitPrice=85,
                    UnitsInStock=1
                }

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LİNQ olmadan yapılan hamallık yukardaki listeyi bir döngü ile gezip
            // if ile gönderilen _product ve listedeki product id karşılaştırması ile olur.
            // Ancka buna gerek yoktur.
            Product productToDelete=_products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }
        public void Update(Product product)
        {
            //Gönderilen ürün İD numarasına sahip olan listedeki ürün tespit edilir.
            //ardından referanslar eşlendikten sonra güncellenecek ürün değiştirildiğinde listedeki referans
            // değişecektir. Tamamen referans ile ilgilidir.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            throw new NotImplementedException();
        }
    }
}
