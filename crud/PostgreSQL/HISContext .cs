using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace crud.PostgreSQL
{
    public class HISContext: DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public HISContext(DbContextOptions<HISContext> opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().Property(p => p.PatientId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Patient>().HasData(
                new Patient { PatientId = 1, Name = "John Doe", gender = 1, idno = "1234567890" },
                new Patient { PatientId = 2, Name = "Jane Doe", gender = 0, idno = "0987654321" },
                new Patient { PatientId = 3, Name = "Alice Smith", gender = 1, idno = "1111111111" },
                new Patient { PatientId = 4, Name = "Bob Johnson", gender = 0, idno = "2222222222" },
                new Patient { PatientId = 5, Name = "Carol Brown", gender = 1, idno = "3333333333" },
                new Patient { PatientId = 6, Name = "David Wilson", gender = 0, idno = "4444444444" },
                new Patient { PatientId = 7, Name = "Eve Adams", gender = 1, idno = "5555555555" },
                new Patient { PatientId = 8, Name = "Frank Miller", gender = 0, idno = "6666666666" },
                new Patient { PatientId = 9, Name = "Grace Davis", gender = 1, idno = "7777777777" },
                new Patient { PatientId = 10, Name = "Harry White", gender = 0, idno = "8888888888" },
                new Patient { PatientId = 11, Name = "Isabel Thomas", gender = 1, idno = "9999999999" },
                new Patient { PatientId = 12, Name = "Jack Lee", gender = 0, idno = "7777777000" },
                new Patient { PatientId = 13, Name = "Karen Hall", gender = 1, idno = "5555555000" },
                new Patient { PatientId = 14, Name = "Larry King", gender = 0, idno = "3333333000" },
                new Patient { PatientId = 15, Name = "Megan Martin", gender = 1, idno = "1111111000" },
                new Patient { PatientId = 16, Name = "Nora Clark", gender = 0, idno = "2222222000" },
                new Patient { PatientId = 17, Name = "Oscar Young", gender = 1, idno = "4444444000" },
                new Patient { PatientId = 18, Name = "Pamela White", gender = 0, idno = "6666666000" },
                new Patient { PatientId = 19, Name = "Quincy Adams", gender = 1, idno = "8888888000" },
                new Patient { PatientId = 20, Name = "Robert Davis", gender = 0, idno = "1234567000" },
                new Patient { PatientId = 21, Name = "Sara Wilson", gender = 1, idno = "0987655000" },
                new Patient { PatientId = 22, Name = "Tom Johnson", gender = 0, idno = "3333333000" },
                new Patient { PatientId = 23, Name = "Ursula Smith", gender = 1, idno = "6666666000" },
                new Patient { PatientId = 24, Name = "Victor Lee", gender = 0, idno = "1111111000" },
                new Patient { PatientId = 25, Name = "Wendy Hall", gender = 1, idno = "5555555000" },
                new Patient { PatientId = 26, Name = "Xander Martin", gender = 0, idno = "8888888000" },
                new Patient { PatientId = 27, Name = "Yara Thomas", gender = 1, idno = "7777777000" },
                new Patient { PatientId = 28, Name = "Zane King", gender = 0, idno = "2222222000" },
                new Patient { PatientId = 29, Name = "Aaron Adams", gender = 1, idno = "4444444000" },
                new Patient { PatientId = 30, Name = "Bella Martin", gender = 0, idno = "1234567000" },
                new Patient { PatientId = 31, Name = "Chris White", gender = 1, idno = "0987655000" },
                new Patient { PatientId = 32, Name = "Daisy Hall", gender = 0, idno = "5555555000" },
                new Patient { PatientId = 33, Name = "Ethan King", gender = 1, idno = "6666666000" },
                new Patient { PatientId = 34, Name = "Fiona Davis", gender = 0, idno = "2222222000" },
                new Patient { PatientId = 35, Name = "George Wilson", gender = 1, idno = "1234567000" },
                new Patient { PatientId = 36, Name = "Hannah Lee", gender = 0, idno = "7777777000" },
                new Patient { PatientId = 37, Name = "Isaac Thomas", gender = 1, idno = "0987655000" },
                new Patient { PatientId = 38, Name = "Julia Smith", gender = 0, idno = "4444444000" },
                new Patient { PatientId = 39, Name = "Kai Adams", gender = 1, idno = "5555555000" },
                new Patient { PatientId = 40, Name = "Lily King", gender = 0, idno = "6666666000" },
                new Patient { PatientId = 41, Name = "Mike Davis", gender = 1, idno = "7777777000" },
                new Patient { PatientId = 42, Name = "Nina Martin", gender = 0, idno = "2222222000" },
                new Patient { PatientId = 43, Name = "Oliver Hall", gender = 1, idno = "1234567000" },
                new Patient { PatientId = 44, Name = "Penny Lee", gender = 0, idno = "0987655000" },
                new Patient { PatientId = 45, Name = "Quinn Thomas", gender = 1, idno = "4444444000" },
                new Patient { PatientId = 46, Name = "Rachel Smith", gender = 0, idno = "5555555000" },
                new Patient { PatientId = 47, Name = "Samuel Adams", gender = 1, idno = "1234567000" },
                new Patient { PatientId = 48, Name = "Tina Davis", gender = 0, idno = "0987655000" },
                new Patient { PatientId = 49, Name = "Ulysses Martin", gender = 1, idno = "6666666000" },
                new Patient { PatientId = 50, Name = "Victoria Wilson", gender = 0, idno = "7777777000" }
            );
        }
    }
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int gender { get; set; }
        public string idno { get; set; } = string.Empty;
    }
}
