using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID 
        //OPEN CLOSED PRINCIPLE: YAPTIĞIN YAZILIMA YENİ BİR ÖZELLİK EKLİYOSAN MEVCUTTAKİ HİÇBİR KODUNA DOKUNAMAZSIN
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            var c = categoryManager.GetById(3);
            Console.WriteLine(c.CategoryName);

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else 
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
