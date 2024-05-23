using CodeReviewTask.Database.Contexts;
using CodeReviewTask.Database.Entities;
using System;

namespace CodeReviewTask.Database.Repositories.Users
{
    public class UserRepository
    {
        private readonly CodeReviewTaskContext _context;

        public UserRepository(CodeReviewTaskContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}