//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TryingOutStuff
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Car> cars = GetCarList();
//            //IEnumerable<Car> recentCars = cars.Where(car => car.Year > 1989);
//            List<Car> recentCars = cars.Where(car => car.Year > 1989).ToList();
//            List<string> carMakes = cars.Select(car => car.Make).ToList();

//            foreach (var carMake in carMakes)
//            {
//                Console.WriteLine(carMake);
//            }

//        }

//        public static List<Car> GetCarList()
//        {
//            List<Car> cars = new List<Car>()
//                {
//                    new Car() {Make = "Ferrari",Year = 1989},
//                    new Car() {Make = "Ford",Year = 2005},
//                    new Car() {Make = "General Motors",Year = 1997},
//                    new Car() {Make = "Toyota",Year = 1989},
//                };
//            return cars;
//        }

//        public static void GetCarListWithOwner()
//        {


//        }
//    }

//    public class Car
//    {
//        public string Make { get; set; }
//        public int Year { get; set; }
//    }

//    public class Owner
//    {
//        public string Name { get; set; }
//    }
//}
