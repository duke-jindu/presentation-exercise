//1. Write an expression that checks whether an integer is odd or even.//


//passing a intruction message to the console//

Console.WriteLine("Please enter a number");

//passing a console readline//
int figure = int.Parse(Console.ReadLine());

//using if else//
if (figure % 2 == 0)
{
    Console.WriteLine("{0} is an even number", figure);
}
else
{
    Console.WriteLine("{0} is an ODD number", figure);
}
//bool even = figure % 2 == 0 ? true : false;//
