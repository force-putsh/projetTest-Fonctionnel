using EFProject.Context;
using EFProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFProject.Repository;

public class UserRepository
{
    private UserDbContext _context = new UserDbContext();
    
    public async Task<List<Users>> GetUser()
    {
        return await _context.Users.ToListAsync();
    }
}