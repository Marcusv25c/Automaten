using Automaten.Repo;
using Automaten.Service;

namespace Automaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Automaten!");



            Admin();
        }

        static void Admin()
        {
            string choice = Console.ReadLine();
            while (true)
            {
                switch (choice)
                {
                    case "1":
                        {
                            Product();
                            break;
                        }
                    case "9":
                        {
                            Main(null);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("prøv igen");
                            Admin();
                            break;
                        }
                }
            }
        }

        static void Product()
        {
            IProductRepo iProductRepo = new ProductRepo();

            ProductService productService = new ProductService(iProductRepo);


            Console.Write("Navn: ");
            string name = Console.ReadLine();
            Console.Write("Pris: ");
            int price = Int32.Parse(Console.ReadLine());

            productService.Create(name, price);

            Console.ReadLine();
        }
    }
}
