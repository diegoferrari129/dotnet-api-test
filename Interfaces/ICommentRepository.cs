using dotnet_api_test;

namespace dotnet_api_test.interfaces
{
    public interface ICommentkRepository
    {
        Task<List<Comment>> GetAllAsync();

    }
}
