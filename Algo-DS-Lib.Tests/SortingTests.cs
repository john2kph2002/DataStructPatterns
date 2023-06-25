using System;
using NUnit.Framework;
using DataStruct;
using DataStruct.SortAlgorithm;

namespace Algo_DS_Lib.Tests
{
    [TestFixture]
    public class SortingTests
    {
        private int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1};
            samples[1] = new[] { 2, 1};
            samples[2] = new[] { 2, 1, 2};
            samples[3] = new[] { 2, 1, 2, 5};
            samples[4] = new[] { 2, 1, 2, 5};
            samples[5] = new[] { 2, 1, 2, 5, 3};
            samples[6] = new[] { 2, 1, 2, 6, 3};
            samples[7] = new[] { 2, 1, 2, 5, 6};
            samples[8] = new[] { 2, 1, 2, 5, 3, 8, 9, 7};

            return samples;
        }
        private void RunTestsForSortAlgorithm(Action<int[]> sort)
        {
            foreach(var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("---TRACE---\n");
            foreach (var el in array)
            {
                TestContext.Write(el + " ");
            }
            TestContext.WriteLine("\n---------\n");
        }

        [Test]
        public void BubbleSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(BubbleSort.bubble);
        }
        [Test]
        public void SelectionSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(SelectionSort.selection);
        }
        [Test]
        public void InsertionSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(InsertionSort.insertion);
        }
        [Test]
        public void ShellSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(ShellSort.shell);
        }
        [Test]
        public void MergeSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(MergeSort.mergeSortRec);
        }
        [Test]
        public void QuickSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(QuickSort.quickRec);
        }
    }
}
