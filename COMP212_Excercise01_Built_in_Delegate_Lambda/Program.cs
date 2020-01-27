using System;
/*
 * TASKS:
 * Create a C# app in which you are required to create the following methods using built-in delegates
 * predicates and lambdas.
 * 1- string Minimum(string1,string2,string3) which returns the smallest of three string values. To test
 * this method, you need to use built-in Func<> delegate predicate
 * 2- void AvgGrade(value1, value2, value3)which displays the average of three grades. To test this method,
 * you need to use built-in Action<> delegate predicate
 * 
 * Here will use lambda--anonymous methods to complete this excercise which is already on my github
 * Repository name is COMP212_Built_in_Delegate
 */

namespace COMP212_Excercise01_Built_in_Delegate_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string, string> smallestOfAll = (small, smallest, smallers) =>
            {
                if (small.Length > smallest.Length)
                {
                    return smallest;
                }
                else if (small.Length > smallers.Length)
                {
                    return smallers;
                }
                else
                {
                    return small;
                }
            };
            string result = smallestOfAll.Invoke("small", "smallest", "smallers");
            Console.WriteLine(result);

            //the output will be 88
        //    Action<int, int, int> AvgGrades = AvgGrade;
        //    AvgGrades.Invoke(79, 90, 95);
        }
    }
}
