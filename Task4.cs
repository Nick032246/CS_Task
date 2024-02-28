namespace Project_22_02;
class Task4{
    public void Palindrom(){

      Console.WriteLine("Enter Number :");
      int n=Convert.ToInt32(Console.ReadLine());

     int temp=n;
    int A=0;
    while(n>0){
      int r=n%10;
      A=(A*10)+r;
      n=n/10;
    }
    
    Console.WriteLine(A);
  if(temp==A){
 Console.WriteLine($"{temp} Is Palindrome Number");
  }
  else{
 Console.WriteLine($"{temp} Is not Palindrome Number");   
  }
 }
 }

