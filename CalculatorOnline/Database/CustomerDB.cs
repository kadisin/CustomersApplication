using System.ComponentModel.DataAnnotations;

namespace CalculatorOnline.Database
{
    public class CustomerDB
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Price { get; set; }
    }
}
