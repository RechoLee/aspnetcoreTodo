﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoreTodo.Models;

namespace aspnetcoreTodo.Services
{
    public class FakeTodoItemService:ITodoItemService
    {
        /// <summary>
        /// 返回一个item数组
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<TodoItem>> GetIncompleteItemAsync(ApplicationUser user)
        {
            IEnumerable<TodoItem> items = new[]
            {
                new TodoItem
                {
                    Id=Guid.NewGuid(),
                    IsDone=true,
                    Title="Learn asp.net core",
                    DueAt=DateTimeOffset.Now.AddDays(2)
                },
                new TodoItem
                {
                    Title="Build apps",
                    IsDone=true,
                    DueAt=DateTimeOffset.Now.AddMonths(1)
                },
                new TodoItem
                {
                    Title="go to beijing",
                    DueAt=DateTimeOffset.Now.AddMonths(5)
                }
            };

            return Task.FromResult(items);
        }

        public Task<bool> AddItemAsync(NewTodoItem item,ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> MarkDoneAsync(Guid id,ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
