using Assignment.Dat;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using static Assignment.Data.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators
            /*
            // 1. Get the total units in stock for each product category.
            var Result = ProductsList.GroupBy(P => P.Category).Select(G => new
            {
                Category = G.Key,
                TotalUnitsInStock = G.Sum(P => P.UnitsInStock)
            });

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 2. Get the cheapest price among each category's products
            var result = ProductsList
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    CheapestPrice = g.Min(p => p.UnitPrice)
                });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 3. Get the products with the cheapest price in each category (Use Let)
            var Result = from P in ProductsList
                         group P by P.Category into G
                         let cheapestPrice = G.Min(P => P.UnitPrice)
                         from prod in G
                         where prod.UnitPrice == cheapestPrice
                         select new
                         {
                             Category = G.Key,
                             ProductName = prod.ProductName,
                             Price = prod.UnitPrice
                         };

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 4. Get the most expensive price among each category's products.
            var result = from P in ProductsList
                         group P by P.Category into G
                         select new
                         {
                             Category = G.Key,
                             MostExpensivePrice = G.Max(P => P.UnitPrice)
                         };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 5. Get the products with the most expensive price in each category.
            var result = from p in ProductsList
                         group p by p.Category into g
                         let mostExpensivePrice = g.Max(p => p.UnitPrice)
                         from prod in g
                         where prod.UnitPrice == mostExpensivePrice
                         select new
                         {
                             Category = g.Key,
                             ProductName = prod.ProductName,
                             Price = prod.UnitPrice
                         };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 6. Get the average price of each category's products.
            var result = from p in ProductsList
                         group p by p.Category into g
                         select new
                         {
                             Category = g.Key,
                             AveragePrice = g.Average(p => p.UnitPrice)
                         };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */


            #endregion

            #region LINQ - Set Operators

            /*
            // 1. Find the unique Category names from Product List
            var result = ProductsList.Select(p => p.Category).Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 2. Produce a Sequence containing the unique first letter from both product and customer names.
            var result = ProductsList
                         .Select(p => p.ProductName[0])
                         .Union(CustomersList.Select(c => c.CustomerName[0]))
                         .Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 3. Create one sequence that contains the common first letter from both product and customer names.
            var result = ProductsList
                         .Select(p => p.ProductName[0])
                         .Intersect(CustomersList.Select(c => c.CustomerName[0]));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var result = ProductsList
                         .Select(p => p.ProductName[0])
                         .Except(CustomersList.Select(c => c.CustomerName[0]));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            var result = ProductsList
                         .Select(p => p.ProductName.Substring(p.ProductName.Length - 3))
                         .Concat(CustomersList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3)));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region LINQ - Partitioning Operators
            /*
            // 1. Get the first 3 orders from customers in Washington
            var result = CustomersList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Take(3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            there is no Washington in Cutomers Country
            */

            /*
            // 2. Get all but the first 2 orders from customers in Washington.
            var result = CustomersList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Skip(2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            there is no Washington in Cutomers Country
            */

            /*
            // 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.TakeWhile((num, index) => num >= index);

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
            */

            /*
            // 4.Get the elements of the array starting from the first element divisible by 3.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.SkipWhile(n => n % 3 != 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            /*
            // 5. Get the elements of the array starting from the first element less than its position.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.SkipWhile((num, index) => num >= index);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */


            #endregion

            #region LINQ - Quantifiers
            /*
            // 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            string[] words = File.ReadAllLines("dictionary_english.txt");
            bool result = words.Any(w => w.Contains("ei"));

            Console.WriteLine(result);
            */

            /*
            // 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var result = from p in ProductsList
                         group p by p.Category into g
                         where g.Any(p => p.UnitsInStock == 0)
                         select new
                         {
                             Category = g.Key,
                             Products = g.ToList()
                         };

            foreach (var group in result)
            {
                Console.WriteLine($"Category: {group.Category}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"             {product.ProductName} - Stock: {product.UnitsInStock}");
                }
            }
            */

            /*
            // 3. Return a grouped a list of products only for categories that have all of their products in stock.
            var result = from p in ProductsList
                         group p by p.Category into g
                         where g.All(p => p.UnitsInStock > 0)
                         select new
                         {
                             Category = g.Key,
                             Products = g.ToList()
                         };

            foreach (var group in result)
            {
                Console.WriteLine($"Category: {group.Category}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"             {product.ProductName} - Stock: {product.UnitsInStock}");
                }
            }
            */


            #endregion

            #region LINQ – Grouping Operators
            /*
            // 1. Use group by to partition a list of numbers by their remainder when divided by 5
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var result = numbers.GroupBy(n => n % 5);

            foreach (var group in result)
            {
                Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
                foreach (var num in group)
                {
                    Console.WriteLine(num);
                }
            }
            */

            /*
            // 2.Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            string[] words = File.ReadAllLines("dictionary_english.txt");
            var wordGroups = words.GroupBy(w => w[0]).OrderBy(g => g.Key);

            foreach (var group in wordGroups)
            {
                Console.WriteLine($"Letter '{group.Key}' → {group.Count()} words");
            }
            */

            /*
            // 3. Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            var result = Arr.GroupBy(word => new string(word.Trim().OrderBy(c => c).ToArray()));

            foreach (var group in result)
            {
                foreach (var word in group)
                {
                    Console.WriteLine(word.Trim());
                }
                Console.WriteLine("....");
            }
            */
            #endregion
        }
    }
}
