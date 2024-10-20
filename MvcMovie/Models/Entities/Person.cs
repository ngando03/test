using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Person {
        [Key]
        public string PersonID { get; set; }
        public string Hoten { get; set; }
        public string QueQuan { get; set; }
    }
}
