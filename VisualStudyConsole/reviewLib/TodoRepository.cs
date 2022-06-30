using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace reviewLib
{

    public class DBConn
    {
        private const string _connection_str = @"Data Source = 121.190.105.66;
                                            database=Exercise;
			                                User ID = urock;
                                            Password= urock123;
			                                Connect Timeout = 30;";
        public string Proc { get; set; }

        private SqlConnection _conn;
        public DBConn()
        {
            _conn = new SqlConnection(_connection_str);
            Proc = string.Empty;
        }

        public List<TodoModel> ExecuteReturnList(DynamicParameters parm, System.Data.CommandType type)
        {
            return _conn.Query<TodoModel>(Proc, parm, commandType: type).ToList();
        }

        public bool ExecuteReturnBool(DynamicParameters parm, System.Data.CommandType type)
        {
            var res = _conn.Execute(Proc, parm, commandType: type);
            return res > 0;
        }

        public TodoModel ExecuteReturnTodo(DynamicParameters parm, System.Data.CommandType type)
        {
            try
            {
                return _conn.Query<TodoModel>(Proc, parm, commandType: type).Single();
            }
            catch (Exception ex)
            {
                return null;
            }

         

            }

        public bool OpenDBConnection()
        {
            if (_conn.State == System.Data.ConnectionState.Closed)
            {
                _conn.Open();
                return true;
            }
            return false;
        }

        public bool CloseDBConnection()
        {
            if(_conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
                return true;
            }
            return false;
        }


    }
    public class TodoRepository : ITodoRepository
    {
        private List<TodoModel> _repository;
        public TodoRepository()
        {
            _repository = new List<TodoModel>();
        }

        public bool AddTodo(TodoModel todo)
        {
            DBConn conn = new DBConn();
            if (conn.OpenDBConnection())
            {
                conn.CloseDBConnection();
                return true;
            }
            return false;
        }

        public bool DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditTodo(TodoModel todo)
        {
            throw new NotImplementedException();
        }

        public List<TodoModel> GetAllTodos()
        {
            throw new NotImplementedException();
        }

        public List<TodoModel> GetSearchTodos()
        {
            throw new NotImplementedException();
        }

        public TodoModel GetTodo()
        {
            throw new NotImplementedException();
        }

        public int GetTodosCount()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoModel> Orderging(OptionOrder option)
        {
            throw new NotImplementedException();
        }

        public List<TodoModel> Paging(int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
