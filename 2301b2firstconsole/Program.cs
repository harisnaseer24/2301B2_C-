



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

//do while

char choice;
do
{
    Console.WriteLine("Hi");
    Console.WriteLine("Press Y to play or any key to Exit");
      choice = Char.Parse(Console.ReadLine());

}
while (choice =='Y' || choice=='y');


//Arrays 

int[] even = { 2,4,6,8,10 };//

//int[] odd = new int[5] ;{ 0,0,0,0,0 }
int[] odd = { 1,3,5,7,9 };

//printing an array using loops
//                i < 5
//int i; global scope
for(  int i = 0; i<odd.Length; i++)//local scope of i here
{
    Console.WriteLine(odd[i]);
}

//taking user  input in array
using System.Security.Cryptography;

string[] user = new string[5];

for (int j = 0; j < user.Length; j++)
{
    
    Console.WriteLine($"Please enter values for {j}th index");
    user[j] = Console.ReadLine();
}

Console.WriteLine("Your given array is: ");

for (int i = 0; i < user.Length; i++)//local scope of i here
{
    Console.WriteLine(user[i]);
}

//sort

//Multidimensional Arrays

int[,] marks = { 
    { 45, 75, 100 },
    { 45, 75, 89 },
    { 12, 56, 44} 
}; //3X3

//Nested Loops
for (int i = 0; i < marks.GetLength(0); i++)
{
    for (int j = 0; j < marks.GetLength(1); j++) 
    {
        Console.WriteLine(marks[i,j]);
    }
    Console.WriteLine();
}
Console.WriteLine(marks[1,2]);

//Mutable / Immutable
int[] nums = { 12, 15,1 };//{1,12,15}
Array.Sort(nums);// Changes the orignal array (Mutable)
Console.WriteLine(nums[0]);

int index = Array.BinarySearch(nums, 12);
Console.WriteLine(index);

int num = Array.Find(nums, x => x > 9);
Console.WriteLine(num);

int[] num2 = Array.FindAll(nums, x => x < 19);
Console.WriteLine(num2[0]);
Console.WriteLine(num2[1]);
Console.WriteLine(num2[2]);

Array.Reverse(nums);//{15, 12, 1}
Console.WriteLine(nums[0]);

Console.WriteLine(Array.IndexOf(nums ,12));
Console.WriteLine(Array.LastIndexOf(nums, 12));

string[] names = { "Haris", "Owais", "Ebad", "Afzal" };

//var is used for dynamic datatype selection
foreach (var item in names)
{
	Console.Write(" \"" + item +"\"");
	Console.Write(" \\" + item + "\"");
	//Console.WriteLine(item);
}

//Jagged Array : each sub array can have different size
string[][] skillSet =
{
    new string[2]{"php","sql"},
	 new string[4]{"node js","Mongodb", "nextjs","React"},
	  new string[2]{"Baatain", "HTML"},
};


//Console.WriteLine(skillSet[1][3]);

foreach (var item in skillSet)
{
    foreach (var item1 in item)
    {
        Console.Write(" " + item1 + " ");
    }
    Console.WriteLine();
}

//Placeholders

string fname = Console.ReadLine();// Haris
string mname = Console.ReadLine();// naseer
string lname = Console.ReadLine();// Ahmed

Console.WriteLine("Hello {2} ,{0} {1}",fname,mname,lname);


// Functions

//Pre Defined Functions 
//Math.Tan(90);

//User Defined Functions
//defining a function

// returnType functionName ( Params ){ code }
void add()
{
    Console.WriteLine(10 + 2);
}
//calling a function
add();
//1. No Return No Parameters

void Greet ()
{
    Console.WriteLine("Salam, Jumma Mubarak.");
    
}
Greet();

//2. Return with No Parameters

string Greet()
{
    return ("Salam, Jumma Mubarak from return function.");

}

string message = Greet();
Console.WriteLine(message);

//3. No Return with Parameters
void Greet(string name)//Parameter
{
    Console.WriteLine($"Salam {name}, Jumma Mubarak.");

}

string name = Console.ReadLine();
Greet(name);//Argument


void GreetWithAge(string name, byte age )//Parameter
{
    Console.WriteLine($"Hi {name}, your Age is {age}");

}
GreetWithAge("Haris",23);//Argument


//4. Return with Parameters

int multiply(int a,int b)
{
    return (a * b);
}

Console.WriteLine(multiply(34787, 3434));

//Task : Percentage Calculator {tip: Additionaly you can even show grade of students using conditional statements}



void PerCal()
{
    Console.WriteLine("Enter your Obtained Marks : ");
    double Obtained= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Total Marks : ");
    double Total = Convert.ToDouble(Console.ReadLine());
    if(Obtained <= Total)
    {
        double Percentage = (Obtained / Total) * 100;
        Console.WriteLine($"You' ve got {double.Round(Percentage, 2)}%");
    }
    else
    {
        Console.WriteLine($"Obtained marks must be less than or equal to Total Marks.. :(");
    }

   

}

