using System.ComponentModel.DataAnnotations;

namespace JWT_Token_Authentication.ModelDemo
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double Price { get; set; }

    }
}
