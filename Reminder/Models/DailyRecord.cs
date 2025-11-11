namespace Reminder.Data
{
    public class DailyRecord
    {
        public int UserID { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Title { get; set; }
        public string? Record { get; set; }
    }
}