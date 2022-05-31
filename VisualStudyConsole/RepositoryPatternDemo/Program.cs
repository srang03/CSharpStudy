using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternDemo
{
    public interface ITableRepository
    {
        string GetAll();
    }

    public class TableInMemoryRepository : ITableRepository
    {
        public string GetAll()
        {
            return "인 메모리 데이터베이스 사용";
        }
    }

    public class TableSqlRepository : ITableRepository
    {
        public string GetAll() => "SQL Server 데이터베이스 사용";
    }

    public class TableXmlRepository : ITableRepository
    {
        public string GetAll() => "XML 데이터베이스 사용";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string repo = "SQL";

            ITableRepository repository;
            if (repo == "InMemory")
            {
                repository = new TableInMemoryRepository();
            }
            else if(repo == "SQL")
            {
                repository = new TableSqlRepository();
            }
            else if(repo == "XML")
            {
                repository = new TableXmlRepository();
            }
            else
            {
                repository = null;
            }

            Console.WriteLine(repository.GetAll());
        }
    }
}
