using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace crud.PostgreSQL
{
    public class HISContext: DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public HISContext(DbContextOptions<HISContext> opt) : base(opt) {
            try
            {
                Database.Migrate();
            }
            catch (Exception)
            {
                var a = 1;
                throw;
            }
        }
        private void SeedData()
        {
            if (!Patients.Any(p => p.PatientId == 65))
            {
                Patients.Add(new Patient { PatientId = 65 });
            }
            SaveChanges();
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Patient>().HasData(new Patient { PatientId = 65 });
        //}
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int gender { get; set; }
        public string idno { get; set; } = string.Empty;
    }
}
