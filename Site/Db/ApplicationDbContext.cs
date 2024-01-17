using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Site.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Students> Students { get; set; }
    }
    [Table("Students")]
    public class Students
    {
        [Key]
        [Column("id")]
        public int StudentId { get; set; }

        [Column("Фамилия")]
        public string SecondName { get; set; }

        [Column("Имя")]
        public string Name { get; set; }

        [Column("Отчество")]
        public string Surname { get; set; }

        [Column("Рост")]
        public int Height { get; set; }

        [Column("День_Рождения")]
        public string BirthDay { get; set; }

        [Column("Группа")]
        public string Group { get; set; }

        [Column("Специальность")]
        public string Speciality { get; set; }

        [Column("Стипендия")]
        public int Scholarship { get; set; }

    }
}
