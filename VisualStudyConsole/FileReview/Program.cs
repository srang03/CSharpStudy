using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Lib;

namespace FileReview
{
    internal class Program
    {
        static void PrintAll(List<Todo> todos)
        {
            Console.WriteLine("ID \t Name \t Title \t\t\t Created");
            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.Id} \t {todo.Name} \t {todo.Title} \t {todo.Created}");
            }

        }
        static void Main(string[] args)
        {
            ITodoRepository repository = new TodoRepositoryFile();
            var list = repository.GetAllTodos();

            bool proc = true;
            while (proc)
            {
                int menu = ShowMenu();
                // 메뉴 잘못 선택
                if (menu == -1)
                {
                    menu = -1;
                    Console.WriteLine("메뉴를 다시 입력해주세요.");
                }
                else
                {
                    switch (menu)
                    {
                        case 1:
                            ShowAll(list);
                            break;
                        case 2:
                            AddTodo(repository);
                            break;
                        case 5:
                            EndOfProgram(ref proc);
                            break;
                        default:
                            break;
                    }
                }
            }
            
            

         

          
        }

        private static void EndOfProgram(ref bool proc)
        {
            proc = false;
            Console.WriteLine("프로그램이 종료됩니다.");
        }

        private static void ShowAll(List<Todo> list)
        {
            PrintAll(list);
        }

        private static void AddTodo(ITodoRepository repository)
        {
            Console.WriteLine("제목을 입력해주세요:");
            string title = Console.ReadLine();
            Console.WriteLine("이름을 입력해주세요:");
            string name = Console.ReadLine();

            repository.Add(new Todo()
            {
                Title = title,
                Name = name,
                IsDone = false,
            });

            
        }

        static int ShowMenu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("메뉴를 선택해주세요");
            Console.WriteLine("[1] 리스트 출력 \t [2] 리스트 추가 \t [3] 리스트 삭제 \t [4] 리스트 수정 \t [5] 프로그램 종료");
            Console.WriteLine("-------------------------");

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0 && num < 6)
                {
                    return num;
                }
            }
            return -1;
    
        }
    }
}
