using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameShop2.Models
{
    public class User
    {


        public enum UserType { User, Employee, Manager};

        [Required]
        [Key]
        public int userID { get; set; }

        [StringLength(50, MinimumLength =2, ErrorMessage = "Your name cannot overlapp 50 characters")]
        public string userFirstName { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Your name cannot overlapp 50 characters")]
        public string userLastName { get; set; }

        [Required(ErrorMessage = "Your date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }

        [Required(ErrorMessage = "An username is required")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Your username must be between 8 and 20 carachters long")]
        public string username { get; set; }

        [Required(ErrorMessage = "A password is required")]
        [StringLength(20, MinimumLength =8, ErrorMessage = "Your password must be between 8 and 20 carachters long")]
        public string password { get; set; }

        [Required(ErrorMessage = "Retype your Password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Your password must be between 8 and 20 carachters long")]
        //[Compare("password", ErrorMessage="The passwords do not match.")]
        public string rePassword { get; set; }

        [Required(ErrorMessage = "Your email address is required")]
        [EmailAddress(ErrorMessage = "Please set an email")]
        public string email { get; set; }

        [EnumDataType(typeof(UserType))]
        public UserType userType = UserType.User;

        public List<Products> whishListID { get; set; }


        // An IVALIDATOR will be used for the age, the user must have at least 18 year old. 

    }
}