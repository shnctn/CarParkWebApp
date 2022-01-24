using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarPark.Models.RequestModels.Account
{
     public class RegisterCreateModel
    {
        [Required(ErrorMessage = "Zorunlu")]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Zorunlu")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email adres formatında olması gerekir.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Zorunlu")]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "Minimum 6 karakterden olma zorunda", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Zorunlu")]
        [Display(Name = "PasswordConfirm")]
        [Compare("Password",ErrorMessage = "Şifreler Eşleşmiyor.")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

    }
}
