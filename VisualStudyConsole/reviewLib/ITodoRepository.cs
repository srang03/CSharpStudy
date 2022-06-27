using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewLib
{
    public enum OptionOrder
    {
        ASC,
        DESC,
        Default
    }

    internal interface ITodoRepository
    {
        List<TodoModel> GetAllTodos();
        TodoModel GetTodo();
        List<TodoModel> GetSearchTodos();
        int GetTodosCount();
        List<TodoModel> Paging(int page, int pageSize);

        bool AddTodo(TodoModel todo);
        bool EditTodo(TodoModel todo);
        bool DeleteTodo(int id);
        IEnumerable<TodoModel> Orderging(OptionOrder option);
    }
}
