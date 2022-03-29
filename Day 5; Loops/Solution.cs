class Solution
{
    public static void carpim_tablosu (int carpilan)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(carpilan + " x " + i + " = " + (carpilan*i));
        }
    }
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        carpim_tablosu(n);
    }
}