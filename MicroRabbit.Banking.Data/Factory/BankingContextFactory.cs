using MicroRabbit.Banking.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Factory
{
    public class BankingContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public IConfiguration Configuration { get; set; }

        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer(@"Server=IN-5CG0031M4X\SQLEXPRESS; Database=BankingDB; Trusted_Connection=True; MultipleActiveResultSets=True");            
            return new BankingDbContext(optionsBuilder.Options);
        }
    }
}
