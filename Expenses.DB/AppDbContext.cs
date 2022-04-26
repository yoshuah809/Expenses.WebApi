using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Expenses.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;initial catalog=ExpensesDB;Integrated Security=true; Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
