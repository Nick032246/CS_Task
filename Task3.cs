namespace Project_22_02;
class Task3{

public void Prime(){


Console.WriteLine("Enter Number :");
int A=Convert.ToInt32(Console.ReadLine());
int Num=0;
for(int i=1; i<=A;i++){

if(A%i==0){

    Num++;
}

}
if(Num==2){
Console.WriteLine($"{A} Is A Prime Number");

}
else{
    Console.WriteLine($"{A} Is A Not Prime Number");

}
}

}