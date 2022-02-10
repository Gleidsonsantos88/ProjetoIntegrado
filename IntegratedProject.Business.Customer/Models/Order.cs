using IntegratedProject.Business.Customer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntegratedProject.Business.Models
{
    public class Order : Entity
    {
        public Client Client { get; set; }

        [Required]
        [ForeignKey("ClientId")]
        public Guid ClientId { get; set; }
        public StatusOrder Status { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public List<ServiceOrder> ServiceOrders { get; set; }
    }
}
