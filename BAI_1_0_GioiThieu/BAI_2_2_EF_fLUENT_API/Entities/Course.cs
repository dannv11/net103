using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_EF_fLUENT_API.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Nav
        public ICollection<Student> students { get; set; }
    }
}
