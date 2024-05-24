using CodeReviewTask.Database.Entities;

namespace CodeReviewTask.Database.Repositories.Users
{
    public interface IUserRepository
    {
        void Delete(User user);
        User GetById(int id);
    }
}