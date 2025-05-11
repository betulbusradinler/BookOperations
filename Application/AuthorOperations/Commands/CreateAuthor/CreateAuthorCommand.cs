using AutoMapper;
using BookOperations.DBOperations;

namespace BookOperations.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand
    {
        public CreateAuthorModel Model {get; set;}
        private readonly IMapper _mapper;
        private readonly BookStoreDbContext _bookStoreDbContext;
        public CreateAuthorCommand(IMapper mapper, BookStoreDbContext bookStoreDbContext)
        {
            _mapper = mapper;
            _bookStoreDbContext = bookStoreDbContext;
        }
        public void Handle(){

        }
    }

    public class CreateAuthorModel
    {
        public string Name {get; set;}
        public string LastName {get; set;}
        public DateTime BirthDay {get; set;}
    }
}