using System;

namespace firstoneee
{
    class Program
    {
        static void Main(string[] args)
        {

            Notebook notebook1 = new Notebook()
            {
                Name = "PC",
                Brand = "Lenovo",
                Price = 250,
            };

            Console.WriteLine(notebook1.Name);
            Console.WriteLine(notebook1.Brand);
            Console.WriteLine(notebook1.Price);







        }
    }
}
