using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public class SortingExample
  {
      public static void ExecuteBubbleSort()
      {
          int[] input = { 5, 2, 18, 1, 44, 3, 4, 7 };
          Console.WriteLine("Before Sort");
          foreach (int i in input)
          {
              Console.WriteLine(i);
          }
          Sorting.BubbleSort<int>(input);
          Console.WriteLine("After Sort");
          foreach (int i in input)
          {
              Console.WriteLine(i);
          }
      }

      public static void ExecuteSelectionSort()
      {
          int[] input = { 5, 2, 18, 1, 44, 3, 4, 7 };
          Console.WriteLine("Before Sort");
          foreach (int i in input)
          {
              Console.WriteLine(i);
          }
          Sorting.SelectionSort<int>(input);
          Console.WriteLine("After Sort");
          foreach (int i in input)
          {
              Console.WriteLine(i);
          }
      }

      public static void ExecuteInsertionSort()
      {
          int[] input = { 5, 2, 18, 1, 44, 3, 4, 7 };
          Console.WriteLine("Before Sort");
          foreach (int i in input)
          {
              Console.WriteLine(i);
          }
          Sorting.InsertionSort<int>(input);
          Console.WriteLine("After Sort");
          foreach (int i in input)
          {
              Console.WriteLine(i);
          }
      }

      public static void ExecuteMergeSort()
      {
          List<string> input = new List<string>() { "serkan", "sendur", "john", "frusciante", "is", "cool" };
          input = Sorting.MergeSort<string>(input);
          foreach (string s in input)
          {
              Console.WriteLine(s);
          }
      }
  }

