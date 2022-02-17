using FirstWeb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeb.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }

        IEnumerable<Car> GetFavCars { get; set; }

        Car getObjCar(int carId);
    }
}
