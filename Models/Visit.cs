using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hw601315_SD1.Models
{
    public class Visit
    {
        public int visitID { get; set; }
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }

        [Display(Name = "Visit Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime visitDate { get; set; }

        [Display(Name = "Diagnosis")]
        [Required(ErrorMessage = "Diagnosis is a required field")]
        [StringLength(100)]
        public string diagnosis { get; set; }

        [Display(Name = "Weight")]
        [Required(ErrorMessage = "Weight is a required field")]
        [StringLength(15)]
        public string weight { get; set; }

        [Display(Name = "Visit Cost")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Visit Cost is a required field")]
        public decimal visitCost { get; set; }
    }
}