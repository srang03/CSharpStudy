using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        private static List<Todo> _list = new List<Todo>();
        public TodoRepositoryInMemory()
        {
            // 기본 데이터 생성
            _list = new List<Todo>()
            {
                new Todo() {Id =1, Title= "ASP.NET" , IsDone=false},
                new Todo() {Id =2, Title= "C#" , IsDone=false},
                new Todo() {Id =3, Title= "Blazor" , IsDone=false},
            };
        }

        public void Add(Todo todo)
        {
            todo.Id = _list.Max(todo => todo.Id) + 1;
            _list.Add(todo);
        }

        public bool Delete(int id)
        {
            int reulst = _list.RemoveAll(todo => todo.Id == id);
            return reulst > 0;
        }

        public List<Todo> GetAll()
        {
            return _list;
        }

        public Todo GetTodo(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Todo todo)
        {
            try
            {
                int index = _list.FindIndex(x => x.Id == todo.Id);
                _list[index].Title = todo.Title;
                _list[index].IsDone = todo.IsDone;
                return true;
            }catch (Exception e)
            {
                return false;
            }
  
        }

        
    }
}
