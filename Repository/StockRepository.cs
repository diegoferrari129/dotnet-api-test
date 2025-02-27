using dotnet_api_test.interfaces;
using dotnet_api_test;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api_test.Repository;

public class StockRepository : IStockRepository
{
    private readonly ApplicationDbContext _context;
    public StockRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task<List<Stock>> GetAllAsync()
    {
        return _context.Stocks.ToListAsync();
    }
}
