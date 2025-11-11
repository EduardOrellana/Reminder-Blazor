using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reminder.Data
{
    public interface IDailyRecordService
    {
        Task<List<DailyRecord>> GetAllAsync();
        Task AddAsync(DailyRecord record);
    }
}
