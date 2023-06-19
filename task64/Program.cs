string BackCount(int n){
    if (n==1)return $"{n}";
    else return $"{n}, {BackCount(n-1)}";
}


Console.Write("Insert some integer: ");
int n=int.Parse(Console.ReadLine()!);
Console.WriteLine(BackCount(n));