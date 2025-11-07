using System.Collections.Generic;
using System.Linq;

namespace Reminder.Data
{
    public class TodoService : ITodoService
    {
        private readonly List<TodoItem> _items = new();

        public IEnumerable<TodoItem> GetAll() => _items;

        public void Add(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
                _items.Add(new TodoItem { Id = _items.Count + 1, Title = title, IsDone = false });
        }

        public void Toggle(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item != null)
                item.IsDone = !item.IsDone;
        }

        public void Remove(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item != null)
                _items.Remove(item);
        }
    }
}
