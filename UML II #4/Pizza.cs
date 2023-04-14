namespace UML2
{
    public class Pizza
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Number: {Id}, Name: {Name}, Price: {Price}";
        }
    }
}