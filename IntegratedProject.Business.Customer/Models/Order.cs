using IntegratedProject.Business.Customer.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace IntegratedProject.Business.Models
{
    public class Order : Entity
    {
        public virtual Client Client { get; set; }
        [Required]
        public Guid ClientId { get; set; }
        public StatusOrder Status { get; set; }
        
        [MaxLength(500)]
        public string Note { get; set; }

        public virtual Adress Adress { get; set; }
        [Required]
        public Guid AdressId { get; set; }


        //public string created_user_id { get; set; }
        //public string updated_user_id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

    }
}
