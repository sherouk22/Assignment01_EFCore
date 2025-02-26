using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_EFCore.Models
{
    public class Department
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime HiringDate { get; set; }

        public int Ins_ID { get; set; }

    }
}
