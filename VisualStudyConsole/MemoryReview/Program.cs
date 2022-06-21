using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Lib;

namespace MemoryReview
{
    internal class Program
    {
        static void ShowAll(List<Todo> todos)
        {
            Console.WriteLine("ID \t Name \t Title \t\t\t Created");
            foreach(var todo in todos)
            {
                Console.WriteLine($"{todo.Id} \t {todo.Name} \t {todo.Title} \t {todo.Created}");
            }
        }
        static void Main(string[] args)
        {
            ITodoRepository _list = new TodoRepositoryInMemory();

            var _todos = _list.GetAllTodos();

            ShowAll(_todos);

            _list.Add(new Todo()
            {
                Name = "성우",
                Title = "Dapper 공부",
                Created = DateTime.Now,
            });
            ShowAll(_todos);

        }
    }
}
