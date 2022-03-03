namespace Net021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog myCatalog = new Catalog();
            Book bookOne = myCatalog["123-1-12-12345-1"];
        }
    }
}
