using System.Collections.Generic;

namespace CompleteAspNetCoreWebApi.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //navigate properties
        public List<Book> Books { get; set; }
    }
}
