﻿using System.ComponentModel.DataAnnotations;

namespace krabs.Application.ViewModels.ClientsViewModel
{
    public class RemovePropertyViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ClientId { get; set; }
    }
}