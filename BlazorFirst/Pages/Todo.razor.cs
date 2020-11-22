using AntDesign;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFirst.Pages
{
    public partial class Todo
    {
        private IList<TodoList.TodoItem> todos = new List<TodoList.TodoItem>();
        [Parameter]
        public string newTodo { get; set; }        

        private void AddTodo()
        {
            if (!string.IsNullOrEmpty(newTodo))
            {
                todos.Add(new TodoList.TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }

    }
}
