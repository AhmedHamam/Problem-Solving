namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            // System.Console.WriteLine(is_same("Anas", "anas"));
            System.Console.WriteLine(deleteLastChar("Ahmed"));
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
    }



}

