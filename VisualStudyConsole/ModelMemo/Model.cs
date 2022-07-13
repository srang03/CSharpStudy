using System;

namespace ModelMemo
{
    public class Model
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime created { get; set; }
    }
}
