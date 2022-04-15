using CompleteAspNetCoreWebApi.Data.Models;
using CompleteAspNetCoreWebApi.Data.Services;
using CompleteAspNetCoreWebApi.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompleteAspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorService.AddBook(author);
            return Ok();
         }

        [HttpGet("get-author-by-id/{id}")]
        public IActionResult AddAuthor(int id)
        {
          var author_book =  _authorService.GetAuthorWithBooks(id);
            return Ok(author_book);
        }

        [HttpGet("getSo")]
        public int getSo()
        {
            return 9;
        }


        [HttpGet("getSoIActionResult")]
        public IActionResult getSoIActionResult()
        {
            return Ok(9);
        }

        [HttpGet("getSoCustom")]
        public ActionResult<Student> getSoActionResult()
        {
            Student s = new Student() { Id = 1, Name = "loc" };
            return Ok(s);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
