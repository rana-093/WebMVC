using Demo_MVC.Context;
using Microsoft.EntityFrameworkCore;

namespace Demo_MVC.Service;

public class LoginService
{
    private readonly BlogDbContext _context;

    public LoginService(BlogDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> Login(string username, string password)
    {
        var doesUserMatch = await _context.Users.AnyAsync(u => u.Username == username && u.Password == password);
        return doesUserMatch;
    }
}