PerCal();

//Exception Handling

//try / catch block

/*
try
{
    Console.WriteLine("Enter an integer value from 1 to 7");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            Console.WriteLine("Today is monday");
            break;
        case 2:
            Console.WriteLine("Today is tuesday");
            break;
        case 3:
            Console.WriteLine("Today is wednesday");
            break;
        case 4:
            Console.WriteLine("Today is thursday");
            break;
        case 5:
            Console.WriteLine("Today is friday");
            break;
        case 6:
            Console.WriteLine("Today is saturday");
            break;
        case 7:
            Console.WriteLine("Today is Sunday");
            break;
        default:
            Console.WriteLine("Today is monday");
            break;

    }
}

catch (FormatException)
{
    Console.WriteLine("Please enter integer value from 1 to 7");
}


// Collections - 

// Non Generic Collections - Arrays (Fixed Size)
// Generic Collections - List (Dynamic Size) + Additional Methods(Add,Remove,Clear,Sort,Reverse)

//List

List<string> cars = new List<string>();

cars.Add("Mustang");
cars.Add("Ford Raptor");
cars.Add("Mercedes Benz");
cars.Add("Audi A6");
cars.Add("Rolls Royce");
cars.Add("Mehran");
cars.Add("Supra");
cars.Add("Fortuner");

Console.WriteLine(cars[5]);
cars.Add("Revo");

cars.Remove("Mehran");

Console.WriteLine("Getting Cars for AutoShow");


//cars.Clear(); // Empty list
//Console.WriteLine(cars[0]);

// Contains, count,
//
cars.Insert(4, "civic");

foreach (var car in cars)
{
    Console.WriteLine(car);
}
Console.WriteLine(cars.Count());


Console.WriteLine(cars.Contains("city"));
*/

//Priority Collections
//Queues

//using System.Collections;

//FIFO : First in first out
//Queue<string> names = new Queue<string>();
//names.Enqueue("Haris");
//names.Enqueue("Afzal");
//names.Enqueue("Owais");
//names.Enqueue("Usama");
//names.Enqueue("Ebad");

//names.Dequeue();
//names.Dequeue();

//foreach (var name in names)
//{
//    Console.WriteLine(name);

//}

//LIFO : Last in first out

//Stack<string> names = new Stack<string>();

//names.Push("Haris");
//names.Push("Afzal");
//names.Push("Owais");
//names.Push("Usama");
//names.Push("Ebad");

//names.Pop();
//names.Pop();
//names.Pop();
//names.Pop();

//foreach (var name in names)
//{
//    Console.WriteLine(name);

//}

//Array List (any datatype can become an element) Non- Generic
//ArrayList person2 = new ArrayList();
//person2.Add("Shariq Ahmed");
//person2.Add("+92 2311454545");
//person2.Add(45);

//ArrayList person = new ArrayList();
//person.Add("Haris Naseer");
//person.Add("+92 3172021951");
//person.Add(56);
//person.Add("BSCS");
//person.Add("Faculty Member");
//person.AddRange(person2);
//person.RemoveRange(2,5);
//person.Clear();

//person.Remove(56);
//person.RemoveAt(2);// removes BSCS on 2nd index


//Console.WriteLine(person[1]);

//foreach (var item in person)
//{
//    Console.WriteLine(item);
//}


//Create an Array List for Mobile specifications. Take input from user and save the features in your arraylist.
//As User types ok in input you have to display a thanks msg with all specifications.



//Dictionary (Generics) {key : value}<type>

using System.Collections;

Dictionary<string, string> Stationary = new Dictionary<string, string>();

Stationary.Add("product1", "Ink Pen");
Stationary.Add("product2", "Ball Pen");
Stationary.Add("product3", "Pointer");
Stationary.Add("product4", "Board Marker");
Stationary.Add("product5", "Permanent Marker");
Stationary.Remove("product5");

//Console.WriteLine(Stationary["product4"]);

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine(Stationary["product"+i]);
//}

//foreach (var item in Stationary)
//{
//    //Console.WriteLine(item);
//  string[] test =  (item.ToString()).Split(","); // [ "[product1", " Ink pen]"  ]
//    string key = test[0].Trim('[');// [product1 = > trim('[') => product1
//    string value = test[1].Trim(']').ToUpper();
//    Console.WriteLine("The key is : {0} and the value is: {1}",key,value);
//}


// HashTables (Non-Generics)  {key : value}
Hashtable Actors = new Hashtable();
Actors.Add("1st", "Shahrukh khan");
Actors.Add("2nd", "Amir khan");
Actors.Add("3rd", "Salman khan");
Actors.Add("4th", "Ahsan khan");
Actors.Add("5th",007);
Actors.Contains("5th");
Actors.Remove("4th");

Console.WriteLine(Actors["1st"]);

foreach (DictionaryEntry item in Actors)
{
    Console.WriteLine(item.Key + ": " +item.Value);
}

Console.WriteLine(Actors.GetHashCode());