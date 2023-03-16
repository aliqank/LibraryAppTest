using Application.Services.Interfaces;
using Domain.Enum;
using Domain.Interfaces;

namespace Application.Services;

public class UserRatingJobService : IUserRatingJobService
{
    private readonly IUserRatingJobScheduler _userRatingJobScheduler;
    private readonly IUserService _userService;
    private readonly IBorrowHistoryService _borrowHistoryService;
    
    
    public UserRatingJobService(IUserRatingJobScheduler userRatingJobScheduler,
        IUserService userService,
        IBorrowHistoryService borrowHistoryService)
    {
        _userRatingJobScheduler = userRatingJobScheduler;
        _userService = userService;
        _borrowHistoryService = borrowHistoryService;
    }

    public void UpdateUserRating()
    {
        _userRatingJobScheduler.UpdateUserRating( () => _borrowHistoryService.UpdateUserRating());
    }
}