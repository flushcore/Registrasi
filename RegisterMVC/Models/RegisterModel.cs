using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisterMVC.Models
{
    public class RegisterModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "This field cannot empty!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field cannot empty!")]
        public string LastName { get; set; }
        public Nullable<System.DateTime> Birth { get; set; }
        public Nullable<int> Gender { get; set; }
        [Required(ErrorMessage = "This field cannot empty!")]
        [RegularExpression(@"^[+62]{3}\d*$", ErrorMessage = "Format Phone must begin with +62")]
        public string MobilePhone { get; set; }
        [Required(ErrorMessage = "This field cannot empty!")]
        public string Email { get; set; }
        public string Created_Date { get; set; }
    }
}