namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            // System.Console.WriteLine(is_same("Anas", "anas"));
            // System.Console.WriteLine(deleteLastChar("Ahmed"));
            string str = Console.ReadLine()!;
            // System.Console.WriteLine(sum_of_even_and_odd_digits(num));
            System.Console.WriteLine(bin_to_oct(str));
        }

        //write function to convert binary to octal without convert to int or double
        public static int bin_to_oct(string b)
        {
            string octal = "";
            int i = b.Length - 1;
            while (i >= 2)
            {
                int sum = 0;
                int j = 0;
                while (j < 3)
                {
                    sum += (b[i] - '0') * (int)Math.Pow(2, j);
                    j++;
                    i--;
                }
                octal += sum;
            }
            int sum2 = 0;
            int j2 = 0;
            while (i >= 0)
            {
                sum2 += (b[i] - '0') * (int)Math.Pow(2, j2);
                j2++;
                i--;
            }
            octal += sum2;
            return int.Parse(new string(octal.Reverse().ToArray()).TrimStart('0'));
        }

        public static string date_format(string date)
        {
            // write your code here
            var date_format = Convert.ToDateTime(date);
            return date_format.ToString("yyyy/M/d") + " | " + date_format.ToString("yyyy-M-d") + " | " + date_format.ToString("M/d/yyyy");
        }
        public static string is_same(string name1, string name2)
        {
            // write your code here
            return name1 == name2 ? "متشابهتين" : "غير متشابهتين";
        }
        public static string deleteLastChar(string word)
        {
            // write your code here
            return word.Substring(0, word.Length - 1);

        }
        //count number of characters in a string
        public static int count(string word)
        {
            // write your code here
            return word.Length;
        }
        //logical_and
        public static bool logical_and(bool a, bool b)
        {
            // write your code here
            return a && b;
        }
        //convert hours to seconds 
        public static int convert_hours_to_seconds(int hours)
        {
            // write your code here
            return hours * 3600;
        }
        // sum of digits of integer number and check if the sum is even or odd and print the result
        public static string sum_of_digits(int number)
        {
            // write your code here
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum % 2 == 0 ? "even" : "odd";
        }
        // sum of even digits of integer number and sum of odd digits of integer number and
        // check if the sum of even and sum of odd equal or print odd or even 
        public static string sum_of_even_and_odd_digits(int number)
        {
            // write your code here
            int sum_even = 0;
            int sum_odd = 0;
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    sum_even += number % 10;
                }
                else
                {
                    sum_odd += number % 10;
                }
                number /= 10;
            }
            if (sum_even == sum_odd)
            {
                return "equal";
            }
            else if (sum_even > sum_odd)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
        // make function that take a string and retun boolean if the string is arathmatic operation or not using regix
        public static bool is_arathmatic_operation(string str)
        {
            // write your code here
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"^(\d+)(\+|\-|\*|\/)(\d+)$");
        }

    }



}

