using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace database.Models
{
    public class FirstDBContaxt: DbContext
    {
        public FirstDBContaxt(DbContextOptions<FirstDBContaxt> options):base(options)
        {

        }
        public DbSet<data> DataModels { get; set; }
        
    }
}
