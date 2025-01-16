using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMangment.Models
{

    [Table("User")]
    public class user
    {





        [Column("Id" , TypeName = "Int")]
        [Key]
        
        public int Id { get; set; }

        [Column("Name", TypeName = "Varchar")]
        [StringLength(50)]
        public string Name { get; set; }


        [Column("Birthdate", TypeName = "int")]
        public int Birtdate { get; set; }


        [Column("Email", TypeName = "Varchar")]
        [StringLength(50)]
        public string Email { get; set; }


        [Column("Password", TypeName = "varchar")]
        [StringLength(50)]
        public string Password { get; set; }

       


    }



    [Table("Movie")]

    public class Movie
    {


        


        [Column("Movie_Id", TypeName = "Int")]
        [Key]
        public int  Movie_Id { get; set; }


        [Column("M_Name", TypeName = "Varchar")]
        [StringLength(50)]

        public string M_Name { get ; set; }



        [Column("Actor", TypeName = "Varchar")]
        [StringLength(50)]
        public string Actor { get; set; }



        [Column("Actress", TypeName = "Varchar")]
        [StringLength(50)]
        public string Actress { get; set; }


        [Column("Rating", TypeName = "Int")]
        public int Rating { get; set; }




    }




    public  class  dacdbcontext : DbContext
    {

        public DbSet<user> Alluser { get; set; }


        public DbSet<Movie> Allmovie { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dac_db1;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
