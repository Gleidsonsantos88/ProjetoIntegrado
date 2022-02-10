using IntegratedProject.Business.Customer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntegratedProject.Business.Models
{
    public class Service : Entity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        public bool Active { get; set; }
        
        public DateTime Created { get; set; }
        
        public DateTime? Updated { get; set; }

        public List<ServiceOrder> ServiceOrders { get; set; }
    }
}
