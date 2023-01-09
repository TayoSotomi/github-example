// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//This is a comment
Console.WriteLine("I am active");

/* Author:
  Date:
 
 */
//x is being declared
int x;
// x is being initialized 
x = 10;
//combined
int y = 11;

// constant
const double TAXRATE = 0.06;
// you can not change a constatnt 

//Example

Console.WriteLine("Please enter a radius");
//string result = Console.ReadLine();
//double num = double.Parse(result);
double num = double.Parse(Console.ReadLine());
Console.WriteLine(num);
double area = num * num * Math.PI;
Console.WriteLine(area);

// Assignments Operators
int i;
i = 2;
Console.WriteLine(i);
i += 1;
Console.WriteLine(i);
i -= 1;
Console.WriteLine(i);
i *= 2;
Console.WriteLine(i);
i /= 2;
Console.WriteLine(i);
i %= 2;
Console.WriteLine(i);

//NULL
string myname = null;
Console.WriteLine(myname);
string friend = "Ben";

if(friend == "family")
{
    myname = "Olulana";
}

else if (friend == "Ben")
{
    myname = "Tee";

}
Console.WriteLine(myname);