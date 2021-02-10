using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrystalReportsAsp.netMVCIntro.ViewModel
{
    public class EmployeeVM
    {
        public int EmployeeId { get; set; }

        [StringLength(15)]
        [DisplayName("First Name*")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(15)]
        [DisplayName("Last Name*")]
        [Required]
        public string LastName { get; set; }

        [StringLength(30)]
        [DisplayName("Email Address*")]
        [Required]
        public string Email { get; set; }

        [StringLength(15)]
        [DisplayName("Phone Number*")]
        [Required]
        [RegularExpression("^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Not a valid email")]
        public string Phone { get; set; }

        [DisplayName("Years of Exprience*")]
        [Required]
        public int? Experience { get; set; }
    }
}