using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    internal class Program
    {
        // 리파지토리 클래스 참조
        static CategoryRepositoryInMemory _category;

        private static void PrintCategories(List<Category> categories)
        {
            foreach(Category category in categories)
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }
        }

        private static void HasCategory()
        {
            if(_category.Has() > 0)
            {
                Console.WriteLine("기본 데이터가 있습니다.");
            }
            else
            {
                Console.WriteLine("기본 데이터가 없습니다.");
            }
        }

        private static void ReadCategories()
        {
            var categories = _category.Read();
            PrintCategories(categories);
        }

        private static void AddCategory()
        {
            var category = new Category() { CategoryName = "생활용품" };
            _category.Add(category);
            ReadCategories();
        }

        private static void DeleteCategory(int id)
        {
            Console.WriteLine($"{id}번을 삭제합니다.");
            _category.Delete(id);
            ReadCategories();

        }

        static void Main(string[] args)
        {
            _category = new CategoryRepositoryInMemory();

            ReadCategories();
            AddCategory();
            DeleteCategory(4);
        }
    }
}
