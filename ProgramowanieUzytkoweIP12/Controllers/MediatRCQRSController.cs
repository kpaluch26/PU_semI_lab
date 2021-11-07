using MediatR;
using MediatRCQRS;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramowanieUzytkoweIP12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatRCQRSController : ControllerBase
    {
        private readonly IMediator mediator;

        public MediatRCQRSController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("/mediatR/authors")]
        public Task<List<AuthorDTO>> GetAuthors([FromQuery] GetAuthorsQueryM query)
        {
            return mediator.Send(query);
        }

        [HttpGet("/mediatR/author")]
        public Task<AuthorDTO> GetAuthor([FromQuery] GetAuthorQueryM query)
        {
            return mediator.Send(query);
        }

        [HttpPost("/mediatR/author/add")]
        public Task<bool> AddAuthor([FromBody] AddAuthorCommandM command)
        {
            return mediator.Send(command);
        }

        [HttpDelete("/mediatR/author/delete/{id}")]
        public Task<bool> DeleteAuthor(int id)
        {
            return mediator.Send(new DeleteAuthorCommandM(id));
        }

        [HttpPost("/mediatR/authors/rate/add")]
        public Task<bool> AddAuthorRate([FromBody] int id, int rate)
        {
            return mediator.Send(new AddAuthorRateCommandM(id, rate));
        }

        [HttpGet("/mediatR/books")]
        public Task<List<BookDTO>> GetBooks([FromQuery] GetBooksQueryM query)
        {
            return mediator.Send(query);
        }

        [HttpGet("/mediatR/book")]
        public Task<BookDTO> GetBook([FromQuery] GetBookQueryM query)
        {
            return mediator.Send(query);
        }

        [HttpPost("/mediatR/book/add")]
        public Task<bool> AddBook([FromBody] AddBookCommandM command)
        {
            return mediator.Send(command);
        }

        [HttpDelete("mediatR/book/delete/{id}")]
        public Task<bool> DeleteBook(int id)
        {
            return mediator.Send(new DeleteBookCommandM(id));
        }

        [HttpPost("/mediatR/book/rate/add")]
        public Task<bool> AddBookRate([FromBody] int id, int rate)
        {
            return mediator.Send(new AddBookRateCommandM(id, rate));
        }
    }
}
