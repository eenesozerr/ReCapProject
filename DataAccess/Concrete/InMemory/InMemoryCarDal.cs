using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 2, ColorId = 1, ModelYear = "2018", DailyPrice = 210, Description = "Renault - Megane - Otomatik - Dizel" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2019", DailyPrice = 140, Description = "Renault - Symbol - Manuel - Dizel" },
                new Car { Id = 3, BrandId = 1, ColorId = 3, ModelYear = "2017", DailyPrice = 200, Description = "Opel - Insignia - Otomatik - Benzin" },
                new Car { Id = 4, BrandId = 3, ColorId = 2, ModelYear = "2018", DailyPrice = 230, Description = "Volkswagen - Passat - Otomatik - Benzin" },
                new Car { Id = 5, BrandId = 1, ColorId = 3, ModelYear = "2020", DailyPrice = 150, Description = "Renault - Clio  - Manuel - Benzin" },
                new Car { Id = 6, BrandId = 3, ColorId = 1, ModelYear = "2016", DailyPrice = 180, Description = "Volkswagen - Polo - Otomatik - Dizel" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
  