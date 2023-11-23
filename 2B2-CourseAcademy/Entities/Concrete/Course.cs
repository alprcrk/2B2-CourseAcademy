using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course: IEntity
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public int InstructorId { get; set; }
        public Instructor instructor { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        //
    }
}
