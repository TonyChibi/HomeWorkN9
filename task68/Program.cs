int Ackermann(int m=2, int n=3){
    if(m==0)return n+1;
    if (n==0)return Ackermann(m-1,1);
    return Ackermann(m-1,Ackermann(m,n-1));
   
}



Console.Clear();
Console.WriteLine("insert two integers: ");
int [] nums=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
Console.WriteLine(Ackermann(nums[0],nums[1]));