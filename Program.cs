// See https://aka.ms/new-console-template for more information
Console.WriteLine("We Welcome you in C#");

int num = 12;
System.Console.WriteLine($"*Table of {num}*");
for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{num}*{i}=\t {num * i}");
}
//1. add the code in program
//2. We have build and run it
//3. We have add all & commit the change
//4. We have push the code
//5. We will check the jenkins
System.Console.WriteLine("Printing Numbers from 1 to 500 divisible by 5");
for (int i = 1; i <=500; i++)
{
    if (i % 5 == 0)
    { System.Console.Write(i + "\t"); }
}
