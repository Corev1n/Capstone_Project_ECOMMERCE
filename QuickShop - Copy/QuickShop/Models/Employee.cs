using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuickShop.Models
{
    public class Employee
    {
        public Employee() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_Id { get; set; }
        [Required(ErrorMessage = "Please fill out Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Format")]
        public string User_Name { get; set; }
        public string Image_Path { get; set; }
        [Required(ErrorMessage = "Please fill Full Name")]
        public string Full_Name { get; set; }
        public string Extension_Name { get; set; }
        [Required(ErrorMessage = "Please fill out Mobile Number")]
        [RegularExpression(@"\(?([0-9])\d{2})?[-\.\s]?(\d{5})[-\.\s]?(\d{4})", ErrorMessage = "Invalid Phone Number Format")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please fill out Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please fill out City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please fill out Province")]
        public string Province { get; set; }

    }
}
