using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoreTodo.Models;
using aspnetcoreTodo.Data;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoreTodo.Services
{
    public class TodoItemService:ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<TodoItem>> GetIncompleteItemAsync()
        {
            var items =await _context.Items
                .Where(x => x.IsDone == false)
                .ToArrayAsync();
            return items;
        }

        public async Task<bool> AddItemAsync(NewTodoItem newItem)
        {
            var entity = new TodoItem
            {
                Id = Guid.NewGuid(),
                IsDone = false,
                Title = newItem.Title,
                DueAt = DateTimeOffset.Now.AddDays(10)
            };
            _context.Items.Add(entity);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }



    }
}
