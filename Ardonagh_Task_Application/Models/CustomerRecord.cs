using System.ComponentModel.DataAnnotations;

namespace Ardonagh_Task_Application.Models
{
    public class CustomerRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        [StringLength(50, ErrorMessage = "Maximum length of 50 characters")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Please enter an age")]
        [Range(0, 110,
            ErrorMessage = "Age must be from 0 to 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter a postcode")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only aplhanumeric characters allowed.")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Please enter a height")]
        [Range(0, 2.5,
            ErrorMessage = "height must be from 0 to 2.5")]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Please enter a valid height")]
        public double Height { get; set; }

    }
}
