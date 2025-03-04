using dotnet_api_test.interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api_test;

public class CommentRepository : ICommentkRepository
{
    private readonly ApplicationDbContext _context;
    public CommentRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Comment>> GetAllAsync()
    {
        return await _context.Comments.ToListAsync();
    }
}
