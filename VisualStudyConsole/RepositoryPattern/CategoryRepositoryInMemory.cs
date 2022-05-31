using Dul.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    internal class CategoryRepositoryInMemory : ICategoryRepository
    {
        private static List<Category> _categories = new List<Category>();

        public CategoryRepositoryInMemory()
        {
            _categories = new List<Category>()
              {
                  new Category() { CategoryId = 1, CategoryName ="책"},
                  new Category() { CategoryId = 2, CategoryName ="강의"},
                  new Category() { CategoryId = 3, CategoryName ="컴퓨터"},
              };
        }
        public Category Add(Category model)
        {
            model.CategoryId = _categories.Max(c => c.CategoryId) + 1;
            _categories.Add(model);
            return model;
        }

        public Category Browse(int id)
        {
            return _categories.Where(c => c.CategoryId == id).SingleOrDefault();
        }

        public bool Delete(int id)
        {
            int r = _categories.RemoveAll(c => c.CategoryId == id);
            if(r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Edit(Category model)
        {
            var result = _categories.Where(c => c.CategoryId == model.CategoryId).Select(c => { c.CategoryName = model.CategoryName; return c; }).SingleOrDefault();
            
            if(result != null)
            {
                return true;
            }

            return false;
        }

        public int Has()
        {
            return _categories.Count;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public List<Category> Ordering(OrderOption orderOption)
        {
            List<Category> categories;
            switch (orderOption)
            {
                case OrderOption.Ascending:
                    categories = _categories.OrderBy(c => c.CategoryName).ToList();
                    break;
                case OrderOption.Descending:
                    categories = (from c in _categories orderby c.CategoryName descending select c).ToList();
                    break;
                default:
                    categories = _categories;
                    break;
            }
            return categories;
        }

        /// <summary>
        /// 페이징
        /// </summary>
        /// <param name="page">페이징 번호</param>
        /// <param name="pageSize">페이지 크기 : 한 페이지당 크기</param>
        /// <returns>읽고 쓰기가 가능한(List) 페이징 처리된 레코드 셋</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Category> Paging(int page, int pageSize)
        {
            return 
                _categories.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Category> Read()
        {
            return _categories;
        }

        public List<Category> Search(string query)
        {
            return _categories.Where(c => c.CategoryName.Contains(query)).ToList();
        }
    }
}
