using Demo.Data;
using System.Collections;
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
        }
    }
}
