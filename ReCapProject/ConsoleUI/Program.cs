
using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine("Bilgi" + car.Description);
            //}

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if(result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Markası :" + car.BrandName + " Rengi :" + car.ColorName + " Fiyati" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            



        }

        //private static void CategoryTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}

        
    }
}
