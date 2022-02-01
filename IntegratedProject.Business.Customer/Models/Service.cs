using IntegratedProject.Business.Customer.Models;
using System.ComponentModel.DataAnnotations;

namespace IntegratedProject.Business.Models
{
    public class Service : Entity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}


/*

price | floaorders
id
client_id
status | enum
note |observação
adress_id
created_user_id
updated_user_id
created
updated

 
 
 */