namespace Demo
{
    internal class Program
    {
        //public var Fun( var value)
        //{

        //}
        //public dynamic Fun2(dynamic value)
        //{
        //    return null;
        //}
        static void Main(string[] args)
        {
            #region Implicitly-type Local Variable
            // Implicitly-type Local Variable
            // [var - dynamic]

            // var
            //var data01; //Invalid
            //var data01 = "Abdo";
            // Compiler Can Detect The DataType Of Local Variale Based On Initial Value, At Compilationtime
            // Must Be Initialized
            // Can't Initialize The Local Variable With null
            // Can't Change The Datatype Of The Local Variable After Inintialization
            // Can't Use Var As Parameter Or Return Type

            //data01 = 12; // Invalid


            // dynamic
            //dynamic data02;
            //data02 = "Abdo";
            //Console.WriteLine(data02.GetType().Name);

            // CLR Will Detect The DataType Of Local Variale Based On Last Value, At Runtime
            // Don't Need To Be Initialized
            // Can Initialize The Local Variable With null
            // Can Change The Datatype Of The Local Variable After Inintialization
            // Can Use Var As Parameter Or Return Type

            //data02 = 12;
            //Console.WriteLine(data02.GetType().Name);

            //data02 = 1.2;
            //Console.WriteLine(data02.GetType().Name);

            //data02 = 1.2f;
            //Console.WriteLine(data02.GetType().Name);

            //data02 = 1.2m;
            //Console.WriteLine(data02.GetType().Name);

            //data02 = true;
            //Console.WriteLine(data02.GetType().Name);

            //data02 = null;
            ////Console.WriteLine(data02.GetType().Name);

            #endregion

            #region Anonymous Type
            // Anonymous Type

            //var employee01 = new { Id = 1,Name = "Abdelrahman", Salary = 12000.0 };
            //var employee02 = new { Id = 1,Name = "Abdelrahman", Salary = 12000.0 };
            ////var employee02 = new { Id = 2,Name = "Omar", Salary = 13000.0 };

            //Console.WriteLine(employee01); // Compiler Will Override ToString
            ////employee.Id = 2; // Invalid
            //// Immutable Type -> can't change It's Value After Creation

            //Console.WriteLine(employee01.GetType().Name);// <>f__AnonymousType0`3
            //Console.WriteLine(employee02.GetType().Name);// <>f__AnonymousType0`3

            //// The Same Anonymous Type as Long as:
            ////  1. Same Property Name
            ////  2. Same Property Order

            //Console.WriteLine(employee01.GetHashCode());
            //Console.WriteLine(employee02.GetHashCode());

            //if(employee01.Equals(employee02)) // Compiler Will Override Equals
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("Not Equals"); 
            #endregion

            #region Extension Method
            //// Extension Method

            //int num = 12345;

            ////int reversed = IntExtension.Reverse(num);
            ////Console.WriteLine(reversed);

            //num.Reverse();
            //Console.WriteLine(num.Reverse());
            //Console.WriteLine(IntExtension.Reverse(num)); 
            #endregion

            #region LINQ

            // LINQ : Language Integrated Query
            //      : 40+ Extension Methods (LINQ Operators) Against Any Sequance
            //      : Regardless Data Store
            //      : 13 Categories

            // Sequance : Object From Calss That Impleminting IEnumrable Interface
            // Local Sequance  : L2O , L2XML , L2ADO 
            // Remote Sequance : L2SQL , L2EF

            // Input Sequance -> LINQ Operator -> Output Sequance
            // Input Sequance -> LINQ Operator -> Single Value
            //                -> LINQ Operator -> Output Sequance

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////var even1 = Enumerable.Where(list, x => x % 2 == 0).ToList();
            //var even = list.Where(x => x % 2 == 0).ToList();

            //bool flag = list.Any(x => x > 50);

            //List<int> numbers = Enumerable.Range(0, 100).ToList();

            //foreach(var item in even)
            //{
            //    Console.Write($"{item} ");
            //}


            // LINQ Syntax
            // 1. Fluent Syntax
            // Using LINQ Methods
            //  1.1. LINQ Operators as Class Member Method -> Enumrable
            //  1.2. LINQ Operators as Extension Method


            // 2. Query Syntax [Query Expre]
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = from n in list
            //             where n % 2 == 0
            //             select n;
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}


            // LINQ Extension Ways
            // 1. Differed Execution Way  : 10 category
            // 2. Immidiate Execution Way : 3 category [Element Operator, Casting Operator, Aggregate Operator]


            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = list.Where(x => x % 2 == 0); // Differed
            //list.AddRange(new int[] { 11, 12, 13, 14 });
            //foreach(var item in result)
            //{
            //    Console.Write($"{item} ");
            //}


            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = list.Where(x => x % 2 == 0).ToList(); // Immidiate
            //list.AddRange(new int[] { 11, 12, 13, 14 });
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(ListGenerator.ProductList[1]);
        }
    }
}
