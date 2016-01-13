using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Context:DbContext
    {
        public DbSet<Record> Records { get; set; }
    }
}
