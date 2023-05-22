using BlazorSyncfusion.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorSyncfusion.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Syncfusion-AspIT-FirstLook;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "Kenneth",
                    LastName = "Hougaard Soerensen",
                    NickName = "KESO",
                    Title = "Lærer",
                    Mail = "keso@aspit.dk",
                    School = "AspIT Trekanten",
                    IsEmployee = true,
                    BirthDate = new DateTime(1994, 03, 04)
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Mads",
                    LastName = "Mikkel Rasmussen",
                    NickName = "MARA",
                    Title = "Lærer",
                    Mail = "mara@aspit.dk",
                    School = "AspIT Trekanten",
                    IsEmployee = true,
                    BirthDate = new DateTime(1994, 03, 04)
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Dea",
                    LastName = "Gram",
                    NickName = "DEGR",
                    Title = "Lærer",
                    Mail = "degr@aspin.dk",
                    School = "AspIN",
                    IsEmployee = true,
                    BirthDate = new DateTime(1994, 03, 04)
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Jan",
                    LastName = "Lindgaard Pedersen",
                    NickName = "JAPE",
                    Title = "Lærer",
                    Mail = "jape@aspin.dk",
                    School = "AspIN",
                    IsEmployee = true,
                    BirthDate = new DateTime(1994, 03, 04)
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Jesper",
                    LastName = "Lade Mathiesen",
                    NickName = "JEMA",
                    Title = "Specialpædagogisk vejleder",
                    Mail = "jema@aspit.dk",
                    Phone = "+45 72 16 28 56",
                    School = "AspIT Trekanten",
                    IsEmployee = true,
                    BirthDate = new DateTime(1994, 03, 04)
                },
                new Employee
                {
                    Id = 6,
                    FirstName = "Henrik",
                    LastName = "Stephansen",
                    NickName = "HENS",
                    Title = "Praktik- og jobvejleder",
                    Mail = "hens@aspit.dk",
                    Phone = "+45 72 16 26 85",
                    School = "AspIT Trekanten",
                    IsEmployee = true,
                    BirthDate = new DateTime(1994, 03, 04)
                },
                new Employee
                {
                    Id = 7,
                    FirstName = "Ole",
                    LastName = "Bay Jensen",
                    NickName = "OJE",
                    Title = "Uddannelseschef",
                    Mail = "oje@aspit.dk",
                    Phone = "+45 72 16 27 99",
                    School = "AspIT Trekanten",
                    IsEmployee = true,
                    BirthDate = new DateTime(1994, 03, 04)
                }
                );

            modelBuilder.Entity<Note>().HasData(
                new Note { Id = 1, EmployeeId = 5, Text = "ADHD child and very annoying." },
                new Note { Id = 2, EmployeeId = 1, Text = "funny." }
                );
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}