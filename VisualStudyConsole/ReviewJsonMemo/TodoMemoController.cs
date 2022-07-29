using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReviewJsonMemo
{
    public class TodoMemoController : ITodoMemoService
    {
        List<TodoMemo> _repository = new List<TodoMemo>();

        private string _file_path = Application.StartupPath + "\\TodoMemo.json";
        public TodoMemoController()
        {
            if (File.Exists(_file_path))
            {
                string todos = File.ReadAllText(_file_path, Encoding.Default);
                _repository = JsonConvert.DeserializeObject<List<TodoMemo>>(todos);
            }
            else
            {
                _repository = new List<TodoMemo>();
            }
        }

        public bool AddTodoMemo(TodoMemo todo)
        {
            try
            {
                try
                {
                    todo.Id = _repository.Max(x => x.Id) + 1;
                }
                catch
                {
                    todo.Id = 1;
                }


                todo.dateTime = DateTime.Now;
                _repository.Add(todo);

                var json = JsonConvert.SerializeObject(_repository, Formatting.Indented);
                File.WriteAllText(_file_path, json);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteTodoMemo(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditTodoMemo(TodoMemo todo)
        {
            throw new NotImplementedException();
        }

        public TodoMemo GetDetailTodoMemo(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoMemo> GetListTodoMemo()
        {
            return _repository;
        }
    }
}
