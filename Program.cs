internal class Program
{
    
    private static void Main(string[] args)
    {
        double delta, x1, x2;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Giải phương trình bậc 2 dạng Ax2 + Bx + C = 0 !!!");
        Console.Write("Nhập a: ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập b: ");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập c: ");
        double c = Convert.ToInt32(Console.ReadLine());
        delta = b * b - 4 * a * c;
        if (a == 0)
            Giaiptbac1(b, c);
        else
        {
            if (delta == 0)
            {
                x1 = x2 = -b / 2 * a;
                Console.WriteLine("Phương trình có nghiệm kép: " + x1);
            }
            else if (delta < 0)
                Console.WriteLine("Phương trình vô nghiệm !!!");
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt x1 = {0} và x2 = {1}", x1, x2);
            }
        }
    }
    private void Giaiptbac1(double a, double b)
    {
        if (a == 0 && b == 0)
        {
            Console.WriteLine("Phương trình có vô số nghiệm ");
        }
        else if (a == 0 && b != 0)
        {
            Console.WriteLine("Phương trình vô nghiệm !!!");
        }
        else
        {
            Console.WriteLine("Phương trình có nghiệm x = " + -b / a);
        }
    }



}