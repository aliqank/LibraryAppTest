using Application.Dto;
using Application.Dto.BorrowHistory;
using Domain.Entity;

namespace Application.Services.Interfaces;

public interface IBorrowHistoryService
{
    Task<List<BorrowReadDto>> GetAllAsync();
    Task<BorrowReadDto> CreateAsync(BorrowHistoryCreateDto borrowHistoryCreate);
    Task<BorrowReadDto> ReturnBook(BorrowReturnDto bookReturnDto);
    Task UpdateUserRating();
}