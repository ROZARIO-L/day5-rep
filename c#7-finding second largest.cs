using System;
   public class Program
    {
        public static void Main()
        {
			Console.WriteLine("enter the size of array");
			int x =Convert.ToInt32(Console.ReadLine());
         	int [] arr = new int[x];
			Console.WriteLine("enter array elements");
			for(int i=0; i<arr.Length;i++)
			{
				arr[i]=Convert.ToInt32(Console.ReadLine());
			}
			Array.Sort(arr);
			Console.WriteLine("the second largest element is "+arr[(arr.Length-2)]);
           
        }
   }