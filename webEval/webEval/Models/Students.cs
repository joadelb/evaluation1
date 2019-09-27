
namespace webEval.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum Sex
    { male,female,gay
    }
    public class Students
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Sex Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime birthday { get; set; }
    }
}