namespace Project_22_02;
class Task6{

public void Pattern(){

Console.WriteLine("Enter Number :");
int n=Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter Width :");
int width=Convert.ToInt32(Console.ReadLine());


for(int i=width-1; i>=0 ; i--){

for(int j=0; j<=i; j++){

Console.WriteLine(n);

}
Console.WriteLine("");
}


}

}