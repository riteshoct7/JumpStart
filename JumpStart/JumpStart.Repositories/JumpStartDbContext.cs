using JumpStart.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JumpStart.Repositories
{
    public class JumpStartDbContext : IdentityDbContext<User,Role,int>
    {

        #region Constructors

        public JumpStartDbContext()
        {

        }

        //public JumpStartDbContext(DbContextOptions<JumpStartDbContext> options) : base(options)
        //{

        //}

        #endregion

        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=RITESHPC\SQLEXPRESS;Initial Catalog=JumpStart;Persist Security Info=True;User ID=sa;Password=software123");
            }
        } 

        #endregion

        #region Properties

        public DbSet<ContactUs> ContactUs { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Expenses> Expenses { get; set; }

        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City  { get; set; }

        #endregion

    }
}
