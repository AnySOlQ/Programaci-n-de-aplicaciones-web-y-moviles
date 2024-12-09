using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static readonly List<Book> Books = new()
        {
            new Book { Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 }
        };

        // GET: api/books
        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return Books;
        }

        // POST: api/books
        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            if (Books.Any(b => b.Title.Equals(newBook.Title, StringComparison.OrdinalIgnoreCase)))
            {
                return BadRequest("A book with the same title already exists.");
            }

            Books.Add(newBook);
            return Ok(new { message = $"Book '{newBook.Title}' added!" });
        }

        // DELETE: api/books/{title}
        [HttpDelete("{title}")]
        public IActionResult DeleteBook(string title)
        {
            var book = Books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book == null)
            {
                return NotFound("Book not found.");
            }

            Books.Remove(book);
            return Ok(new { message = $"Book '{title}' deleted." });
        }

        // GET: /
        [HttpGet("/")]
        public IActionResult Root()
        {
            return Ok("Welcome to the Library API! Use /api/books to interact with the API.");
        }
    }

    // Book model
    public class Book
    {
        public required string Title { get; set; } = string.Empty;
        public required string Author { get; set; } = string.Empty;
        public int Year { get; set; }
    }
}
