namespace Reminder.Data
{
    public interface ITodoService
    {
        IEnumerable<TodoItem> GetAll();
        void Add(string title);
        void Toggle(int id);
        void Remove(int id);
    }
}