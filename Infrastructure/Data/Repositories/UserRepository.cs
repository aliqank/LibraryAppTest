using Domain.Entity;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class UserRepository : RepositoryBase<User>,IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
    
    public async Task<List<User>> FindAllAsync()
    {
        return await _context.Users
            .Include(u => u.Books)
            .Include(b=>b.BorrowHistory)
            .ToListAsync();
    }

    public async Task<User> GetByIdAsync(long id)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
    }
    
    public async Task<List<User>> GetByIdsAsync(List<long> ids)
    {
        return await _context.Users.Where(u => ids.Any(id => u.Id == id)).AsNoTracking().ToListAsync();
    }
    
    public async Task<List<User>> GetOverDueBorrows()
    {
        return await _context.Users
            .Where(u => u.BorrowHistory.Any(bh => bh.DueDate < DateTime.UtcNow & !bh.IsReturned))
            .Include(b =>b.BorrowHistory)
            .ToListAsync();
    }
}