using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet, Authorize]
        public IEnumerable<Book> Get()
        {
            var currentUser = HttpContext.User;
            var resultBookList = new Book[] {
            new Book { Author = "Dean Graziosi",Title = "Millionaire Succes Habit" },
            new Book { Author = "Cal Newport", Title = "Be so good they can't ignore you" },
            new Book { Author = "Shiv Khera", Title = "You can win" },
            new Book { Author = "Paulo Coelho", Title = "The Alchemist" }
      };

            return resultBookList;
        }


        public class Book
        {
            public string Author { get; set; }
            public string Title { get; set; }
            public bool AgeRestriction { get; set; }
        }
    }

}
