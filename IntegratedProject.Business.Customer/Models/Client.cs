using IntegratedProject.Business.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace IntegratedProject.Business.Customer.Models
{
    public class Client : Entity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(11)]
        public string CPF { get; set; }
        [MaxLength(14)]
        public string CNPJ { get; set; }
        public virtual Adress Adress { get; set; }
        [Required]
        public Guid AdressId { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Order Order { get; set; }

    }
}
