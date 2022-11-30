using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_EF_DATA_ANOTATION
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new DepContext())
            {
                ctx.Database.CreateIfNotExists();
            }    
        }
    }
}
