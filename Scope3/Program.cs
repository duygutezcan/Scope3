// See https://aka.ms/new-console-template for more information

Basla();

void Basla()
{
    double x = 100;
    Console.WriteLine("x ilk değeri:" + x);
    x = Kokal(x);
    Console.WriteLine("x metot sonrası değeri:" + x);

}

double Kokal(double x)
{
    return Math.Sqrt(x);
}