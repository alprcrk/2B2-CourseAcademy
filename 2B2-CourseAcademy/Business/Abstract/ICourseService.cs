using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
		public IDataResult<List<Course>> GetAll();
		public IDataResult<List<Course>> GetByCategoryId(int categoryId);
		public IDataResult<List<CourseDetailDto>> GetByCourseDetails();
        public IResult Add(Course Course);
        public IResult Update(Course Course);
        public IResult Delete(Course Course);



    }
}
