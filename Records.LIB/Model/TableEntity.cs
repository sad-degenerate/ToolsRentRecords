using System;

namespace Records.LIB.Model
{
    public class TableEntity : IBaseItem
    {
        public int Id { get; set; }
        public Tool Tool { get; set; }
        public DateTime DateTime { get; set; }
    }
}