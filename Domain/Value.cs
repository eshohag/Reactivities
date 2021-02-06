using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Values")]
    public class Value
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
    }
}
