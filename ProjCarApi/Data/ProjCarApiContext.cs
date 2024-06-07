using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjCarApi.Data
{
    public class ProjCarApiContext : DbContext
    {
        public ProjCarApiContext(DbContextOptions<ProjCarApiContext> options)
            : base(options)
        {
        }
        public DbSet<Car> Car { get; set; } = default!;
        public DbSet<Client> Client { get; set; } = default!;
        public DbSet<Employee>? Employee { get; set; }
        public DbSet<CarJob>? CarJob { get; set; }
        public DbSet<CreditCard>? CreditCard { get; set; }
        public DbSet<Pix>? Pix { get; set; }
        public DbSet<Ticket>? Ticket { get; set; }
        public DbSet<Role>? Role { get; set; }
        public DbSet<PixType>? PixType { get; set; }
        public DbSet<Purchase>? Purchase { get; set; }
        public DbSet<Job>? Job { get; set; }
        public DbSet<Payment>? Payment { get; set; }
        public DbSet<Adress>? Adress { get; set; }
        public DbSet<Sale>? Sale { get; set; }
        public DbSet<Person>? Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Employee>().ToTable("Employees");
        }
    }
}