namespace GitFlowRoot.Backend.Models
{
    public class Shoppingcart
    {
        public int Id { get; set; }
        public Person Customer { get; set; }
        public List<Product> Products { get; set; }
        // Add more properties as needed

        // Methods of the Shoppingcart class go here
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // Add more properties as needed

        // Methods of the Product class go here
    }
}