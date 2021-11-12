using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuickShop.Models
{
    public class User
    {
        public User() { }
        public int User_Id { get; set; }
        [Required(ErrorMessage = "Please fill out Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Format")]
        public string User_Name { get; set; }
        [Required(ErrorMessage ="Please fill out Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}", ErrorMessage ="Must Contain 8 Character With alteast 1 Uppercase")]
        public string User_Password { get; set; }
        public string User_Type { get; set; }
    }
}
