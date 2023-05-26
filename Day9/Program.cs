// TimeSpan ts1 = new TimeSpan(2, 30, 0);
// TimeSpan ts2 = TimeSpan.FromHours(1);

// // Add the two TimeSpan instances together
// TimeSpan ts3 = ts1.Add(ts2);

// // Calculate the total number of hours represented by the TimeSpan
// double totalHours = ts3.TotalHours;
// double hoursOnly = ts3.Hours;
// // Print the result to the console
// Console.WriteLine(totalHours);  // Output: 3.5
// Console.WriteLine(hoursOnly);  // Output: 3

// // Set the value of a DateTime variable
// DateTime dt1 = new DateTime(2022, 1, 1);       // 2022-01-01 00:00:00
// DateTime dt2 = new DateTime(2022, 1, 1, 12, 0, 0);  // 2022-01-01 12:00:00
// DateTime dt3 = new DateTime(2022, 1, 1, 12, 0, 0, 500);  // 2022-01-01 12:00:00.500

// // Set the value of a DateTimeOffset variable
// DateTimeOffset dto1 = new DateTimeOffset(2022, 1, 1, 12, 0, 0, TimeSpan.FromHours(1));  // 2022-01-01 12:00:00 +01:00
// DateTimeOffset dto2 = new DateTimeOffset(2022, 1, 1, 12, 0, 0, 500, TimeSpan.FromHours(1));  // 2022-01-01 12:00:00.500 +01:00

// DateTime now = DateTime.Now;
// Console.WriteLine(now);         // Output: 2022-01-01 12:00:00
// DateTime yesterday = now.AddDays(-1);
// Console.WriteLine(yesterday);  // Output: 2021-12-31 12:00:00

// DateTime tomorrow = now.AddDays(1);
// Console.WriteLine(tomorrow);   // Output: 2022-01-02 12:00:00


// DateTime dt = new DateTime(2022, 1, 1, 12, 0, 0);
// DateTimeOffset dto = new DateTimeOffset(2022, 1, 1, 12, 0, 0, TimeSpan.FromHours(1));

// // Format the DateTime value as a short date and time
// string str1 = dt.ToString("d");  // Output: 01/01/2022
// string str2 = dt.ToString("T");  // Output: 12:00:00

// // Format the DateTimeOffset value as a long date and time
// string str3 = dto.ToString("D");  // Output: Saturday, January 01, 2022
// string str4 = dto.ToString("F");  // Output: Saturday, January 01, 2022 12:00:00 PM +01:00


// string str5 = "01/01/2022";
// string str6 = "12:00:00 PM";
// string str7 = "01/01/2022 12:00:00 PM +01:00";

// // Parse the DateTime value using the "MM/dd/yyyy" format
// DateTime dt = DateTime.ParseExact(str1, "MM/dd/yyyy", CultureInfo.InvariantCulture);
// Console.WriteLine(dt);  // Output: 2022-01-01 00:00:00

// // Parse the DateTime value using the "hh:mm:ss tt" format
// dt = DateTime.ParseExact(str2, "hh:mm:ss tt", CultureInfo.InvariantC);

namespace Day9;

using System;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        int k = int.Parse(Console.ReadLine());
        
        for (int j = 0; j < k; j++)
        
        {
            Console.WriteLine(rnd.Next(1, 10));
            if (rnd == int 2)
            {
                Console.WriteLine("Beruntung");
            }
        
        

        }
    }

}
