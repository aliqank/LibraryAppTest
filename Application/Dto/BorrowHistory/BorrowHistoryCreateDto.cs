namespace Application.Dto.BorrowHistory;

public class BorrowHistoryCreateDto
{
    public int UserId { get; set; }
    public int BookId { get; set; }
    public int BorrowDurationInDays { get; set; }
}