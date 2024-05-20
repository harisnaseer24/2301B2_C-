



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

//Will not allow us to use DictionaryEntry because of fixed datatype.

//foreach (DictionaryEntry item in Stationary)
//{
//    Console.WriteLine(item.Key + ": " + item.Value);
//}

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

Console.WriteLine(Actors.GetHashCode());*/



//Game supermario = new Game();

//supermario.gameName = "Super Mario 7";
//supermario.company = "Nintendo";
//supermario.gameVersion = 2;


//Game supermario = new()
//{
//    gameName = "Super Mario 7",
//    company = "Nintendo",
//    gameVersion = 2
//};



//Game supermario = new Game("Super Mario 5", 2, "Nintendo");
//Game GTA = new Game("GTA 5");

//Console.WriteLine(GTA.gameName);

//Console.WriteLine(supermario.gameName);


//class Game
//{
//    public string gameName;
//    public int gameVersion;
//    public string company;



//    public Game(string gN, int gameVersion, string company)
//    {
//        this.gameName = gN;
//        this.gameVersion = gameVersion;
//        this.company = company;
//    }

//    public Game(string gN, int gameVersion)
//    {
//        this.gameName = gN;
//        this.gameVersion = gameVersion;
//    }

//    public Game(string gN)
//    {
//        this.gameName = gN;
//    }




//}
//String Methods
//using System.Collections;

//string test = "Welcome,  to, C#, Programming";

//Console.WriteLine(test.Replace("C#","C++"));
//Console.WriteLine(test.ToLower());
//Console.WriteLine(test.ToUpper());


//string[] abc = test.Split("+");
//foreach (var item in abc)
//{

//    Console.WriteLine(item);

//}

//string xyz = test.Trim();
//Console.WriteLine(xyz);


//Classes and Objects

//Song abc = new Song(); 
//Console.WriteLine(abc.SongName); 
//Console.WriteLine(abc.Singer);


//abc.Singer = "Ali Zafar";
//abc.SongName = "Allay";
//abc.ReleaseDate = "10/6/2019";

//Console.WriteLine(abc.Singer);
//Console.WriteLine(abc.SongName);
//Console.WriteLine(abc.ReleaseDate);

//Song kamleya = new Song("KAmleya","Arijit Singh","12/4/24");
//Console.WriteLine(kamleya.Singer);
//Console.WriteLine(kamleya.SongName);
//Console.WriteLine(kamleya.ReleaseDate);

//class Song
//{
//    public string SongName;
//    public string Singer;
//    public string ReleaseDate;

//    public Song(){
//        this.SongName = "Unknown";
//       this.Singer = "Unknown";
//       this.ReleaseDate = "Unknown";
//    }  
//    //Constructor (Method) Overloading
//    public Song(string name, string singer,string date){
//       this.SongName = name;
//       this.Singer = singer;
//       this.ReleaseDate = date;
//    }

//}


//indentation 
//meaningful variable names
//less repeatation
//no errors
//comments
// OOP (Object Oriented Programming)
//access modifiers

//main pillars
//1. Abstraction
//2. Encapsulation
//3. Polymorphism
// Overloading  add(1,2), add(1,2,3), add(4,56,7,8) ( parameters or return type of methods should be different in overloading)
// Overriding
//4. Inheritance


//Creating Objects of Child class
//Cars raptor = new Cars("2024 LE","Ford Raptor", 320.57f  );


////raptor.run();

//raptor.stop(raptor.name);

////over riding (Can over riding is possible within a class?)
//raptor.run();

////Creating object of grandchild class
//Ecar bmw = new Ecar("2024", "bmw i8 electric",240.44f ,"1kv", "800 KM");
//bmw.run();




////Parent Class (Super Class)
//class Vehicle
//{
//   public float speed;

