﻿using Microsoft.EntityFrameworkCore;
using Petek.BUmatik.Core.DataAccess.EntitiyFramework;
using Petek.BUmatik.DataAccess.Abstract;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Petek.BUmatik.DataAccess.Concrete.EntitiyFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, BUmatikContext>, IStudentDal
    {
        public int GetIdByStudent(string bandNumber)
        {
            using (var context = new BUmatikContext())
            {
                var data = context.Students.Where(m => m.IsDeleted == false && m.BandNumber == bandNumber.Trim()).FirstOrDefault().Id;
                return data;
            }
        }

        public StudentDTO GetStudentById(int id)
        {
            using (BUmatikContext context = new BUmatikContext())
            {
                var data = context.Students.Include(s => s.Schools).Where(m => m.IsDeleted == false && m.Id == id).Select(m => new StudentDTO()
                {
                    Fullname = m.FullName,
                    BandNumber = m.BandNumber,
                    RemainingMoney = m.RemainingMoney,
                    SchoolName = m.Schools.Name,
                    CreatedDate = m.CreatedDate,
                    ModifiedDate = m.ModifiedDate

                }).FirstOrDefault();
                //StudentDTO student = new StudentDTO();
                //student.BandNumber = data.;
                return data;
            }
        }

        public List<StudentDTO> GetStudentDTOs()
        {
            using (BUmatikContext context = new BUmatikContext())
            {
                var datas = context.Students.Include(s => s.Schools).Where(m => m.IsDeleted != true).Select(m => new StudentDTO()
                {
                    Fullname = m.FullName,
                    BandNumber = m.BandNumber,
                    RemainingMoney = m.RemainingMoney,
                    SchoolName = m.Schools.Name,
                    CreatedDate = m.CreatedDate,
                    ModifiedDate = m.ModifiedDate

                }).ToList();
                return datas;
            }
        }

        public List<StudentDTO> GetStudentSummary()
        {
            using (BUmatikContext context = new BUmatikContext())
            {
                var result = from p in context.Students
                             join c in context.Schools
                             on p.SchoolId equals c.Id
                             select new StudentDTO
                             {
                                 SchoolName = c.Name,
                                 BandNumber = p.BandNumber,
                                 Fullname = p.FullName,
                                 RemainingMoney = p.RemainingMoney

                             };
                return result.ToList();

            }
        }
    }
}
