using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_EF_fLUENT_API.Entities
{
    public class StudentContact
    {
        public int StudentId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //Nav
        public virtual Student Student { get; set; }
    }
}
