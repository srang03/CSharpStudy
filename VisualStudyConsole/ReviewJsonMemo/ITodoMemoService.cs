using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewJsonMemo
{
    public interface ITodoMemoService
    {
        bool AddTodoMemo(TodoMemo todo);
        bool EditTodoMemo(TodoMemo todo);
        bool DeleteTodoMemo(int id);
        TodoMemo GetDetailTodoMemo(int id);
        List<TodoMemo> GetListTodoMemo();
       
    }
}
