using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCap>, IRentalDal
    {
        //public List<RentalDetailDto> GetRentalDetails()
        //{
        //    using (ReCap context = new ReCap())
        //    {
        //        var result = from r in context.Rentals
        //                     join c in context.Cars
        //                     on r.CarId equals c.Id
        //                     join cu in context.Customers
        //                     on r.CustomerId equals cu.CustomerId
        //                     join b in context.Brands
        //                     on r.
        //                     select new RentalDetailDto
        //                     {
        //                         RentalId = r.RentalId,
        //                         CarName =c

                                 
        //                     };






        //        return result.ToList();
        //    }
        //}
    }
}
