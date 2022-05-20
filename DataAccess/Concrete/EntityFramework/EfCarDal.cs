using Core.DataAccess.EntityFramework;
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
    public class EfCarDal : EfEntityRepositoryBase<RentACarContext,Car>,ICarDal
    {
        

        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var carDetailsList = from ca in context.Cars
                                     join b in context.Brands
                                     on ca.BrandId equals b.Id
                                     join co in context.Colors
                                     on ca.ColorId equals co.Id
                                     select new CarDetailDto
                                     {
                                         BrandName = b.BrandName,
                                         ColorName = co.ColorName,
                                         DailyPrice = ca.DailyPrice,
                                         CarName = ca.Description,
                                         ModelYear = ca.ModelYear


                                     };
                return carDetailsList.ToList();

            }
        }
    }
}
