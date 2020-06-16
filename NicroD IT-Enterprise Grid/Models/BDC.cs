using System;
using System.Data.Entity;

namespace NicroD_IT_Enterprise_Table
{
    public class BDC : DbContext
    {
        public BDC() : base("DbConnectionString")
        {
        }

        public DbSet<Reg> Regs { get; set; }
    }
}
