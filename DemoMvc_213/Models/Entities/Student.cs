using System.ComponentModel.DataAnnotations;

namespace DemoMvc_213.Models.Entities
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}