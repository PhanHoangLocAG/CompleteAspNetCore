using System.Collections.Generic;

namespace CompleteAspNetCoreWebApi.Data.ViewModels
{
    public class AuthorVM
    {
        public string FullName { get; set; }
    }

    public class AuthorWithBookVM
    {
        public string FullName { get; set; }
        public List<string> BookTitle { get; set; }
    }
}
