namespace SortingAlgoRithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 3, 9, 7 };
            MergeSort.Sort(arr);

            foreach (var item in arr) Console.Write(item + ", ");
            Console.WriteLine();
        }
    }
}
