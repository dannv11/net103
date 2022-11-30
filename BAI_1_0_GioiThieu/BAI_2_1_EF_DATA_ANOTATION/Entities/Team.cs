using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_EF_DATA_ANOTATION.Entities
{
    public class Team
    {
        public int Id { get; set; }
        [ForeignKey("Department")]
        public int?  DepartmentId { get; set; }

        // Navigation Prop
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
