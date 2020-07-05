﻿using System.ComponentModel.DataAnnotations;

namespace PrototypingASPNETCoreIdentity.Models.ViewModels
{
    public class UserCreationModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
