﻿using Dapper;
using Geek_Text.Models;

namespace Geek_Text.Repositories
{
    public class CommentRepository
    {
        private readonly DatabaseContext _context;
        public CommentRepository(DatabaseContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<UserComment> AddComment(UserComment userRating)
        {
            using (var connection = _context.CreateConnection())
            {
                await connection.QueryAsync<UserComment>("INSERT INTO BookComment(Comment, BookISBN, Created, UserId) VALUES (@Comment, @BookISBN, @Created, @UserId)", userRating);
            }

            return userRating;
        }

        public async Task<IEnumerable<UserComment>> GetComments(string bookIsbn)
        {
            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<UserComment>("SELECT * FROM BookComment WHERE BookISBN=@BookISBN;", new { BookISBN = bookIsbn});
            }
        }

    }
}
