class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tip = meal_cost / 100 * tip_percent;
        double tax = meal_cost * tax_percent / 100;
        double total_coast = meal_cost + tip + tax;
        double total = Math.Round(total_coast);
        Console.WriteLine(tip);
        Console.WriteLine(tax);
        Console.WriteLine(total_coast);

        Console.WriteLine(total);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine()!.Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine()!.Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine()!.Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}
