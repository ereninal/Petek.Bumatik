using Microsoft.EntityFrameworkCore;
using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class EfAutomatItemsDal : EfEntityRepositoryBase<AutomatItem, BUmatikContext>, IAutomatItemsDal
    {
        public List<AutomatItemsDTO> GetAutomatItemsDTOs()
        {
            using (var context = new BUmatikContext())
            {
                var datas = context.AutomatItems.Include(s => s.ItemCategory).Include(a=>a.AutomatItemInfo).Where(m => m.IsDeleted == false).Select(m => new AutomatItemsDTO()
                {
                    Name = m.Name,
                    CategoryName = m.ItemCategory.Name,
                    Description = m.Description,
                    Count = m.AutomatItemInfo.Count,
                    Price = m.Price
                }).ToList();
                return datas;
            }
        }

        public void ItemAdd(AutomatItem item)
        {
            using (var context = new BUmatikContext())
            {
                context.AutomatItems.Add(item);
                context.SaveChanges();
            }
        }
    }
}
