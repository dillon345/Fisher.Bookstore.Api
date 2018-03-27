using System;
using System.Collections;
using System.Collections.Generic;

namespace Fisher.Bookstore.Api.Data
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Bio { get; set; }

        public List<Book> Titles { get; set; }
    }
}