using FirstWeb.Data.Interfaces;
using FirstWeb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeb.Data.mo
{
    public class moCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта!"},
                    new Category { categoryName = "Классические", desc = "Машины с двигателем ВЗ!"}

                };
            } 
        }
    }
}
