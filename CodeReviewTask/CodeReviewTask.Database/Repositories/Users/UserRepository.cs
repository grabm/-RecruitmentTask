using CodeReviewTask.Database.Contexts;
using CodeReviewTask.Database.Entities;

namespace CodeReviewTask.Database.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly CodeReviewTaskContext _context;

        public UserRepository(CodeReviewTaskContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);

            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        public User GetById(int id)
        {
            var user = _context.Users.Find(id);
            
            return user;
        }
    }
}