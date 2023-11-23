﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public List<Course> Courses = new List<Course>();
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
