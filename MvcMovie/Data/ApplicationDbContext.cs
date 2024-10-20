using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class  ApplicationDbContext :DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){

        }
        public DbSet<Student> Students {get;set;} = default!;
        public DbSet<Person> Person {get;set;} = default!;
        public DbSet<Employee> Employee {get;set;} = default!;

    }

}