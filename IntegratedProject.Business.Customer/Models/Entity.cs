using System;
using System.ComponentModel.DataAnnotations;

namespace IntegratedProject.Business.Customer.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
    }
}
