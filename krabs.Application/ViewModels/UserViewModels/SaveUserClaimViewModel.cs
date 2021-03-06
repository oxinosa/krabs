﻿using System.ComponentModel.DataAnnotations;

namespace krabs.Application.ViewModels.UserViewModels
{
    public class SaveUserClaimViewModel
    {
        [Required]
        public string Value { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
