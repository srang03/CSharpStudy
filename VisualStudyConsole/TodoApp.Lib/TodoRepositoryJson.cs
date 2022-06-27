using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoApp.Lib
{
    public class TodoRepositoryJson : ITodoRepository
    {
        private string _filePath = @"C:\Users\Ian\Desktop\ian\C#\CSharpStudy\Todos.json";
        private static List<Todo> _repository;

        public TodoRepositoryJson()
        {
            _repository = new List<Todo>();

            string todos = File.ReadAllText(_filePath, Encoding.UTF8);
            _repository = JsonConvert.DeserializeObject<List<Todo>>(todos);
        }

        public Todo Add(Todo todo)
        {
            todo.Id = _repository.Max(t => t.Id) + 1;
            todo.Created = DateTime.Now;
            _repository.Add(todo);
            
            SetTodo();
            return todo;
        }
        public void SetTodo()
        {
            var res = JsonConvert.SerializeObject(_repository, Formatting.Indented);
            File.WriteAllText(_filePath, res);
        }

        public List<Todo> GetAllTodos()
        {
            return _repository;
        }

        public void DeleteTodo(int id)
        {
            _repository.RemoveAll(t => t.Id == id);
            SetTodo();
        }
    }
}