//    public void run()
//    {
//        Console.WriteLine("Boom!  Vehicle started running");
//    }
//    public void stop(string name)
//    {
//        Console.WriteLine($"Boom!  {name} is stopping.");
//    }
//}

////Child Class (Derived Class)
//class Cars: Vehicle
//{
//    public string model;
//    public string name;

//    //constructor
//    public Cars(string model, string name, float speed)
//    {
//        this.model = model;
//        this.name = name;
//        this.speed = speed;
//    }
//    public void run()
//    {
//        Console.WriteLine($"Boom!  {this.name} started running");
//    }

//}

////Child class of Cars
//class  Ecar: Cars
//{
//    public string battery;
//    public string OneChargeMileage;

//    //constructor gettin use 
//    public Ecar(string model, string name, float speed, string battery, string OneChargeMileage):base(model, name,speed)
//    {

//        this.battery = battery; 
//        this.OneChargeMileage = OneChargeMileage;
//    }
//    public void run()
//    {
//        Console.WriteLine($"Boom!  {this.name} started running. It has huge battery of  {this.battery} and gives  {this.OneChargeMileage} in one charge.  ");
//    }

//}

//Vehicle abc = new Vehicle(); can't create an object of an abstract class
//Cars a = new Cars("2023", "Corolla", 220.45f);
//Cars b = new Cars("2023", "Surf", 220.45f);
//Cars c = new Cars("2023", "Mark X", 220.45f);
//Cars d = new Cars("2023", "Revo", 220.45f);

//Cars[] carsforSale = new Cars[4];
//carsforSale[0] = a;
//carsforSale[1] = b;
//carsforSale[2] = c;
//carsforSale[3] = d;

//foreach (Cars car in carsforSale)
//{
//    car.run();
//    Console.WriteLine(car.name);
//    car.stop(car.name);
//    Console.WriteLine();
//}

////a.run();

////Math x = new Math();
////x.Abs(-45);

////Calling a static function
////Vehicle.race();

// abstract  class Vehicle
//{
//    public float speed;
//    static public int wheels;

//    //static methods are made for class not for objects
//    static public void race()
//    {
//        Console.WriteLine("Let's go race has been started.");
//    }
//    public void run()
//    {
//        Console.WriteLine("Boom!  Vehicle started running");
//    }
//    public void stop(string name)
//    {
//        Console.WriteLine($"Boom!  {name} is stopping.");
//    }
//}

////Child Class (Derived Class)
//class Cars : Vehicle
//{
//    public string model;
//    public string name;

//    //constructor
//    public Cars(string model, string name, float speed)
//    {
//        this.model = model;
//        this.name = name;
//        this.speed = speed;
//    }
//    public void run()
//    {
//        Console.WriteLine($"Boom!  {this.name} started running");
//    }

//}


//Abstract class or interfaces

//Interfaces (Need to implement all methods when inheriting from interfaces):

//Lion simba = new Lion();
//simba.hunt();
//simba.eat();


//Deers jarvis = new Deers();
//jarvis.run("Jarvis Deer");
//jarvis.getEaten();

//using System.Security.Cryptography.X509Certificates;

//Fishes nemo = new Fishes();
//nemo.run("Nemo");
//nemo.getEaten();
//nemo.hunt();

//Fishes Shark = new Fishes();
//Shark.hunt();
//Shark.eat();


//interface Hunters
//{
//    public void hunt();
//    public void eat();
//}
//interface Baits
//{
//    public void run(string name);
//    public void getEaten();
//}

//public class Lion : Hunters
//{
//   public void hunt()
//    {
//        Console.WriteLine("The Lion is hunting a prey.");
//    }
//    public void eat() {
//        Console.WriteLine("The Lion is eating a prey after successful hunt.");
//    }
//}


//public class Deers : Baits
//{
//    public void run(string name)
//    {
//        Console.WriteLine($"The {name} is running from hunters.");
//    }
//    public void getEaten() {
//        Console.WriteLine("The Deer has been eaten by the Lions.");
//    }
//}

