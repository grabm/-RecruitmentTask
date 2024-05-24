using CodeReviewTask.Database.Entities;

namespace CodeReviewTask.Database.Repositories.Users
{
    public interface IUserRepository
    {
        void Delete(int id);
        User GetById(int id);
    }
}