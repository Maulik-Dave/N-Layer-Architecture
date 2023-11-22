using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreApi.ViewModel
{
    public class EmployeeMasterViewModel
    {
        public int EmployeeMasterID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }

        [DisplayName("Birth Date")]
        [Required(ErrorMessage = "Birth Date is Required")]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Mobile No/Cell No")]
        [Required(ErrorMessage = "Mobile No/Cell No is Required")]
        [RegularExpression(@"\(?\+?\d(?=.*[0-9])[- +()0-9]{8,15}$", ErrorMessage = "Enter Correct Mobile No/Cell No.")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        [DisplayName("Email Address / User Name")]
        [Required(ErrorMessage = "Email Address is Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Enter Correct Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Is Preferred")]
        public bool IsFavourite { get; set; }

        [DisplayName("Display Order")]
        [Required(ErrorMessage = "Display Order is Required")]
        public int DisplayOrder { get; set; }

    }
}