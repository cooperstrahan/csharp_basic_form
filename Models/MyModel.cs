using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if((DateTime)value < DateTime.Today)
            {
                return new ValidationResult("You may not enter a previous day's date");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
    public class MyModel
    {
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        public string LastName { get; set; }

        [Required]
        [Range(0, 500)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password {get; set;}

        [Required]
        [FutureDate]
        public DateTime Date {get; set;}

    }
}