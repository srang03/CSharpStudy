using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Lib;

namespace JsonConvertBuild
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
            ITodoRepository repository = new TodoRepositoryJson();
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
                        case 3:
                            DeleteTodo(repository);
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
        private static int getMaxId(ITodoRepository repository)
        {
            var list = repository.GetAllTodos();
            return list.Max(x => x.Id);
        }
        private static void DeleteTodo(ITodoRepository repository)
        {
            
            Console.WriteLine("삭제할 todo 리스트를 선택해주세요.");
            var input = Console.ReadLine();

            // [1] 숫자 입력 여부
            if(int.TryParse(input, out int id))
            {
                int max_id = getMaxId(repository);

                if (id > max_id || id < 0)
                {
                    Console.WriteLine("올바른 범위를 입력해주세요");
                }
                else
                {
                    repository.DeleteTodo(id);
                    Console.WriteLine("삭제가 완료되었습니다.");
                }
                return;
            }
            else
            {
                Console.WriteLine("올바른 아이디를 입력해주세요");
                return;
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
            Console.WriteLine("이름을 입력해주세요:");
            string name = Console.ReadLine();
            Console.WriteLine("제목을 입력해주세요:");
            string title = Console.ReadLine();

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
