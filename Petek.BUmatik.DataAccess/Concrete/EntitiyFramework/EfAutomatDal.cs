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
                var datas = context.AutomatItems.Include(s => s.ItemCategory).Include(a => a.AutomatItemInfo).Where(m => m.IsDeleted == false).Select(m => new AutomatItemsDTO()
                {
                    Id = m.Id,
                    Name = m.Name,
                    CategoryName = m.ItemCategory.Name,
                    ImagePath = m.ImagePath,
                    Description = m.Description,
                    Count = m.AutomatItemInfo.Count,
                    Price = m.Price
                }).ToList();
                return datas;
            }
        }

        public List<SelectedItemsDTO> GetMenuItemsByStudent(string bandNumber, DateTime useDate, int menuTypeId)
        {
            using (var context = new BUmatikContext())
            {
                var studentId = context.Students.Where(m => m.IsDeleted == false && m.BandNumber == bandNumber.Trim()).FirstOrDefault().Id;
                var datas = context.SelectedMenuItems.Include(s => s.AutomatItem).Include(s => s.Student).Where(m => m.IsDeleted == false && m.LastStatus == true && m.UseDate == useDate && m.Student.BandNumber == bandNumber && m.MenuId == menuTypeId).Select(m => new SelectedItemsDTO()
                {
                    ProductId = m.AutomatItem.Id,
                    ProductName = m.AutomatItem.Name

                }).ToList();
                return datas;
            }
        }
        public List<MenuTypeDTO> GetMenuTypeDTOs()
        {
            using (var context = new BUmatikContext())
            {
                var datas = context.MenuTypes.Where(m => m.IsDeleted == false).Select(m => new MenuTypeDTO()
                {
                    Id = m.Id,
                    Type = m.Type,
                    StartDate = m.StartDate.ToString(),
                    FinishDate = m.FinishDate.ToString(),


                }).ToList();
                return datas;
            }
        }

        public SelectedMenuDetailsDTO GetStudentMenuDetailsByBandNumber(string bandNumber)
        {

            var currentUseTime = DateTime.Now.AddSeconds(-1440);
            var useTime = new TimeSpan(currentUseTime.Hour, currentUseTime.Minute, currentUseTime.Second);
            using (var context = new BUmatikContext())
            {
                var menuTypeId = 3;
                var startMorningDate = context.MenuTypes.Where(m => m.Id == 1).Select(m => m.StartDate).FirstOrDefault();
                var finishMorningDate = context.MenuTypes.Where(m => m.Id == 1).Select(m => m.FinishDate).FirstOrDefault();
                var StartNoonDate = context.MenuTypes.Where(m => m.Id == 2).Select(m => m.StartDate).FirstOrDefault();
                var finishNoonDate = context.MenuTypes.Where(m => m.Id == 2).Select(m => m.FinishDate).FirstOrDefault();
                if (useTime >= StartNoonDate && useTime <= finishNoonDate)
                    menuTypeId = 2;
                else if (useTime >= startMorningDate && useTime <= finishMorningDate)
                    menuTypeId = 1;


                var data = context.Students.Include(s => s.SelectedMenuItems).Where(m => m.IsDeleted == false && m.BandNumber == bandNumber.Trim()).Select(m => new SelectedMenuDetailsDTO()
                {
                    BandNumber = m.BandNumber,
                    StudentName = m.FullName,
                    MenuItems = m.SelectedMenuItems.Where(s => s.IsDeleted == false && s.StudentId == m.Id && s.MenuId == menuTypeId && s.UseDate == DateTime.Today && s.LastStatus == true).ToList()

                }).FirstOrDefault();
                if (data.MenuItems.Count > 0)
                    MenuPassiveProcess(data);
                return data;
            }
        }
        public bool MenuPassiveProcess(SelectedMenuDetailsDTO selectedMenuDetailsDTO)
        {

            using (var context = new BUmatikContext())
            {
                var studentId = context.Students.FirstOrDefault(m => m.IsDeleted == false && m.BandNumber == selectedMenuDetailsDTO.BandNumber).Id;
                var updateData = context.SelectedMenuItems.Where(m => m.LastStatus == true && m.MenuId == selectedMenuDetailsDTO.MenuItems.FirstOrDefault().MenuId && m.StudentId == selectedMenuDetailsDTO.MenuItems.FirstOrDefault().StudentId && m.UseDate == selectedMenuDetailsDTO.MenuItems.FirstOrDefault().UseDate).ToList();
                foreach (var item in updateData)
                {
                    item.LastStatus = false;
                    item.ModifiedDate = DateTime.Now;
                    var updatedEntity = context.Entry(item);
                    updatedEntity.State = EntityState.Modified;
                }

                context.SaveChanges();
            }
            return false;
        }
        public bool MenuPassiveProcessPackage(SelectedMenuPackageDTO selectedMenuPackageDTO)
        {

            using (var context = new BUmatikContext())
            {
                var studentId = context.Students.FirstOrDefault(m => m.IsDeleted == false && m.BandNumber == selectedMenuPackageDTO.BandNumber).Id;
                var updateData = context.SelectedMenuItems.Where(m => m.LastStatus == true && m.AutomatItemId == selectedMenuPackageDTO.PackageId && m.StudentId == selectedMenuPackageDTO.StudentId && m.UseDate == selectedMenuPackageDTO.UseDate);
                foreach (var item in updateData)
                {
                    item.LastStatus = false;
                    item.ModifiedDate = DateTime.Now;
                    var updatedEntity = context.Entry(item);
                    updatedEntity.State = EntityState.Modified;
                }

                context.SaveChanges();
            }
            return false;
        }
        public void ItemAdd(AutomatItem item)
        {
            using (var context = new BUmatikContext())
            {
                context.AutomatItems.Add(item);
                context.SaveChanges();
            }
        }

        public SelectedMenuPackageDTO GetStudentMenuDetailsPackageByBandNumber(string bandNumber)
        {
            var currentUseTime = DateTime.Now;
            var useTime = new TimeSpan(currentUseTime.Hour, currentUseTime.Minute, currentUseTime.Second);
            using (var context = new BUmatikContext())
            {
                var menuTypeId = 3;
                var startMorningDate = context.MenuTypes.Where(m => m.Id == 1).Select(m => m.StartDate).FirstOrDefault();
                var finishMorningDate = context.MenuTypes.Where(m => m.Id == 1).Select(m => m.FinishDate).FirstOrDefault();
                var StartNoonDate = context.MenuTypes.Where(m => m.Id == 2).Select(m => m.StartDate).FirstOrDefault();
                var finishNoonDate = context.MenuTypes.Where(m => m.Id == 2).Select(m => m.FinishDate).FirstOrDefault();
                if (useTime >= StartNoonDate && useTime <= finishNoonDate)
                    menuTypeId = 2;
                else if (useTime >= startMorningDate && useTime <= finishMorningDate)
                    menuTypeId = 1;

                var lastUseDate = DateTime.Today;
                var data = context.Students.Include(s => s.SelectedMenuItems).Where(m => m.IsDeleted == false && m.BandNumber == bandNumber.Trim()).Select(m => new SelectedMenuPackageDTO()
                {
                    BandNumber = m.BandNumber,
                    StudentName = m.FullName,
                    StudentId = m.Id,
                    UseDate = m.SelectedMenuItems.Where(s => s.IsDeleted == false && s.StudentId == m.Id && s.MenuId == menuTypeId && s.UseDate == lastUseDate && s.LastStatus == true).FirstOrDefault().UseDate,
                    PackageId = m.SelectedMenuItems.Where(s => s.IsDeleted == false && s.StudentId == m.Id && s.MenuId == menuTypeId && s.UseDate == lastUseDate && s.LastStatus == true).FirstOrDefault().AutomatItemId,
                    SelectedMenuId = m.SelectedMenuItems.Where(s => s.IsDeleted == false && s.StudentId == m.Id && s.MenuId == menuTypeId && s.UseDate == lastUseDate && s.LastStatus == true).FirstOrDefault().Id,

                }).FirstOrDefault();
                //if (data != null)
                //    MenuPassiveProcessPackage(data);
                return data;
            }
        }
    }
}
