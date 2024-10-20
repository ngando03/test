using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models{
    [Table("SinhVien")]
    public class Student {
        [Key]
    public string  StudentID { get; set; }
    public string FullName { get; set; }

    }
}