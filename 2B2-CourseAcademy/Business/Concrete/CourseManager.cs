﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public IResult Add(Course course)
        {
            if (course.CourseName.Length < 2)
            {
                return new ErrorResult(Messages.CourseNameInvalid);
            }
            _courseDal.Add(course);
            return new SuccessResult(Messages.CoursesAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CoursesDeleted);
        }
        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CoursesUpdated);
        }

        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CourseListed);
        }

        public IDataResult<List<Course>> GetByCourseId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CourseId == id));
        }

        public IDataResult<List<Course>> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CourseDetailDto>> GetByCourseDetails()
        {
            throw new NotImplementedException();
        }
    }
}