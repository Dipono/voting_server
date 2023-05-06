using Android.Voting.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Android.Voting.Data
{
    public class AndroidVotindDbContext : DbContext
    {
        public AndroidVotindDbContext(DbContextOptions<AndroidVotindDbContext>options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}