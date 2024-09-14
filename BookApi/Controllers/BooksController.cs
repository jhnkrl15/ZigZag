// BooksController.cs
using BookApi.Application.Interfaces;
using BookApi.Commands;
using BookApi.Domain.Entities;
using BookApi.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _mediator.Send(new GetBookByIdQuery(id));
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _mediator.Send(new GetAllBooksQuery());
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Book book)
        {
            var id = await _mediator.Send(new CreateBookCommand(book));
            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(new UpdateBookCommand(book));
            return NoContent();
        }
    }
}
