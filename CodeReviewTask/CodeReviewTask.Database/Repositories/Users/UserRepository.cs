﻿using CodeReviewTask.Database.Contexts;
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

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        public User GetById(int id)
        {
            var sebaToJavoviec = _context.Users.ToList();
            var user = _context.Users.SingleOrDefault(x => x.Id == id);
            
            return user;
        }
    }
}