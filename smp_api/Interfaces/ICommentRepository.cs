using smp_api.Models;

namespace smp_api.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();   



    }
}
