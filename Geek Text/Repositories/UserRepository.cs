﻿using Dapper;
using Geek_Text.Models;

namespace Geek_Text.Repositories
{
    public class UserRepository
    {
        private readonly DatabaseContext _context;
        public UserRepository(DatabaseContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<User> GetUser(User user)
        {
            using (var connection = _context.CreateConnection())
            {
                if (user.Email is null)
                    return await connection.QuerySingleOrDefaultAsync<User>("SELECT * FROM users WHERE Id=@Id;", new { Id = user.Id });

                return await connection.QueryFirstAsync<User>("SELECT * FROM users WHERE Email=@Email;", new { Email = user.Email });

            }
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<User>("SELECT * FROM users;");
            }
        }
    }
}
