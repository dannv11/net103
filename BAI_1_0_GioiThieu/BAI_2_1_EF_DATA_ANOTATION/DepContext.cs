using BAI_2_1_EF_DATA_ANOTATION.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_EF_DATA_ANOTATION
{
    public class DepContext:DbContext
    {
        /// <summary>
        /// base() Nếu để trống => Ef tạo db <namespace>.<tên context class> trong local SqlExpess Database
        /// base("Tên database") => Ef tạo db <Tên database> trong local SqlExpess Database
        /// base("name= Tên connection string") => Ef tạo db dựa vào th
        /// </summary>
        public DepContext():base("DepartmentDB")
        {

        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<EmployeeAddress> employeeAddresses { get; set; }
        public DbSet<Team> teams { get; set; }
    }
}
