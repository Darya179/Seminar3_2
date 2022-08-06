Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());

double Dist(int x1Loc, int y1Loc, int z1Loc, int x2Loc, int y2Loc, int z2Loc ){

    double dis = Math.Sqrt(Math.Pow((x2Loc - x1Loc) ,2) + Math.Pow((y2Loc - y1Loc),2 ) + Math.Pow((z2Loc - z1Loc),2 ));
    return dis;

}

Console.WriteLine(Dist(x1, y1, z1, x2, y2, z2));