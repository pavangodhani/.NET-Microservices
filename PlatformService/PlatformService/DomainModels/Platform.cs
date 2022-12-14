using System;
using System.ComponentModel.DataAnnotations;

namespace PlatformService.DomainModels
{
	public class Platform
	{
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Cost { get; set; }

        public Platform() { }
    }
}

