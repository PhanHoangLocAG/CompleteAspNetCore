using CompleteAspNetCoreWebApi.Data.Models;
using CompleteAspNetCoreWebApi.Data.ViewModels;
using System.Linq;

namespace CompleteAspNetCoreWebApi.Data.Services
{
    public class AuthorService
    {
        private AppDbContext _context;

        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(AuthorVM author)
        {
            var _author = new Author()
            {
               FullName = author.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBookVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(a => a.Id == authorId).Select(a => new AuthorWithBookVM()
            {
                FullName = a.FullName,
                BookTitle = a.Book_Authors.Select(b => b.Book.Title).ToList()
            }).FirstOrDefault();
            return _author;
        }
    }
}
