using System;
public class DoB
    {
      public static void Main()
        {
            System.DateTime dob = new System.DateTime(1998,10,07);
            System.DateTime cdt = System.DateTime.Now;
            int Day = cdt.Day - dob.Day;
            int Month = cdt.Month - dob.Month;
            int Year = cdt.Year - dob.Year;
            Console.WriteLine(String.Format("Age: " + Year + " Year(s) " + Month + " Month(s) " + Day + " Day(s) "));
        }
}