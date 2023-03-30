using System.Reflection.Emit;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarManager carManager = new CarManager(new EfCarDal());
        //BrandManager brandManager = new BrandManager(new EfBrandDal());
        //ColorManager colorManager = new ColorManager(new EfColorDal());
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //UserManager userManager = new UserManager(new EfUserDal());
        //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        // var cars = carManager.GetAll();
        // foreach (var car in cars)
        // {
        //     System.Console.WriteLine("Id: " + car.Id  + " | " + "Descripton: " + car.Description + " | " + "Daily Price: $" + car.DailyPrice);
        // }
        // foreach (var car in carManager.GetCarsByBrandId(1))
        // {
        //     System.Console.WriteLine("Id: " + car.Id + " Model: " + car.ModelYear + " Daily Price : $" + car.DailyPrice);
        // }

        //GetAll(carManager);
        //GetCarsByBrandId(brandManager);
        //GetCarsByColorId(colorManager);
        //CarUpdate(carManager);
        //CarDelete(carManager);
        //CarTest();
        RentalTest(new Rental
        {
            CarId = 1,
            CustomerId = 1,
            RentDate = DateTime.Now,
            ReturnDate = DateTime.Now.AddDays(5)

        });

        // foreach (var car in carManager.GetById(1))
        // {
        //     System.Console.WriteLine("Car Id : " + car.Id + " - " + car.Description);
        // }
        // carManager.Add(new Car{
        //     BrandId= 4, 
        //     ColorId = 3,
        //     Description = "rjkcd",
        //     DailyPrice = 0,
        //     ModelYear = "2023"
        // });

        // var deneme =  userManager.Add(new User {
        //     FirstName = "Eda",
        //     LastName = "Buzlu",
        //     Email = "edabuz@gmail.com",
        //     Password = "123"

        // });
        // if (!deneme.Success)
        // {
        //     System.Console.WriteLine(deneme.Success);
        //     return;
        // }

        // System.Console.WriteLine(deneme.Message);



        // var rentaldeneme = rentalManager.Add(new Rental
        // {
        //     CarId = 1,
        //     CustomerId = 1,
        //     RentDate = DateTime.Now,
        //     ReturnDate = DateTime.Now.AddDays(2)

        // });
    }


    private static void RentalTest(Rental rental)
    {
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        var rentalResult = rentalManager.Add(rental);
        if (!rentalResult.Success)
        {
            System.Console.WriteLine(rentalResult.Success);
            return;

        }
        System.Console.WriteLine(rentalResult.Message);


    }

    private static void GetCarsByBrandId(BrandManager brandManager)
    {
        var brandresult = brandManager.GetCarsByBrandId(2);
        if (brandresult.Success == true)
        {
            foreach (var car in brandresult.Data)
            {
                System.Console.WriteLine("Id: " + car.Id + " Brand Id: " + car.BrandId + " Name: " + car.Name);
            }

        }

    }

    private static void GetCarsByColorId(ColorManager colorManager)
    {
        var coloresult = colorManager.GetCarsByColorId(1);

        if (coloresult.Success == true)
        {
            foreach (var car in coloresult.Data)
            {
                System.Console.WriteLine("Id: " + car.Id + " | " + " Color Id: " + car.ColorId + " Color: " + car.Name);
            }
        }

    }

    // private static void GetAll(CarManager carManager)
    // {
    //     foreach (var car in carManager.GetAll())

    //     {
    //         System.Console.WriteLine("Id: " + car.Id + " | " + "Descripton: " + car.Description + " | " + "Daily Price: $" + car.DailyPrice);
    //     }
    // }

    private static void CarDelete(CarManager carManager)
    {
        carManager.Delete(new Car { Id = 9, Description = "Trailer", DailyPrice = 270, BrandId = 5, ColorId = 4, ModelYear = "2012" });
    }

    private static void CarUpdate(CarManager carManager)
    {
        carManager.Update(new Car { Id = 2, Description = "No Air Conditioner", DailyPrice = 80, ModelYear = "2003", ColorId = 3, BrandId = 1 });
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        var result = carManager.GetCarDetails();

        if (result.Success == true)
        {
            foreach (var car in result.Data)
            {
                System.Console.WriteLine("Brand  : " + car.BrandName + "/ Car Description  : " + car.CarName + "/ Color : " + car.ColorName + "/ Daily Price : $" + car.DailyPrice);
            }
        }
        else
        {
            System.Console.WriteLine(result.Message);
        }
    }


}