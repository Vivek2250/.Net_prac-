using day24_exercise1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace day24_exercise1.Models
{
    public interface IUser
    {
       //Task<List<User>> GetUser();
        Task CreateUser(User id);
        Task<User> GetUser(int id);

        //Task UpdateUser(User id);

        //Task DeleteUser(User id);

    }
    public class UserDetails : IUser
    {
        private readonly day24_exercise1Context _context;

        public UserDetails(day24_exercise1Context context)
        {
            _context = context;
        }
        public async Task CreateUser(User id)
        {
            
                if (_context.User == null)
                {
                    return;
                }
                _context.User.Add(id);
                await _context.SaveChangesAsync();
            }
        

        //public void DeleteUser(User id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<User> GetUser(int id)
        {
            if (_context.User == null)
            {
                return null;
            }
            return await _context.User.FindAsync(id);
        }

        //public void UpdateUser(User id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
