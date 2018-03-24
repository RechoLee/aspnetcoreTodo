using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoreTodo.Models;

namespace aspnetcoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<IEnumerable<TodoItem>> GetIncompleteItemAsync();

        Task<bool> AddItemAsync(NewTodoItem item);
    }
}
