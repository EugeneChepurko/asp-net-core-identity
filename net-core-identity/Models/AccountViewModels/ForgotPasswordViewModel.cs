﻿using System.ComponentModel.DataAnnotations;

namespace net_core_identity.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
