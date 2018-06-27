using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class DateAddedAfterReleaseDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;
            if (movie.DateAdded < movie.ReleaseDate)
            {
                return new ValidationResult("The Date Added must be greater than or equal to the Release Date.");
            }
            return ValidationResult.Success;
        }
    }
}