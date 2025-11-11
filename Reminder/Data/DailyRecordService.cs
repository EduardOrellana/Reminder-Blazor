using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reminder.Data
{
    public class DailyRecordService : IDailyRecordService
    {
        private readonly List<DailyRecord> _records = new();

        public Task<List<DailyRecord>> GetAllAsync()
        {
            return Task.FromResult(_records.OrderByDescending(r => r.Date).ToList());
        }

        public Task AddAsync(DailyRecord record)
        {
            record.Id = _records.Count + 1;
            _records.Add(record);
            return Task.CompletedTask;
        }
    }
}
