namespace Part4
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"$Classname: {GetType().Name} | Name: {Name} | Email: {Email}";
        }
    }
}