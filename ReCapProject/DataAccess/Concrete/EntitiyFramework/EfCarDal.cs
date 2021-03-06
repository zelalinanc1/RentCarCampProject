using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCap>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
           
       
                using (ReCap context = new ReCap())
                {
                    var result = from c in context.Cars

                                 join b in context.Brands
                                 on c.BrandId equals b.BrandId

                                 join co in context.Colors
                                 on c.ColorId equals co.ColorId

                                 select new CarDetailDto
                                 {
                                     Id = c.Id,
                                     BrandName = b.BrandName,
                                     BrandId = b.BrandId,
                                     ColorId=co.ColorId,
                                     ModelYear=c.ModelYear,
                                     ColorName = co.ColorName,
                                     DailyPrice = c.DailyPrice,
                                     Description = c.Description,
                                     ImagePath = (from m in context.CarImages where m.CarId == c.Id select m.ImagePath).ToList(),
                                 };
                    return filter == null ? result.ToList() : result.Where(filter).ToList();
                
            }
        }
    }
}
