using Application.Dto.Book;
using Domain.Entity;

namespace Application.Services.Interfaces;

public interface IBookService
{
    Task<List<BookReadDto>> GetAllAsync();
    Task<BookReadDto> CreateAsync(BookCreateDto book);
    Task UpdateBookStatusAsync(long bookId, bool value);
    Task<BookReadDto> GetByIdAsync(long id);
    Task<BookReadDto> Update(BookUpdateDto bookUpdateDto);

}