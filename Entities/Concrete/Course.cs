﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course:BaseEntity
    {
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
