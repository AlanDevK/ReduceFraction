Console.WriteLine("Type in your fraction: ");
string[] fraction = Console.ReadLine().Split("/");
int n = int.Parse(fraction[0]);
int m = int.Parse(fraction[1]);
int temp = gcd(n, m);
if (temp == 1)
{
    Console.WriteLine($"{fraction[0]}/{fraction[1]}");
}
else
{
    while (temp > 1)
    {
        n = n / temp;
        m = m / temp;
        if (n % temp != 0 || m % temp != 0)
        {
            break;
        }
    }
    Console.WriteLine($"Final fraction: {n}/{m}");
}

int gcd(int a, int b)
{
    if (b == 0)
    {
        return a;
    }
    return gcd(b, a % b);
}