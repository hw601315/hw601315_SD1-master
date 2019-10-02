using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hw601315_SD1.Models
{
    public class Vet
    {
        public int vetID { get; set; }

        [Display(Name = "Vet Name")]
        [Required(ErrorMessage = "Vet Name is a required field")]
        [StringLength(30)]
        public string vetName { get; set; }

        [Display(Name = "Technician Name")]
        [Required(ErrorMessage = "Technician Name is a required field")]
        [StringLength(30)]
        public string technicianName { get; set; }

        [Display(Name = "Vet Location")]
        public string vetLocation { get; set; }

        public ICollection<Visit> Visit { get; set; }
    }
}