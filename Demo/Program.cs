using Demo.Data;
using System.Collections;
using System.Linq;
using static Demo.Data.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision

            #endregion

            #region Casting [Conversion] Operators - Immediate Execution
            //var Result = ProductsList.Where(P => P.UnitsInStock ==0).ToList();
            //Product[] Result = ProductsList.Where(P => P.UnitsInStock ==0).ToArray();
            //Dictionary<long, Product> Result = ProductsList.Where(P => P.UnitsInStock == 0)
            //.ToDictionary(P => P.ProductID);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            //HashSet<Product> Result = ProductsList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //ArrayList arrayList = new ArrayList()
            //{
            //    "Ahmed",
            //    "Mona",
            //    "Aya",
            //    1,
            //    2,
            //    3
            //};

            //var Result = arrayList.OfType<string>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Generation Operators - Deffered Execution
            //var Result = Enumerable.Range(0, 100);

            //Result = Enumerable.Repeat(2, 100);
            //var Result = Enumerable.Repeat(new Product(), 100);

            //var Result = Enumerable.Empty<Product>();

            //foreach (var item in Result)
            //{
            //Console.WriteLine(item);
            //}
            #endregion

            #region Set Operators [Union Family] - Deffered Execution
            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //foreach (var item in Seq01)
            //{
            //    Console.Write($"{item} - ");
            //}

            //Console.WriteLine();
            //foreach (var item in Seq01)
            //{
            //    Console.Write($"{item} - ");
            //}

            //var Seq03 = Seq01.Union(Seq02);
            //var Seq04 = Seq01.Concat(Seq02);
            //var Seq05 = Seq01.Distinct(Seq02);

            //foreach (var item in Seq05)
            //{
            //    Console.Write($"{item} - ");
            //}

            #endregion

            #region Quantifier Operator
            //var Result = ProductsList.Any();
            //var Result = ProductsList.Any(P => P.UnitsInStock == 0);

            //var Result = ProductsList.All();
            //Console.WriteLine(Result);
            #endregion

            #region Zipping Operator - ZIP
            //string[] Names = { "Ahmed", "Mona", "Aya", "Ali", "Mohamed" };
            //int[] Numbers = Enumerable.Range(1, 10).ToArray();
            //char[] chars = {'A', 'B', 'C', 'D', 'E'};


            ////var Result = Names.Zip(Numbers);
            //var Result = Names.Zip(Numbers, (Name, Number) => new { index = Number, Name = Name });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Grouping Operators
            //var Result = from P in ProductsList
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select Category;

            //foreach (var Cat in Result)
            //{
            //    foreach (var item in Cat)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Partitioning Operator
            //int[] Numbers = { 5, 4, 3, 2, 7, 8, 9 };

            //var Result = ProductsList.Take(10);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
