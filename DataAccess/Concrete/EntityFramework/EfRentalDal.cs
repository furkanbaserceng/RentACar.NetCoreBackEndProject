using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<RentACarContext, Rental>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {

                var result = from ca in context.Cars
                             join re in context.Rentals
                             on ca.Id equals re.CarId
                             join cu in context.Customers
                             on re.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             join b in context.Brands
                             on ca.BrandId equals b.Id

                             select new RentalDetailDto
                             {
                                 CarName = ca.Description,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = ca.ModelYear,
                                 RentalDate = re.RentDate,
                                 CustomerName=u.FirstName,
                                 CustomerSurname=u.LastName,
                                 ReturnDate=re.ReturnDate,
                                 EmailAdress=u.Email
                             };

                return result.ToList();
            }
        }
    }
}
