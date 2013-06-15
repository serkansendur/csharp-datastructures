using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Sorting
   {
       public static void BubbleSort<T>(T[] input) where T : IComparable<T>
       {
           for (int x = 0; x < input.Length; x++)
           {
               for (int y = 0; y < input.Length - 1; y++)
               {
                   if (input[y].CompareTo(input[y + 1]) > 0)
                   {
                       T temp = input[y + 1];
                       input[y + 1] = input[y];
                       input[y] = temp;
                   }
               }
           }
       }

       public static void SelectionSort<T>(T[] input) where T : IComparable<T>
       {
           for (int x = 0; x < input.Length; x++)
           {
               int index_of_min = x;

               for (int y = x; y < input.Length; y++)
               {
                   if (input[index_of_min].CompareTo(input[y]) > 0)
                   {
                       index_of_min = y;
                      
                   }
               }

               T temp = input[x];
               input[x] = input[index_of_min];
               input[index_of_min] = temp;
           }
       }

       public static void InsertionSort<T>(T[] array) where T : IComparable<T>
       {
           int i, j;

           for (i = 1; i < array.Length; i++)
           {
               T value = array[i];
               j = i - 1;
               while ((j >= 0) && (array[j].CompareTo(value) > 0))
               {
                   array[j + 1] = array[j];
                   j--;
               }
               array[j + 1] = value;
           }
       }

       public static List<T> MergeSort<T>(List<T> list) where T : IComparable<T>
       {
           if (list.Count == 1)
           {
               return list;
           }

           List<T> sorted = new List<T>();
           int middle = (int)list.Count / 2;
           List<T> left = list.GetRange(0, middle);
           List<T> right = list.GetRange(middle, list.Count - middle);
           left = MergeSort(left);
           right = MergeSort(right);
           int leftptr = 0;
           int rightptr = 0;
           for (int i = 0; i < left.Count + right.Count; i++)
           {
               if (leftptr == left.Count)
               {
                   sorted.Add(right[rightptr]);
                   rightptr++;
               }
               else if (rightptr == right.Count)
               {
                   sorted.Add(left[leftptr]);
                   leftptr++;
               }
               else if (left[leftptr].CompareTo(right[rightptr]) < 0)
               {
                   sorted.Add(left[leftptr]);
                   leftptr++;
               }
               else
               {
                   sorted.Add(right[rightptr]);
                   rightptr++;
               }

           }
           return sorted;
       }
   }

