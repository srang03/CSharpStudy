using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Models;

namespace TodoApp.Conosle.Program
{
    public class Program
    {
        static void PrintAll(List<Todo> list)
        {
            Console.WriteLine("=====================================");
            foreach(Todo t in list)
            {
                Console.WriteLine($"{t.Id}\t\t {t.Title}\t\t {t.IsDone}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");

            // [1] 데이터 출력
            ITodoRepository _repository = new TodoRepositoryInMemory();
            List<Todo> todos = new List<Todo>();
            todos = _repository.GetAll();

            PrintAll(todos);

            // [2] 데이터 입력
            _repository.Add(new Todo()
            {
                Title = "Speed Run",
                IsDone = false
            });

            PrintAll(todos);

            // [3] 데이터 삭제
            _repository.Delete(1);

            PrintAll(todos);

            // [4] 데이터 수정

            _repository.Update(new Todo()
            {
                Id = 2,
                Title = "수정 테스트",
                IsDone = true
            });

            PrintAll(todos);
        }
    }
}
