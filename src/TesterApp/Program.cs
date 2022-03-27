﻿
using AlgTester.Core;

namespace TesterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passa a solution func
            //Baseado na solution func, pega um arquivo .txt na mesma pasta
            //Aceita override
            // Talvez troque para mandar classe + attribute + builder pattern (SolutionTester)

            /* var solutionFunc = SolutionFunc<int[], int, int>.Get(FindRepeatedElement.FindRepeatingElement_Naive); */
            /* SolutionTester.Test("src/TesterApp/Solutions/FindRepeatedNumber/FindRepeatedElement_TestCases.txt", solutionFunc); */

            var solutionFunc = FindRepeatedElement.FindRepeatingElement_Naive;
            SolutionTesterV2.New()
                .WithSolution(solutionFunc)
                /* .WithAutoTestFile() */
                .WithTestFile("src/TesterApp/Solutions/FindRepeatedNumber/FindRepeatedElement_Tests.txt")
                .WithTestCases(new TestCase[]
                {	
                    new TestCase
                    {	
                        Input = new object[] { new int[] { 1, 2, 3, 4, 4 }},
                        Output = new object[] { 3 }
                    }
                })
                .Run();
        }
    }
}
