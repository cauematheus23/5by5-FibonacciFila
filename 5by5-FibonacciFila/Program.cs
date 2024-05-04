using _5by5_FibonacciFila;

double n1 = -1, n2 = 1, aux, quant = 0;
QueueFibonacci queue = new();
do
{
    Console.WriteLine("type the number of values you want: ");
    quant = int.Parse(Console.ReadLine());
} while (quant <= 0);
for (int i = 0; i < quant; i++)
{
    aux = n1 + n2;
    queue.Push(new(aux));
    n1 = n2;
    n2 = aux;

}
Console.WriteLine("===== STACK FIBONACCI =====");
queue.Print();

