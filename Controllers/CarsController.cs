using FirstWeb.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeb.Controllers
{
    public class CarsController : Controller
    {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController (IAllCars iAllCars, ICarsCategory icarsCategory)
        {
            _allCars = iAllCars;
            _allCategories = icarsCategory;
        }

        public ViewResult List()
        {
            var cars = _allCars;
            return View(cars);
        }
    }
}
