using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hw601315_SD1.Models
{
    public class Pet
    {
        public int petID { get; set; }

        [Display(Name = "Pet Name")]
        [Required(ErrorMessage = "Pet Name is a required field")]
        [StringLength(15)]
        public string petName { get; set; }

        [Display(Name = "Breed")]
        [Required(ErrorMessage = "Breed is a required field")]
        [StringLength(15)]
        public string breed { get; set; }

        [Display(Name = "Pet Age")]
        [Required(ErrorMessage = "Pet Age is a required field")]
        public int petAge { get; set; }

        [Display(Name = "Owner First Name")]
        [Required(ErrorMessage = "Owner First Name is a required field")]
        [StringLength(15)]
        public string ownerFirstName { get; set; }

        [Display(Name = "Owner Last Name")]
        [Required(ErrorMessage = "Owner Last Name is a required field")]
        [StringLength(15)]
        public string ownerLastName { get; set; }


        public string ownerFullName
        {
            get
            {
                return ownerLastName + ", " + ownerFirstName;
            }
        }

        [Display(Name = "Owner Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string ownerPhoneNumber { get; set; }


        public ICollection<Visit> Visit { get; set; }
    }
}