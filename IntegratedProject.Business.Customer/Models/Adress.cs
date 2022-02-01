﻿using IntegratedProject.Business.Customer.Models;
using System.ComponentModel.DataAnnotations;

namespace IntegratedProject.Business.Models
{
    public class Adress : Entity
    {
        [Required]
        [MaxLength(200)]
        public string Street { get; set; }

        [Required]
        [MaxLength(200)]
        public string District { get; set; }

        [Required]
        [MaxLength(200)]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        public string State { get; set; }

        [Required]
        public int Number { get; set; }
        public string Complement { get; set; }

        [Required]
        [MaxLength(8)]
        public string Cep { get; set; }

        public virtual Client Client { get; set; }
        public virtual Order Order { get; set; }
    }
}
