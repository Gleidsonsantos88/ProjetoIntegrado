using IntegratedProject.Business.Customer.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntegratedProject.Business.Models
{
    public class ServiceOrder : Entity
    {
        public Service Service { get; set; }

        [ForeignKey("ServiceId")]
        public Guid ServiceId { get; set; }

        public Order Order { get; set; }

        [ForeignKey("OrderId")]
        public Guid OrderId { get; set; }

        public virtual Technical Technical { get; set; }

        [ForeignKey("TechnicalId")]
        public Guid TechnicalId { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
