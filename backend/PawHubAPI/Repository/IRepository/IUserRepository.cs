using PawHubAPI.Models;

namespace PawHubAPI.Repository.IRepository;

public interface IUserRepository: IRepository<User>
{
    Task<User> UpdateAsync(User entity);
}