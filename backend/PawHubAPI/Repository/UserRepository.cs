using PawHubAPI.Data;
using PawHubAPI.Models;
using PawHubAPI.Repository.IRepository;

namespace PawHubAPI.Repository;

public class UserRepository : Repository<User>, IUserRepository
{
    private readonly ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    public async Task<User> UpdateAsync(User entity)
    {
        _db.Users.Update(entity);
        await _db.SaveChangesAsync();
        return entity;
    }
    
}