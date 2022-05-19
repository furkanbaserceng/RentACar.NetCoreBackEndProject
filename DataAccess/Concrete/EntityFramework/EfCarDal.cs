using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context=new RentACarContext())
            {
                return filter == null ? context.Set<Car>().ToList() :

                                     context.Set<Car>().Where(filter).ToList();
                //return context.Cars.ToList();

            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
                

            }
        }


        public void Add(Car entity)
        {
            try
            {
                using (RentACarContext context = new RentACarContext())
                {

                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();

                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
             
            }
        }
        public void Update(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {

                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void Delete(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {

                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public List<CarDetailsDTO> GetCarDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var carDetailsList = from ca in context.Cars
                                     join b in context.Brands
                                     on ca.BrandId equals b.Id
                                     join co in context.Colors
                                     on ca.ColorId equals co.Id
                                     select new CarDetailsDTO
                                     {
                                         BrandName = b.BrandName,
                                         ColorName = co.ColorName,
                                         DailyPrice = ca.DailyPrice,
                                         Description = ca.Description,
                                         ModelYear = ca.ModelYear


                                     };
                return carDetailsList.ToList();

            }
        }
    }
}
