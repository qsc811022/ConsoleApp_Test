using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <=10 ; i++)
            //{
            //    Console.WriteLine("i="+i);
            //}


            //int sum = 1 + 2 + 3 + 4 + 5;
            //string leading = "1~5 的總和等於 ";
            //string result = leading + sum;
            //Console.WriteLine(result);
            //string path = "d:\\mydocument\\file.txt"; // 加上逸出字元是正確寫法
            //string path2 = @"d:\mydocument\file.txt"; // 使用 @ 會更方便
            //Console.WriteLine(path);
            //Console.WriteLine(path2);


            //Console.WriteLine("<select>");
            //        Console.WriteLine("<option value=\"1\">台北</option>");

            //string originalValue = "  abc def  ";
            //string trimLeft = originalValue.TrimStart();  //"abc def  "
            //string trimRight = originalValue.TrimEnd(); // "  abc def"
            //string trimResult = originalValue.Trim(); // "abc def"

            //Console.WriteLine(trimLeft);
            //Console.WriteLine(trimRight);
            //Console.WriteLine(trimResult);



            //20230701
            //string rocDate = "890125";
            //string westernDate = ConvertToWesternDate(rocDate);
            //Console.WriteLine(westernDate);  // Outputs: 2000/01/25
            //20230701

            //int[] numbers = new int[4]; // 陣列長度為4
            //                            // 事後填值到陣列裡
            //numbers[0] = 50;
            //numbers[1] = 75;
            //numbers[2] = 68;
            //numbers[3] = 100;

            //numbers[2] = -1; // 事後可以重覆修改值

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //20230701




        }
        public static string ConvertToWesternDate(string rocDateString)
        {
            if (string.IsNullOrEmpty(rocDateString) || rocDateString.Length != 6)
            {
                throw new ArgumentException("rocDateString must be in the format YYMMDD.");
            }

            // Parse year, month, and day from the input string.
            int year = int.Parse(rocDateString.Substring(0, 2)) + 1911;
            int month = int.Parse(rocDateString.Substring(2, 2));
            int day = int.Parse(rocDateString.Substring(4, 2));

            // Construct a DateTime object.
            DateTime date = new DateTime(year, month, day);

            // Convert to string in the desired format.
            string westernDateString = date.ToString("yyyy/MM/dd");

            return westernDateString;
        }
    }
}
