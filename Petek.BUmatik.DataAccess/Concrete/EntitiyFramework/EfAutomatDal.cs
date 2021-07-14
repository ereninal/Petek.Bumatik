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
    public class EfAutomatDal : EfEntityRepositoryBase<AutomatItem, BUmatikContext>, IAutomatDal
    {
        public List<AutomatItemsDTO> GetAutomatItemsDTOs()
        {
            using (var context = new BUmatikContext())
            {
                var datas = context.AutomatItems.Include(s => s.ItemCategory).Include(a=>a.AutomatItemInfo).Where(m => m.IsDeleted == false).Select(m => new AutomatItemsDTO()
                {
                    Id = m.Id,
                    Name = m.Name,
                    CategoryName = m.ItemCategory.Name,
                    Description = m.Description,
                    Count = m.AutomatItemInfo.Count,
                    Price = m.Price
                }).ToList();
                return datas;
            }
        }

        public List<SelectedItemsDTO> GetMenuItemsByStudent(string bandNumber, DateTime useDate,int menuTypeId)
        {
            using (var context = new BUmatikContext())
            {
                var studentId = context.Students.Where(m => m.IsDeleted == false && m.BandNumber == bandNumber.Trim()).FirstOrDefault().Id;
                var datas = context.SelectedMenuItems.Include(s => s.AutomatItem).Include(s=>s.Student).Where(m => m.IsDeleted == false && m.LastStatus == true && m.UseDate == useDate && m.Student.BandNumber == bandNumber && m.MenuId == menuTypeId).Select(m => new SelectedItemsDTO() 
                {
                    ProductId = m.AutomatItem.Id,
                    ProductName = m.AutomatItem.Name

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
