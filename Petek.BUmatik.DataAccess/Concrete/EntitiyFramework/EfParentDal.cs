﻿using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Petek.BUmatik.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class EfParentDal : EfEntityRepositoryBase<Parent, BUmatikContext>, IParentDal
    {
        public void AdminUserAdd(AdminUser Add)
        {
            using (var context = new BUmatikContext())
            {
                context.AdminUsers.Add(Add);
                context.SaveChanges();
            }
        }

        public List<OperationClaim> GetClaims(Parent user)
        {
            using (var context = new BUmatikContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.ParentId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public List<ParentDTO> GetParents()
        {
            using (var context = new BUmatikContext())
            {
                var datas = context.Parents.Where(m => m.IsDeleted == false).Select(m => new ParentDTO()
                {
                    Email = m.Email,
                    Fullname = m.FullName,
                    PasswordHash = m.PasswordHash,
                    PasswordSalt = m.PasswordSalt
                }).ToList();

                return datas;
            }
        }

        public List<StudentDTO> GetStudentsByParent(int? id)
        {
            using (var context = new BUmatikContext())
            {
                var datas = context.Students.Include(s => s.Schools).Where(m => m.IsDeleted == false && m.ParentId == id).Select(m => new StudentDTO()
                {
                    StudentId = m.Id,
                    BandNumber = m.BandNumber,
                    Fullname = m.FullName,
                    RemainingMoney = m.RemainingMoney,
                    SchoolName = m.Schools.Name

                }).ToList();
                return datas;
            }
        }

        public SelectedMenuDetailsDTO GetStudentMenuDetails(int id,int menuTypeId,DateTime useDate)
        {

            using (var context = new BUmatikContext())
            {
                var data = context.Students.Include(s => s.SelectedMenuItems).Where(m => m.IsDeleted == false && m.Id == id).Select(m => new SelectedMenuDetailsDTO()
                {
                    BandNumber = m.BandNumber,
                    StudentName = m.FullName,
                    MenuItems = m.SelectedMenuItems.Where(s => s.IsDeleted == false && s.StudentId == m.Id && s.MenuId == menuTypeId && s.UseDate == useDate).ToList()

                }).FirstOrDefault();
                return data;
            }
        }

        public void StudentAdd(Student student)
        {
            using (var context = new BUmatikContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void StudentMenuDetailsAdd(SelectedMenuItemDTO selectedMenuItems)
        {
            using (var context = new BUmatikContext())
            {
                foreach (var menuItem in selectedMenuItems.selectedAutomatItems)
                {
                    var newData = new SelectedMenuItems();
                    newData.LastStatus = true;
                    newData.StudentId = selectedMenuItems.StudentId;
                    newData.MenuId = selectedMenuItems.MenuTypeId;
                    newData.Count = menuItem.Count;
                    newData.AutomatItemId = menuItem.ItemId;
                    context.SelectedMenuItems.Add(newData);
                }
                context.SaveChanges();
            }
        }

        public List<SelectedMenusDTO> GetSelectedMenusByStudent(int id)
        {
            using (var context = new BUmatikContext())
            {
                var datas = context.SelectedMenuItems.Include(s => s.Menu).Include(a => a.Student).Where(m => m.IsDeleted == false && m.StudentId == id).Select(m => new SelectedMenusDTO() 
                {
                    StudentId = m.StudentId,
                    BandNumber = m.Student.BandNumber,
                    Fullname = m.Student.FullName,
                    CreatedDate = m.CreatedDate,
                    LastStatus = m.LastStatus ? "Bekliyor" : "Tamamlandı",
                    MenuType = m.Menu.MenuType.Type
                }).ToList();
                return datas;
            }
        }
    }
}
