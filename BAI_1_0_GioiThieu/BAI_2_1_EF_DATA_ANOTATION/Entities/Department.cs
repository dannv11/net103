using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_EF_DATA_ANOTATION.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Properties
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
