using System.Collections.Generic;

namespace CompleteAspNetCoreWebApi.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //navigate properties

        public List<Book_Author> Book_Authors { get; set; }

    }
}
