using System.Collections.Generic;

namespace TodoApp.Lib
{
    public interface ITodoRepository
    {
        Todo Add(Todo todo);
        List<Todo> GetAllTodos();
    }
}
