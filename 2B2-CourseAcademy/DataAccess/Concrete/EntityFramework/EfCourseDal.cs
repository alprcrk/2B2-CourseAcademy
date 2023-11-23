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

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, CourseAcademyContext>, ICourseDal
    {

        public List<CourseDetailDto> GetByCourseDetails()
        {
            using (CourseAcademyContext context = new CourseAcademyContext())
            {
                var result = from c in context.Courses
                             join ca in context.Categories
                             on c.CategoryId equals ca.CategoryId
                             join i in context.Instructors
                             on c.InstructorId equals i.InstructorId
                             select new CourseDetailDto
                             {
                                 Id = c.CourseId,
                                 CategoryName = ca.CategoryName,
                                 InstructorName = i.InstructorName,
                                 CourseName = c.CourseName,
                             };
                return result.ToList();
            }
        }
    }
}
