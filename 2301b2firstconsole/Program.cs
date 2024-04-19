// See https://aka.ms/new-console-template for more information



//Console.WriteLine("Hello, Haris!");

//DATATYPES
/*
int age = 16;
float percentage = 99.6F;
decimal points = 88.77M;
long daysLived = 64237423676384L;
char favLetter = 'H';
string fullname = "Haris Naseer";

Console.WriteLine("Enter Your Name...?");
string name = Console.ReadLine();


Console.WriteLine("Hello ,"+ name );*/
/*
int x = 5, y = 12;
Arithmetice operators
Console.WriteLine(x + y);
Console.WriteLine(x - y);
Console.WriteLine(x * y);
Console.WriteLine(x / y);
Console.WriteLine(x % y);*/

//Post Increment BAAD Me
// x++;x +1;
//Console.WriteLine(x++);
//Console.WriteLine(x);

//Pre Increment PEHLE
//Console.WriteLine(++x);

//Post Decrement BAAD Me
// x--;x  - 1;
//Console.WriteLine(x--);
//Console.WriteLine(x);

//Pre Decrement PEHLE
//Console.WriteLine(--x);
/*
//Assignment Operators
x += 5; //x = x + 5
Console.WriteLine(x);
x -= 5; //x = x - 5
Console.WriteLine(x);
x *= 5; //x = x * 5
Console.WriteLine(x);
x /= 5; //x = x / 5
Console.WriteLine(x);

//comparison operators

//Console.WriteLine(x == y);
//Console.WriteLine(x != y);

Console.WriteLine(x < y);//True
Console.WriteLine(x > y);// False
Console.WriteLine(x <= y);//True 
Console.WriteLine(x >= y);//False

//Logical Operators
//And
Console.WriteLine(x == y && x <= y);//False
//OR
Console.WriteLine(x == y || x <= y);//true
//NOT
Console.WriteLine(!(x == y) && x <= y);//true

//Conditional Statements

Console.WriteLine("Welcome to DLS");
Console.WriteLine("Please enter your age:");

int age = Int32.Parse(Console.ReadLine());
// IF ELSE Ladder
if (age >18 && age <=60)
{
    Console.WriteLine("You 're Eligible for Driving.");
}
else if (age == 18)
{
    //Nested If Else Ladder
    Console.WriteLine("Have you got your Liscense yet..? Press Y for yes and N for No");
    char status = char.Parse(Console.ReadLine());
    if (status == 'Y' || status == 'y')
    {
        Console.WriteLine("You 're Eligible for Driving.");
    }else if (status == 'N' || status == 'n')
    {
        Console.WriteLine("You 're Not Eligible for Driving. Please get your Liscense first.");
    }
    else
    {
        Console.WriteLine("Please Press Y or N.");
    }
}
else
{
    Console.WriteLine("Sorry, You 're not Eligible for Driving.");
}

// Switch Statement
Console.WriteLine("Please Enter Values for Days between 1 to 7.");
int day = Int32.Parse(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Today is Monday");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday");
        break;
    case 4:
        Console.WriteLine("Today is Thursday");
        break;
    case 5:
        Console.WriteLine("Today is Friday");
        break;
    case 6:
        Console.WriteLine("Today is Saturday");
        break;
    case 7:
        Console.WriteLine("Today is Sunday");
        break;
    default:
        Console.WriteLine("Please Enter Values between 1 to 7.");
        break;


}



//loops

//for with break and continue(jump statements)

for (int i = 1; i <= 100; i++)
{
    if (i == 10)
    {
        continue;//skip the given condition and continue
    }
    Console.WriteLine(i);
}

for (int i=100; i>=1; i--)
{
    if (i == 49)
    {
        break;// stop the loop if condition is true.
    }
    Console.WriteLine(i);
}



//while
int j = 0;

while( j <= 10 ){
    Console.WriteLine(j);
    j++;
}
*/
//do while

char choice;
do
{
    Console.WriteLine("Hi");
    Console.WriteLine("Press Y to play or any key to Exit");
      choice = Char.Parse(Console.ReadLine());

}
while (choice =='Y' || choice=='y');
