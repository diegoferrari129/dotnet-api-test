using dotnet_api_test;
namespace dotnet_api_test.interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
    }
}
