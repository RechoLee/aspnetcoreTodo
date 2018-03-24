using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoreTodo.Models;

namespace aspnetcoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItem>> GetIncompleteItemAsync(ApplicationUser user);

        Task<bool> AddItemAsync(NewTodoItem item,ApplicationUser user);

        Task<bool> MarkDoneAsync(Guid id,ApplicationUser user);
    }
}
