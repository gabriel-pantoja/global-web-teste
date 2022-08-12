using GlobalWeb.Infra.Data.Entities;
using System.Threading.Tasks;

namespace GlobalWeb.Infra.Repository.Interfaces
{
    public interface IClientRepository: IRepositoryBase<Client>
    {
        Task<Client> GetByDocument(string document);
    }
}
