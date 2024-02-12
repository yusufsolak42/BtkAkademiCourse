using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is required")]
        public String? Email { get; set; } = String.Empty; // The symbol ? says that it might come as null
        [Required(ErrorMessage = "First name is required")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "last name  is required")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now; //when this object is created, ApplyAt field will be the currentDate
        }


    }
}