using System.ComponentModel.DataAnnotations;

namespace mvc.Models.UIMODELS
{
    public class MCustomer
    {
        //[Required(ErrorMessage ="Name is mandatory")]
        [EmailAddress(ErrorMessage ="Invalid email format")]
        [Required(ErrorMessage ="Email is mandatory")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Password is mandatory")]
        public string password { get; set; }

    }
}
