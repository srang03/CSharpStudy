using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    /// <summary>
    ///  모델 클래스(뷰모델 클래스) => 일반적으로 데이터가 저장되는 그릇 구조
    /// </summary>
    public class Category
    {
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
    }
}
