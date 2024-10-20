using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Employee : Person
    {
        public string EmployeeID { get; set; }
        public string Company { get; set; }
    }
}
