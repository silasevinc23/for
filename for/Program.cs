

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine();
Console.WriteLine("1 ile 20 arasındaki sayılar :");
for (int i = 1; i < 21; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine("1 ile 20 arasındaki çift sayılar :");
for (int i = 1; i < 21; i++)
{
    if (i%2==0)
        Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı :");
int sum = 0;
for (int i = 50; i < 151; i++)
{
    sum += i;
}
Console.WriteLine(sum);



int sum_cift = 0;
int sum_tek = 0;
for (int i = 1; i < 121; i++)
{
    if (i % 2 == 0)
        sum_cift += i;
    else
        sum_tek += i;


}
Console.WriteLine();
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı :");
Console.WriteLine(sum_cift);

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı :");
Console.WriteLine(sum_tek);