using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class Model
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime created { get; set; }
    }
}
