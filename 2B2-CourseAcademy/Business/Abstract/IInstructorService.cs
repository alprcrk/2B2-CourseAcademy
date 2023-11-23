using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        public IDataResult<List<Instructor>> GetAll();
        public IDataResult<List<Instructor>> GetByInstructorId(int id);
        public IResult Add(Instructor instructor);
        public IResult Update(Instructor instructor);
        public IResult Delete(Instructor instructor);



    }
}
