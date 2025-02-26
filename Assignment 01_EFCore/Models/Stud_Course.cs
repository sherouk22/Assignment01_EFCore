using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment_01_EFCore.Models
{
    public class Stud_Course
    {

        public int stud_ID { get; set; }

        public int Course_ID { get; set; }

        public int Grade { get; set; }

        
    }
}
