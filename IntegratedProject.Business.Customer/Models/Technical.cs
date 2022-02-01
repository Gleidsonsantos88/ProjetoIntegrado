using IntegratedProject.Business.Customer.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace IntegratedProject.Business.Models
{
    public class Technical : Entity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}

