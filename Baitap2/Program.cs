using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
        {
            new Car { Make = "MCLaren", Name = "Mclaren570S", Year = 2005, Price = 250000 },
            new Car { Make = "Lamborghini", Name = "Lamborghini Urus", Year = 1985, Price = 180000 },
            new Car { Make = "MCLaren", Name = "Mclaren 650S", Year = 2010, Price = 200000 },
            new Car { Make = "Bugatti", Name = "Bugatti La Voiture Noire", Year = 1996, Price = 420000 },
            new Car { Make = "Bugatti", Name = "Bugatti Veyron", Year = 2017, Price = 120000 },
            new Car { Make = "Lamborghini", Name = "Lamborghini Huracan EVO 2020", Year = 1998, Price = 190000 },
            new Car { Make = "Lamborghini", Name = "Lamborghini Aventador S", Year = 2017, Price = 125000 },
            new Car { Make = "Ferrari", Name = "Ferrari F12 Berlinetta", Year = 1982, Price = 224000 },
            new Car { Make = "Ferrari", Name = "Ferrari SF90 Stradale", Year = 2019, Price = 600000 },
            new Car { Make = "MCLaren", Name = "McLaren 570S Spider", Year = 1985, Price = 190000 }
        };
            // Cau a : hiển thị các xe có giá trong khoảng 100.000 đến 250.000
            var selectedCars = from car in cars
                               where car.Price >= 100000 && car.Price <= 250000
                               select car;
            Console.WriteLine("Hien thi cac xe co gia trong khoang 100.000 den 250.000: \n");
            foreach (var car in selectedCars)
            {
                Console.WriteLine($"{car.Name} - Price: {car.Price}, Year: {car.Year}");
            }

            // Cau b : các xe có năm sản xuất > 1990.
            var selectedyearCars = from car in cars
                                   where car.Year > 1990
                               select car;
            Console.WriteLine("\nCac xe co nam san xuat > 1990: \n");
            foreach (var car in selectedyearCars)
            {
                Console.WriteLine($" {car.Name} - Price: {car.Price}, Year: {car.Year}");
            }

            // cau c : gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm
            var carGroups = from car in cars
                            group car by car.Make into grouped
                            select new { Make = grouped.Key, TotalPrice = grouped.Sum(car => car.Price) };

            Console.WriteLine("\nTong gia tri theo nhom:\n");
            foreach (var group in carGroups)
            {
                Console.WriteLine($"{group.Make}: {group.TotalPrice}");
            }

            List<Truck> trucks = new List<Truck>
        {
            new Truck { Make = "Ford", Name = "F-150", Year = 2015, Price = 300000, Company = "Ford Motor Company" },
            new Truck { Make = "Chevrolet", Name = "Silverado", Year = 2018, Price = 350000, Company = "General Motors" },
            new Truck { Make = "Toyota", Name = "Tacoma", Year = 2012, Price = 250000, Company = "Toyota Motor Corporation" },
            new Truck { Make = "GMC", Name = "Sierra", Year = 2020, Price = 400000, Company = "General Motors" },
            new Truck { Make = "Dodge", Name = "Ram", Year = 2019, Price = 380000, Company = "Stellantis" }
        };
            // cau a : hiển thị các xe theo năm sản xuất mới nhất
            var sortedTrucks = from truck in trucks
                               orderby truck.Year descending
                               select truck;
            Console.WriteLine("\nCac xe theo nam san xuat moi nhat :\n");
            foreach (var truck in sortedTrucks)
            {
                Console.WriteLine($"{truck.Make} {truck.Name} - Year: {truck.Year}");
            }

            Console.WriteLine("\nHien thi ten cong ty chu quan cua tung xe :\n");
            foreach (var truck in trucks)
            {
                Console.WriteLine($"{truck.Make} {truck.Name} - Company: {truck.Company}");
            }
        }
    }
}
