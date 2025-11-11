namespace Reminder.Data
{
    public class TodoItem
    {
        public int UserID { get; set; }
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool IsDone { get; set; }
    }
}
