Console.WriteLine("Введите координаты белого коня от 1 до 8");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты черного коня от 1 до 8");
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты, куда пойдет белый конь");
int e = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Console.ReadLine());

if ((a + 1 == e && b + 2 == f) ||
    (a - 1 == e && b + 2 == f) ||
    (a + 1 == e && b - 2 == f) ||
    (a - 1 == e && b - 2 == f) ||
    (a + 2 == e && b + 1 == f) ||
    (a - 2 == e && b + 1 == f) ||
    (a + 2 == e && b - 1 == f) ||
    (a - 2 == e && b - 1 == f))
{
    if ((a + 1 == e && b + 2 == f) ||
    (c - 1 == e && d + 2 == f) ||
    (c + 1 == e && d - 2 == f) ||
    (c - 1 == e && d - 2 == f) ||
    (c + 2 == e && d + 1 == f) ||
    (c - 2 == e && d + 1 == f) ||
    (c + 2 == e && d - 1 == f) ||
    (c - 2 == e && d - 1 == f))
    {
        Console.WriteLine("Белый конь может сходить, но будет под ударом черного коня");
    }
    else
        Console.WriteLine("Белый конь может сходить туда, и не будет под ударом черного коня");
}
else
{
    Console.WriteLine("Белый конь туда не ходит за 1 ход");
}
