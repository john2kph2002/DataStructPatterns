using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Algorithm_DataStruct_Lib;
using DataStruct.Pattern;
using DataStruct.SortAlgorithm;
using DataStruct.Statck;

namespace DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //var watch = new Stopwatch();
            //watch.Start();

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine($"Should print out 4:{stack.Peek()}");
            stack.Pop();
            Console.WriteLine($"Should print out 3:{stack.Peek()}");
            Console.WriteLine($"Iterate over the stack.");
            foreach (var cur in stack)
            {
                Console.WriteLine(cur);
            }

            //var ints = In.ReadInts("files\\1Kints.txt").ToArray();
            //var triplets = ThreeSum.Count(ints);
            //Console.WriteLine($"Number of triplets: {triplets} ms");

            //ReverseArrayNumber num = new ReverseArrayNumber();
            //num.print();

            //Array numbers = new Array(5);
            //numbers.print();

            //Palindrome palindrome = new Palindrome();
            //palindrome.print();

            //var list = new LinkList();
            //list.print();

            //Recursion recursion = new Recursion();
            //recursion.print();

            //Factorial fact = new Factorial();
            //fact.print();

            //LinearSearch linearSearch = new LinearSearch();
            //linearSearch.print();

            //BinarySearch binarySearch = new BinarySearch();
            //binarySearch.print();

            //SelectionSort selection = new SelectionSort();
            //selection.print();

            //InsertionSort insertion = new InsertionSort();
            //insertion.print();

            //BubbleSort bubble = new BubbleSort();
            //bubble.print();

            //ShellSort shell = new ShellSort();
            //shell.print();

            //MergeSort merge = new MergeSort();
            //merge.print();

            //QuickSort quick = new QuickSort();
            //quick.print();

            //ListDemo.run();

            //ConcatArray concat = new ConcatArray();
            //concat.print();

            //arrayString arrString = new arrayString();
            //arrayString.print();

            //PatternDescending patterndesc = new PatternDescending();
            //patterndesc.print();

            //Fibonacci fibonacci = new Fibonacci();
            //fibonacci.print();

            //SquareNumbersTotal square = new SquareNumbersTotal();
            //square.print();

            //StringSplitOut splitOut = new StringSplitOut();
            //splitOut.print();

            //ComputeJandK compute = new ComputeJandK();
            //compute.print();

            //ReverseAValue rev = new ReverseAValue();
            //rev.print();

            //Equilibrium equilibrium = new Equilibrium();
            //equilibrium.print();

            //DuplicateString duplicate = new DuplicateString();
            //duplicate.print();

            //RemoveDuplicateString remove = new RemoveDuplicateString();
            //remove.print();

            //watch.Stop();
            //Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");

            Console.Read();
        }

    }
}
