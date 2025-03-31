using BookOperations.BookOperations.CreateBook;
using BookOperations.BookOperations.GetBookById;
using BookOperations.BookOperations.GetBooks;
using BookOperations.BookOperations.UpdateBook;
using BookOperations.DBOperations;
using Microsoft.AspNetCore.Mvc;

namespace BookOperations.Controllers;

[Route("api/[controller]s")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly BookStoreDbContext _context;

    public BookController(BookStoreDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetBooks()
    {
        GetBooksQuery query = new(_context);
        var result = query.Handle();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {

        GetBooksByIdCommand command = new GetBooksByIdCommand(_context);

        try
        {
            command.Id = id;
            var result = command.Handle();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateBookModel newBook)
    {
        CreateBookCommand command = new CreateBookCommand(_context);
        try
        {
            command.Model = newBook;
            command.Handle();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return StatusCode(201,"Created");
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] UpdateBookModel updateModel)
    {
        UpdateBookCommand updateBookCommand = new UpdateBookCommand(_context);
        try
        {
            updateBookCommand.Id = id;
            updateBookCommand.Model = updateModel;
            updateBookCommand.Handle();
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Ok();
    }
}
