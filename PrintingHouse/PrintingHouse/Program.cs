using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace PrintingHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Books> books = new List<Books>();
            int n = int.Parse(Console.ReadLine());
            StreamWriter booksWriter = new("PrintingHouse.txt");
            using (booksWriter) 
            {
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        var danni = Console.ReadLine().Split();
                        Books book = new Books(danni[0], danni[1], int.Parse(danni[2]), int.Parse(danni[3]), double.Parse(danni[4]), int.Parse(danni[5]), int.Parse(danni[6]));
                        books.Add(book);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }

                SortingByCirculation sortingByCirculation = new SortingByCirculation();
                books.Sort(sortingByCirculation);
                books.ForEach(book => book.Print());

                string booktitle = Console.ReadLine();

                if (books.Select(x => x.Title).Contains(booktitle))
                {
                    Console.WriteLine("Има книга с такова име");
                }
                else
                {
                    Console.WriteLine("Няма книга с такова име");
                }

                Console.WriteLine($"Average Circulation : {CalculateAverageCirculation(books)}");

                //var newestBook = books.Select(x => x.NomenclatNum).OrderByDescending(x => x).ToList();
                //Console.WriteLine(newestBook);
            }
        }
               
        static double CalculateAverageCirculation(List<Books> avrgcirculation)
        {
            double result = avrgcirculation.Average(ac => ac.Circulation);
            return result;
        }

    }
}