// Multiple inheritance
//public class Fishes : Hunters , Baits
//{
//    public void hunt()
//    {
//        Console.WriteLine("The Fish is hunting a prey.");
//    }
//    public void eat()
//    {
//        Console.WriteLine("The Fish is eating a prey after successful hunt.");
//    }
//    public void run(string name)
//    {
//        Console.WriteLine($"The {name} is running from hunters.");
//    }
//    public void getEaten()
//    {
//        Console.WriteLine("The Fish has been caught by the Hunters and getting eaten.");
//    }

//}

//front end, backend and fullstack examples

//Abstraction
// Facebook user , admin Panel, 

//Encapsulation
// properties and methods are bundled in a class.

//Access Modifiers

//1. public : any one can access.

//2. private : only owner class can access.

//3. protected : only owner class and child class can access

//Product duster = new Product("duster",100, 500);
//duster.showPrice();
////Console.WriteLine(duster.qty);
//duster.showQty();


//houseHolds cushion = new houseHolds("cushion", 1500, 200,"decoration");

//cushion.showItem();

//public class Product
//{
//    public string? name;
//    private int? price;
//    protected int? qty;

//    //parameterized (setter function)
//    public Product(string name, int price, int qty)
//    {
//        this.name = name;
//        this.price = price;
//        this.qty = qty;
//    }




//(Getter function)
//    public void showPrice()
//    {
//        Console.WriteLine(this.price);
//    } public void showQty()
//    {
//        Console.WriteLine(this.qty);
//    }
//}


//public class houseHolds : Product
//{
//    public string category;

//    public houseHolds(string name , int price, int qty, string category): base(name,price,qty)
//    {
//        this.category = category;

//    }

//    public void showItem()
//    {
//        Console.WriteLine(this.name);

//   //     Console.WriteLine(this.price);//cant access private property in child class
//        this.showPrice();
//        Console.WriteLine(this.qty);//can access protected property in child class
//        Console.WriteLine(this.category);

//    }

//}


// Delegates

//Maths.Calculator cal;

//cal = Maths.Addition;

//cal(65,7.9);

////cal = Maths.Division;
////cal(60, 10);

//cal = Maths.Subtraction;
//cal(60, 10);//50

//cal = Maths.Multiplication;
//cal(60, 10);//50


//Console.WriteLine(Maths.Division(45, 5));



//public class Maths
//{
//    public  delegate  void Calculator (double num1, double num2 );

//    public static void Division(double num1, double num2)
//    {

//      Console.WriteLine(num1 / num2);

//    }
//    public static void Addition (double num1, double num2){

//        Console.WriteLine(num1 +num2);

//    }      

//    public static void Subtraction(double num1, double num2)
//    {

//        Console.WriteLine(num1 - num2);

//    }

//    public static void Multiplication(double num1, double num2)
//    {

//        Console.WriteLine(num1 * num2);

//    }

//    //public static void Division(double num1, double num2)
//    //{

//    //    Console.WriteLine(num1 / num2);

//    //}
//}

//stationary.getStationary shopping;

//shopping = stationary.getPencilSharpener;
//shopping("dollar", "blue");

//public class stationary
//{
//    public delegate void getStationary(string item1, string item2);

//    public static void  getPencilSharpener(string item1, string item2)
//    {
//        Console.WriteLine($"we have shipped your items including pencil of: {item1} and sharpener of :{item2}");
//    }

//    public static void  getInkpenRemover(string item1, string item2)
//    {
//        Console.WriteLine($"we have shipped your items including ink pen of: {item1} and remover of :{item2}");
//    }

//}

// office , animals , clothes (any 2)

//Ternary operator (conditional statement)

string firstVal = "Haris";
string secondVal = "Owais";
bool condition= 67 <= 87;// true


string check = (condition) ? firstVal : secondVal;

Console.WriteLine(check);

