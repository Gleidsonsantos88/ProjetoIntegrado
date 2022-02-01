using IntegratedProject.Business.Customer.Interfaces;
using IntegratedProject.Business.Customer.Models;
using IntegratedProject.Data.Context;

namespace IntegratedProject.Data.Repository
{
    public class ClienteRepository: Repository<Client>, IClienteRepository
    {
        public ClienteRepository(IntegratedProjectDbContext context) : base(context) { }
    }
}
