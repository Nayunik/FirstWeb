using FirstWeb.Data.Interfaces;
using FirstWeb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeb.Data.mo
{
    public class MoCars:IAllCars
    {
        private readonly ICarsCategory _categoryCars = new moCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                { 
                    new Car {name = "Tesla", shortDesc = "Первое авто", longDesc = "ПЕРВОЕ АВТО", img = "", price = 4500, isFavorit = true, available = true, category =  _categoryCars.AllCategories.First()},
                    new Car {name = "Ford", shortDesc = "Second Car", longDesc = "SECOND CAR", img = "", price = 2000, isFavorit = false, category = _categoryCars.AllCategories.Last()}
                };
            }
        }

        public IEnumerable<Car> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
