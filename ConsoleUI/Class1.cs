using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    public class Class1
    {
        //SOLID
        //open closed principle
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //ProductTest();

            //CategoryTest();

            ProductTestDto();
        }

        private static void ProductTestDto()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " " + item.ProductId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    foreach (var item in productManager.GetByUnitPrice(20, 100))
        //    {
        //        Console.WriteLine(item.ProductName);
        //    }
        //}

    }
}
