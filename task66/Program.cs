int Sum(int n,int m){
    if(m==n)return n;
    else return Sum(n,m-1)+m;
}

Console.Clear();
Console.Write("Insert two integers: ");
int [] nums=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int sum=Sum(nums[0],nums[1]);
Console.WriteLine(sum);