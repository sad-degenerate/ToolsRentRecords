using System.Collections.Generic;

namespace Records.LIB.Model
{
    public class Table : IBaseItem
    {
        public int Id { get; set; }
        public IEnumerable<TableEntity> TableEntities;
    }
}