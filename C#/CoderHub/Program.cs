namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            // System.Console.WriteLine(is_same("Anas", "anas"));
            // System.Console.WriteLine(deleteLastChar("Ahmed"));
            string str = Console.ReadLine()!;

            int num = int.Parse(str);
            System.Console.WriteLine(sum_of_even_and_odd_digits(num));
        }

        // Write a function that receives two text values of type string,  if the two input values contain numbers, 
        //  the function add the numbers and returns sum as a text value, 
        //  and if one of the inputs contains characters it returns -1 as the text value
        public static string is_Numbers(string str1, string str2)
        {
            int num1 = 0;
            int num2 = 0;
            bool isNum1 = int.TryParse(str1, out num1);
            bool isNum2 = int.TryParse(str2, out num2);
            if (isNum1 && isNum2)
            {
                return (num1 + num2).ToString();
            }
            else
            {
                return "-1";
            }
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

