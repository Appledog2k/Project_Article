namespace Articles.Models
{
    public class AccountManagerResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public DateTime? ExprieDate { get; set; }
    }
}