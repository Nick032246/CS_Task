namespace Project_22_02;
class Task2{

public  void Fibo(){

Console.WriteLine("Enter Number");
int n=Convert.ToInt32(Console.ReadLine());

int a=0;
int b=1;
int c;
for(int i=0; i<=n;i++){
c=a+b;
a=b;
b=c;
Console.Write(c);

}
Console.ReadLine();
}


}