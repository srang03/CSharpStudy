using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Lib
{
    /// <summary>
    ///  모델 클래스
    /// </summary>
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public bool IsDone { get; set; }
    }
}
