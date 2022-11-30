using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_EF_fLUENT_API.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int EduCenterId { get; set; }
        // Nav
        public virtual EduCenter EduCenter { get; set; }
        public virtual StudentContact  StudentContact{get;set;}
        public virtual ICollection<Course> Courses { get; set; }
    }
}
