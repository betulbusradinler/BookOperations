using AutoMapper;
using BookOperations.Application.CreateBook;
using BookOperations.Application.GetBookById;
using BookOperations.Entities;
using BookOperations.GenreOperations.Query;
using static BookOperations.Application.GetBooks.GetBooksQuery;

namespace BookOperations.Common;
public class MappingProfile : Profile{
    public MappingProfile(){
        CreateMap<CreateBookModel, Book>();
        // CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt=>opt.MapFrom(src=>((GenreEnum)src.GenreId).ToString()));
        CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt=>opt.MapFrom(src=>src.Genre.Name));
        CreateMap<Book, GetBooksByIdModel>().ForMember(dest => dest.Genre, opt=>opt.MapFrom(src=>src.Genre.Name));
        CreateMap<Genre, GenresViewModel>();
        CreateMap<Genre, GenreDetailViewModel>();
    }
}