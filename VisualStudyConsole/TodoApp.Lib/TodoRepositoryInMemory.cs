using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Lib
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        private static List<Todo> _repository;
        public TodoRepositoryInMemory()
        {
            _repository = new List<Todo>();
            _repository.Add(new Todo()
            {
                Id = 1,
                Title = "ASP.NET",
                Name = "이안",
                Created = DateTime.Now,
                IsDone = false,
            });
        }
        public Todo Add(Todo todo)
        {
            todo.Id = _repository.Max(t => t.Id) + 1;
            _repository.Add(todo);
            return todo;
        }

        public void DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAllTodos()
        {  
            return _repository;
        }
    }
}
