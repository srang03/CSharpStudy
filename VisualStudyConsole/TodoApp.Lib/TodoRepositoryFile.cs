using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoApp.Lib
{
    public class TodoRepositoryFile : ITodoRepository
    {
        private string _filePath = @"C:\Users\Ian\Desktop\ian\C#\CSharpStudy\Todos.txt";
        private static List<Todo> _repository;
   
        public TodoRepositoryFile()
        {
            string[] todos = File.ReadAllLines(_filePath, Encoding.UTF8);
            _repository = new List<Todo>();
            for (int i = 0; i < todos.Length; i++)
            {
                _repository.Add(new Todo()
                {
                    Id = int.Parse(todos[i].Split(',')[0]),
                    Title = todos[i].Split(',')[1],
                    Name = todos[i].Split(',')[2],
                    Created = DateTime.Parse(todos[i].Split(',')[3]),
                    IsDone = bool.Parse(todos[i].Split(',')[4])
                });    
            }
        }

        public Todo Add(Todo todo)
        {
            todo.Id = _repository.Max(t => t.Id) + 1;
            todo.Created = DateTime.Now;
            _repository.Add(todo);
            string content = $"\n{todo.Id},{todo.Title},{todo.Name},{todo.Created},{todo.IsDone}";
            File.AppendAllText(_filePath, content);
           
            return todo;
        }

        public List<Todo> GetAllTodos()
        {  
            return _repository;
        }

        public void DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
