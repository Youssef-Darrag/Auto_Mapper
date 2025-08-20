using Auto_Mapper.DTOs;
using Auto_Mapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Auto_Mapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMapper _mapper;

        public BooksController(IMapper mapper)
        {
            _mapper = mapper;
        }

        List<Book> books = new()
        {
            new Book { BookId = 1, Title = "Test Title 1", Author = "Test Author 1", Summary = "Summary 1", Price = 100.5 },
            new Book { BookId = 2, Title = "Test Title 2", Author = "Test Author 2", Summary = "Summary 2", Price = 75.0 },
            new Book { BookId = 3, Title = "Test Title 3", Author = "Test Author 3", Summary = "Summary 3", Price = 0 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> GetAll()
        {
            var result = _mapper.Map<IEnumerable<BookDto>>(books);

            return Ok(result);
        }
    }
}
