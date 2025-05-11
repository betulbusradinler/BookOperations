using BookOperations.Application.GetBookById;
using FluentValidation;

namespace BookOperations.Application.BookOperations.Query.GetBookById
{
    public class GetBooksByIdCommandValidator:AbstractValidator<GetBooksByIdCommand>
    {
        public int Id { get; set; }

        public GetBooksByIdCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}