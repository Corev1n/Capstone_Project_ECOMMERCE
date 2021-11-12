using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuickShop.Models
{
    public class Customer
    {
        public Customer() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_Id { get; set; }
        [Required(ErrorMessage = "Please fill out Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Format")]
        public string User_Name { get; set; }
        public string Image_Path { get; set; }
        public string Full_Name { get; set; }
        public string Extension_Name { get; set; }
        public string Mobile { get; set; }
        public string Customer_Status { get; set; }
    }
}
