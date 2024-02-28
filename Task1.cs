namespace Project_22_02;
class Task1{

public  void Sum(){



 Console.Write("Enter Number :");
 int a=Convert.ToInt32(Console.ReadLine());
int S=0;

while(a>0){

int r=a %10;
S=S+r;
a=a/10;

}
Console.WriteLine("Sum Of Digit :"+S);
}


}