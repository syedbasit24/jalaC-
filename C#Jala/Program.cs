// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Threading.Channels;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

//Declare a variable of data type int with name empID 

int empID =5;


//Declare a variable of data type string with name empName

string empName="Puja";
Console.WriteLine(empID);
Console.WriteLine(empName);



//even or odd
class Program
{
    public static void Main(String[] args)
    {
        int num = 2;
        if (num %  2==0) {
            Console.WriteLine("it is even" + num);

        }
        else
        {
            Console.WriteLine("it is odd" + num);
        }
    }
}


//swap two numbers 

int a = 22;
int b = 65;
Console.WriteLine(a+ "," +b);
int temp = a;
a = b;
b = temp;
Console.WriteLine(a+ "," +b);

//Create any value called EmpName and print that value in the output in c#

string EmpName = "John Doe";
Console.WriteLine("Employee Name: " + EmpName);

//Declare a variable name of any datatype and read the name in the output

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Your name is: " + name);

//Enter your name and from WriteLine function and print the output c#

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Hello, " + name + "! Welcome to the program.");

//eclare a 2 strings as input and contacenate with another string with the both 
Strings and get Outputstring input1 = "Hello";
string input2 = "world";
string concatenatedString = input1 + " " + input2 + "!";

Console.WriteLine("Concatenated string: " + concatenatedString);


//Write a program by taking two integer values and return the value by adding in the 
Console.WriteLine("Enter the first integer:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second integer:");
int num2 = int.Parse(Console.ReadLine());

int sum = num1 + num2;

Console.WriteLine("Sum: " + sum);


//Write a program to enter password by converting it to char array into string print the
Console.WriteLine("Enter the password:");
string password = Console.ReadLine();

char[] passwordChars = password.ToCharArray();
string passwordString = new string(passwordChars);

Console.WriteLine("Password: " + passwordString.Length);


// Declare a value as int datatype and print in the output
using System;

class Program
{
    static void Main()
    {
        int myNumber = 10;  // Declaring an integer variable named myNumber and assigning it the value 10

        Console.WriteLine(myNumber);  // Printing the value of myNumber to the output

        // Alternatively, you can use string interpolation for a more concise syntax:
        // Console.WriteLine($"The value is: {myNumber}");

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}


//Write a program in boolean type and print in console

using System;

class Program
{
    static void Main()
    {
        bool isRaining = true;  // Declaring a boolean variable named isRaining and assigning it the value true

        Console.WriteLine("Is it raining? " + isRaining);  // Printing the value of isRaining to the output

        // Alternatively, you can use string interpolation for a more concise syntax:
        // Console.WriteLine($"Is it raining? {isRaining}");

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}


// Write a program on converting Float to Decimal type and print in console

using System;

class Program
{
    static void Main()
    {
        float floatValue = 3.14159f;  // Floating-point number

        decimal decimalValue = Convert.ToDecimal(floatValue);  // Converting float to decimal

        Console.WriteLine(decimalValue);  // Printing the decimal value to the output

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}


//Write a C# Sharp program that takes two numbers as input and perform an


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
            case 'x':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }

        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}




//Write a C# Sharp program that takes three letters as input and display them in


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first letter: ");
        char letter1 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter the second letter: ");
        char letter2 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter the third letter: ");
        char letter3 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Output: " + letter3 + " " + letter2 + " " + letter1);

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}


//Write a C# Sharp program that takes a character as input and check the input 


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a character: ");
        char symbol = Convert.ToChar(Console.ReadLine());

        if (Char.IsDigit(symbol))
        {
            Console.WriteLine("It is a digit.");
        }
        else if (IsLowercaseVowel(symbol))
        {
            Console.WriteLine("It is a lowercase vowel.");
        }
        else
        {
            Console.WriteLine("It is any other symbol.");
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }

    static bool IsLowercaseVowel(char symbol)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        return Array.IndexOf(vowels, symbol) >= 0;
    }
}



//. Write the program to demonstrate the working of Binary Arithmetic Operators ?

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /, %):");
        char op = Convert.ToChar(Console.ReadLine());

        int result = 0;

        switch (op)
        {
            case '+':
                result = a + b;
                Console.WriteLine("Addition Operator: " + result);
                break;
            case '-':
                result = a - b;
                Console.WriteLine("Subtraction Operator: " + result);
                break;
            case '*':
                result = a * b;
                Console.WriteLine("Multiplication Operator: " + result);
                break;
            case '/':
                if (b != 0)
                {
                    result = a / b;
                    Console.WriteLine("Division Operator: " + result);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;
            case '%':
                if (b != 0)
                {
                    result = a % b;
                    Console.WriteLine("Modulo Operator: " + result);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}


//Write the program to demonstrate the working of Unary Arithmetic Operators ?


using System;

class UnaryOperatorsDemo
{
    static void Main()
    {
        int a = 10;
        int res;

        // Post-increment operator
        res = a++;
        Console.WriteLine("a is {0} and res is {1}", a, res);

        // Post-decrement operator
        res = a--;
        Console.WriteLine("a is {0} and res is {1}", a, res);

        // Pre-increment operator
        res = ++a;
        Console.WriteLine("a is {0} and res is {1}", a, res);

        // Pre-decrement operator
        res = --a;
        Console.WriteLine("a is {0} and res is {1}", a, res);

        Console.ReadLine();
    }
}


//Write the program to demonstrate the working of Relational Operators ?
using System;

class RelationalOperatorsDemo
{
    static void Main()
    {
        Console.WriteLine("Enter the values of a and b:");

        // Read the values of a and b from the user
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        // Equal to operator
        bool equalTo = (a == b);
        Console.WriteLine("Equal to Operator: {0}", equalTo);

        // Greater than operator
        bool greaterThan = (a > b);
        Console.WriteLine("Greater than Operator: {0}", greaterThan);

        // Less than operator
        bool lessThan = (a < b);
        Console.WriteLine("Less than Operator: {0}", lessThan);

        // Greater than or equal to operator
        bool greaterThanOrEqual = (a >= b);
        Console.WriteLine("Greater than or Equal to: {0}", greaterThanOrEqual);

        // Lesser than or equal to operator
        bool lesserThanOrEqual = (a <= b);
        Console.WriteLine("Lesser than or Equal to: {0}", lesserThanOrEqual);

        // Not equal to operator
        bool notEqualTo = (a != b);
        Console.WriteLine("Not Equal to Operator: {0}", notEqualTo);

        Console.ReadLine();
    }
}



//write a program to Implicit Type Conversion
using System;

class ImplicitConversionDemo
{
    static void Main()
    {
        Console.WriteLine("Enter an int value:");
        int intValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a long value:");
        long longValue = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Int value: {0}", intValue);
        Console.WriteLine("Long value: {0}", longValue);

        Console.ReadLine();
    }
}


//Write an example of explicit type conversion
using System;

class ExplicitConversionDemo
{
    static void Main()
    {
        Console.WriteLine("Enter the value of I:");
        int i = Convert.ToInt32(Console.ReadLine());

        double d = i; // Implicit conversion from int to double
        Console.WriteLine("Value of d: {0}", d);

        int j = (int)d; // Explicit conversion from double to int
        Console.WriteLine("Value of j: {0}", j);

        Console.ReadLine();
    }
}



//Write a program of built in type conversion methods

using System;

class TypeConversionMethodsDemo
{
    static void Main()
    {
        Console.WriteLine("Enter a string name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter an integer value:");
        int intValue = Convert.ToInt32(Console.ReadLine());

        float floatValue = Convert.ToSingle(name);
        Console.WriteLine("string to float: {0}", floatValue);

        double doubleValue = Convert.ToDouble(intValue);
        Console.WriteLine("int to double: {0}", doubleValue);

        Console.ReadLine();
    }
}


//. Write a program that converts various value types to string type
using System;

class ValueTypeToStringDemo
{
    static void Main()
    {
        Console.WriteLine("Enter an integer value:");
        int intValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a float value:");
        float floatValue = Convert.ToSingle(Console.ReadLine());

        string intToString = intValue.ToString();
        Console.WriteLine("int.ToString(): {0}", intToString);

        string floatToString = floatValue.ToString();
        Console.WriteLine("float.ToString(): {0}", floatToString);

        Console.ReadLine();
    }
}


// Write a C# Sharp program to check whether a given number is positive or negative.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Get the input number from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is positive or negative
        if (number > 0)
        {
            Console.WriteLine("{0} is a positive number", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("{0} is a negative number", number);
        }
        else
        {
            Console.WriteLine("{0} is zero", number);
        }
    }
}


//. Write a C# Sharp program to find whether a given year is a leap year or not.
using System;

public class LeapYear
{
    public static void Main()
    {
        // Get the year from the user
        Console.WriteLine("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is a leap year
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

        // Display the result
        if (isLeapYear)
        {
            Console.WriteLine("{0} is a leap year", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year", year);
        }
    }
}


//Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
using System;

public class VowelConsonant
{
    public static void Main()
    {
        // Get the alphabet from the user
        Console.WriteLine("Enter any alphabet: ");
        char ch = Console.ReadLine().ToLower()[0];

        // Check if the alphabet is a vowel
        bool isVowel = (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');

        // Display the result
        if (isVowel)
        {
            Console.WriteLine("{0} is a vowel", ch);
        }
        else
        {
            Console.WriteLine("{0} is a consonant", ch);
        }
    }
}


//Write a program in C# Sharp to display n terms of natural number and their sum.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of natural terms you want: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("The first " + n + " natural numbers are: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        int sum = (n * (n + 1)) / 2;
        Console.WriteLine("\nThe sum of natural numbers up to " + n + " terms: " + sum);
    }
}


//Write a program in C# Sharp to display the n terms of odd natural number and their 


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("The odd numbers are: ");
        int sum = 0;
        int count = 0;
        int num = 1;

        while (count < n)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
                sum += num;
                count++;
            }
            num++;
        }

        Console.WriteLine("\nThe sum of odd natural numbers up to " + n + " terms: " + sum);
    }
}



//By using Array write the program using For and Foreach loop in c#
 

using System;

class Program
{
    static void Main()
    {
        string[] array = { "Jala", "Technologies" };

        Console.WriteLine("Array printing using for loop:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Array printing using foreach loop:");
        foreach (string element in array)
        {
            Console.Write(element);
        }
        Console.WriteLine();
    }
}


//Write a program using WriteLine(Boolean) method in c#

using System;

class Program
{
    static void Main()
    {
        bool isTrue = true;
        bool isFalse = false;

        Console.WriteLine(isTrue);   // Output: True
        Console.WriteLine(isFalse);  // Output: False
    }
}


// Write a program on static and instance methods in c#

using System;

class MyClass
{
    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }

    // Instance method
    public void InstanceMethod()
    {
        Console.WriteLine("This is an instance method.");
    }
}

class Program
{
    static void Main()
    {
        // Calling a static method
        MyClass.StaticMethod();

        // Creating an instance of MyClass
        MyClass myObject = new MyClass();

        // Calling an instance method
        myObject.InstanceMethod();
    }
}


//Write a method of Calculator and print sum and product in c#

 using System;

class Calculator
{
    public void CalculateSumAndProduct(int a, int b)
    {
        int sum = a + b;
        int product = a * b;

        Console.WriteLine($"Sum = {sum} and Product = {product}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a and b values:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Calculator calculator = new Calculator();
        calculator.CalculateSumAndProduct(a, b);
    }
}


//Write a program using parameter arrays and print output in console in c#

using System;

class Program
{
    static void PrintNumbers(params int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        PrintNumbers(1, 2, 3, 4, 5);
        PrintNumbers(10, 20, 30);
        PrintNumbers(100, 200, 300, 400, 500, 600);
    }
}


//Write a program to print entered number of even numbers in c#


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int count = Convert.ToInt32(Console.ReadLine());

        int number = 2;
        for (int i = 0; i < count; i++)
        {
            Console.Write(number + " ");
            number += 2;
        }

        Console.WriteLine();
    }
}


// Construct a class using any methods for employee details using its parameters and print output

using System;

public class Employee
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    // Constructor
    public Employee(string name, int age, string department, double salary)
    {
        Name = name;
        Age = age;
        Department = department;
        Salary = salary;
    }

    // Method to print employee details
    public void PrintDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Salary: $" + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Employee class
        Employee employee = new Employee("John Doe", 30, "IT", 5000.00);

        // Calling the PrintDetails method to print the employee details
        employee.PrintDetails();
    }
}


//Write a program using overloading class constructor.
using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Default constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Constructor with name parameter
    public Person(string name)
    {
        Name = name;
        Age = 0;
    }

    // Constructor with name and age parameters
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Person Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of the Person class using different constructors
        Person person1 = new Person();
        Person person2 = new Person("John");
        Person person3 = new Person("Jane", 25);

        // Printing details of each person
        person1.PrintDetails();
        Console.WriteLine();
        person2.PrintDetails();
        Console.WriteLine();
        person3.PrintDetails();
    }
}


//. Create a Car class with three class members and two fields and one method in c#

using System;

public class Car
{
    // Fields
    private string make;
    private string model;

    // Properties
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    // Constructor
    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }

    // Method
    public void StartEngine()
    {
        Console.WriteLine("The {0} {1} engine is started.", Make, Model);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Car class
        Car myCar = new Car("Ford", "Mustang");

        // Accessing the fields and method of the Car class
        Console.WriteLine("Car Details:");
        Console.WriteLine("Make: " + myCar.Make);
        Console.WriteLine("Model: " + myCar.Model);
        Console.WriteLine();

        myCar.StartEngine();
    }
}


//Create an object of the Car class, with the name myObj. Then we print the value of the fields color and maxSpeed.

using System;

public class Car
{
    public string color;    // Field
    public int maxSpeed;    // Field
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Car class
        Car myObj = new Car();

        // Assigning values to the fields
        myObj.color = "Red";
        myObj.maxSpeed = 200;

        // Printing the values of the fields
        Console.WriteLine("Color: " + myObj.color);
        Console.WriteLine("Max Speed: " + myObj.maxSpeed);
    }
}


//Write a program on creating multiple objects of one class in c#

using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating multiple objects of the Person class
        Person person1 = new Person();
        person1.Name = "John";
        person1.Age = 30;

        Person person2 = new Person();
        person2.Name = "Jane";
        person2.Age = 25;

        // Displaying information of each person
        Console.WriteLine("Person 1:");
        person1.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Person 2:");
        person2.DisplayInfo();
    }
}

// Define a static variable and access that through class name.

public class MyClass
{
    public static int myStaticVariable = 10;
}
int value = MyClass.myStaticVariable;


// Define a static method and access that through a instance

public class MyClass
{
    public static void MyStaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }
    MyClass myInstance = new MyClass();
    myInstance.MyStaticMethod();

}


//. Define a static and instance variable constructors and invoke the instance constructor

public class MyClass
{
    // Static variable
    public static int staticVariable;

    // Instance variable
    public int instanceVariable;

    // Static constructor
    static MyClass()
    {
        staticVariable = 100;
        Console.WriteLine("Static constructor called");
    }

    // Instance constructor
    public MyClass()
    {
        instanceVariable = 200;
        Console.WriteLine("Instance constructor called");
    }
}


//. Define a static variable and change within the class
public class MyClass
{
    public static int staticVariable;

    public void ChangeStaticVariable(int newValue)
    {
        staticVariable = newValue;
    }
    MyClass.staticVariable = 10; // Assign an initial value to the static variable

MyClass instance = new MyClass();
    instance.ChangeStaticVariable(20); // Change the value of the static variable

int currentValue = MyClass.staticVariable; // Access the updated value of the static variable

}



//Write a program on A class has two methods with the same name "Add" but with 
//different input parameters (the first method has three parameters and the second 
//method has two parameters) in c#


using System;

public class Calculator
{
    public int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int result1 = calculator.Add(2, 3, 4);
        Console.WriteLine("Result1: " + result1);

        int result2 = calculator.Add(5, 6);
        Console.WriteLine("Result2: " + result2);
    }
}


//Write a program on Runtime polymorphism in c#
using System;

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Shape shape1 = new Circle();
        Shape shape2 = new Rectangle();

        shape1.Draw();  // Calls the overridden Draw() method in Circle class
        shape2.Draw();  // Calls the overridden Draw() method in Rectangle class
    }
}


//Write a program on taking one method with same but different signature in the methods 

using System;

public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int result1 = calculator.Add(2, 3);
        Console.WriteLine("Result1: " + result1);

        int result2 = calculator.Add(2, 3, 4);
        Console.WriteLine("Result2: " + result2);

        double result3 = calculator.Add(2.5, 3.7);
        Console.WriteLine("Result3: " + result3);
    }
}


//Write a program to demonstrate the function overloading by changing the Data types of 
//the parameters  in c#

using System;

public class Converter
{
    public void Convert(int number)
    {
        Console.WriteLine("Converting int to string: " + number.ToString());
    }

    public void Convert(double number)
    {
        Console.WriteLine("Converting double to string: " + number.ToString());
    }

    public void Convert(string text)
    {
        Console.WriteLine("Converting string to uppercase: " + text.ToUpper());
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Converter converter = new Converter();

        int intValue = 10;
        double doubleValue = 3.14;
        string stringValue = "hello";

        converter.Convert(intValue);
        converter.Convert(doubleValue);
        converter.Convert(stringValue);
    }
}


//Write a program to demonstrate the function overloading by changing the Order of the parameters in c#
using System;

public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int result1 = calculator.Add(2, 3);
        Console.WriteLine("Result1: " + result1);

        int result2 = calculator.Add(2, 3, 4);
        Console.WriteLine("Result2: " + result2);

        double result3 = calculator.Add(2.5, 3.7);
        Console.WriteLine("Result3: " + result3);
    }
}


 //Define a program on overloading by changing the Number of parameters

using System;

public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public int Add(int num1, int num2, int num3, int num4)
    {
        return num1 + num2 + num3 + num4;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int result1 = calculator.Add(2, 3);
        Console.WriteLine("Result1: " + result1);

        int result2 = calculator.Add(2, 3, 4);
        Console.WriteLine("Result2: " + result2);

        int result3 = calculator.Add(2, 3, 4, 5);
        Console.WriteLine("Result3: " + result3);
    }
}


//Define a program on changing the order of parameters using method overloading.
using System;

public class Converter
{
    public void Convert(int number)
    {
        Console.WriteLine("Converting int to string: " + number.ToString());
    }

    public void Convert(string text)
    {
        Console.WriteLine("Converting string to uppercase: " + text.ToUpper());
    }

    public void Convert(double number, int decimalPlaces)
    {
        string formattedNumber = number.ToString("N" + decimalPlaces);
        Console.WriteLine("Converting double to string with " + decimalPlaces + " decimal places: " + formattedNumber);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Converter converter = new Converter();

        int intValue = 10;
        string stringValue = "hello";
        double doubleValue = 3.14159;
        int decimalPlaces = 2;

        converter.Convert(intValue);
        converter.Convert(stringValue);
        converter.Convert(doubleValue, decimalPlaces);
    }
}


//. Define a program on a function Sum() that accepts values as a parameter and print their addition
//
//using System;

public class Calculator
{
    public void Sum(params int[] values)
    {
        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }
        Console.WriteLine("Sum: " + sum);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        calculator.Sum(2, 3, 4);
        calculator.Sum(1, 2, 3, 4, 5);
        calculator.Sum(10, 20, 30, 40, 50, 60);
    }
}


//. Define a program on a function Division() that accepts multiple values as a parameter and print their divisor

using System;

public class Calculator
{
    public void Division(params int[] values)
    {
        if (values.Length == 0)
        {
            Console.WriteLine("No values provided.");
            return;
        }

        int divisor = values[0];
        foreach (int value in values)
        {
            if (value == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }

            divisor /= value;
        }

        Console.WriteLine("Divisor: " + divisor);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        calculator.Division(2, 1);
        calculator.Division(10, 5, 2);
        calculator.Division(10, 0, 2);
        calculator.Division(); // No values provided
    }
}

//Write a program on illustrating the read-only property by taking as class Employee 
using System;

class Employee
{
    public string Name { get; }   // Read-only property
    public int Age { get; set; }  // Read-write property

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("John Doe", 30);

        Console.WriteLine($"Name: {emp.Name}");
        Console.WriteLine($"Age: {emp.Age}");

        // Attempting to modify the read-only property will result in a compile-time error
        // emp.Name = "Jane Doe";  // Uncommenting this line will give an error

        // Modifying the read-write property is allowed
        emp.Age = 35;

        Console.WriteLine($"Updated Age: {emp.Age}");
    }
}


//Write a program on both read and write property using get and set accessories 


using System;

class Employee
{
    private string _name;  // private field

    public string Name   // Read-write property
    {
        get { return _name; }
        set { _name = value; }
    }

    private int _age;  // private field

    public int Age   // Read-write property
    {
        get { return _age; }
        set { _age = value; }
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.Name = "John Doe";
        emp.Age = 30;

        Console.WriteLine($"Name: {emp.Name}");
        Console.WriteLine($"Age: {emp.Age}");
    }
}


//Create a class with name EmployeeModel with 5 properties EmpId int, EmpName string, EmailId string, Salary float, IsEmployeeActive bool
class EmployeeModel
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmailId { get; set; }
    public float Salary { get; set; }
    public bool IsEmployeeActive { get; set; }
}


//Create an object for the above EmployeeModel and assign the values to all properties and print each property on console

class Program
{
    static void Main()
    {
        // Create an instance of EmployeeModel
        EmployeeModel employee = new EmployeeModel();

        // Assign values to the properties
        employee.EmpId = 1;
        employee.EmpName = "John Doe";
        employee.EmailId = "john.doe@example.com";
        employee.Salary = 5000.00f;
        employee.IsEmployeeActive = true;

        // Print each property on the console
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Employee ID: {employee.EmpId}");
        Console.WriteLine($"Employee Name: {employee.EmpName}");
        Console.WriteLine($"Email ID: {employee.EmailId}");
        Console.WriteLine($"Salary: {employee.Salary}");
        Console.WriteLine($"Is Employee Active: {employee.IsEmployeeActive}");
    }
}


// Create another object for the above EmployeeModel and assign different values to all properties and print each property on console
class Program
{
    static void Main()
    {
        // Create the first instance of EmployeeModel
        EmployeeModel employee1 = new EmployeeModel();

        // Assign values to the properties of the first object
        employee1.EmpId = 1;
        employee1.EmpName = "John Doe";
        employee1.EmailId = "john.doe@example.com";
        employee1.Salary = 5000.00f;
        employee1.IsEmployeeActive = true;

        // Print each property of the first object on the console
        Console.WriteLine("Employee 1 Details:");
        Console.WriteLine($"Employee ID: {employee1.EmpId}");
        Console.WriteLine($"Employee Name: {employee1.EmpName}");
        Console.WriteLine($"Email ID: {employee1.EmailId}");
        Console.WriteLine($"Salary: {employee1.Salary}");
        Console.WriteLine($"Is Employee Active: {employee1.IsEmployeeActive}");

        // Create the second instance of EmployeeModel
        EmployeeModel employee2 = new EmployeeModel();

        // Assign different values to the properties of the second object
        employee2.EmpId = 2;
        employee2.EmpName = "Jane Smith";
        employee2.EmailId = "jane.smith@example.com";
        employee2.Salary = 6000.00f;
        employee2.IsEmployeeActive = false;

        // Print each property of the second object on the console
        Console.WriteLine("Employee 2 Details:");
        Console.WriteLine($"Employee ID: {employee2.EmpId}");
        Console.WriteLine($"Employee Name: {employee2.EmpName}");
        Console.WriteLine($"Email ID: {employee2.EmailId}");
        Console.WriteLine($"Salary: {employee2.Salary}");
        Console.WriteLine($"Is Employee Active: {employee2.IsEmployeeActive}");
    }
}


//Write a program to show the use of public Access Modifier in c# 


using System;

class Student
{
    public int StudentId;
    public string StudentName;
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.WriteLine("Enter the details of the student:");
        Console.Write("Student ID: ");
        student.StudentId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Student Name: ");
        student.StudentName = Console.ReadLine();

        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Student ID: {student.StudentId}");
        Console.WriteLine($"Student Name: {student.StudentName}");
    }
}
//Write a program on protected access modifier using one method in c#

using System;

class Parent
{
    protected void DisplayValue()
    {
        int x = 10;
        Console.WriteLine($"Output: {x}");
    }
}

class Child : Parent
{
    public void PrintValue()
    {
        DisplayValue();
    }
}

class Program
{
    static void Main()
    {
        Child child = new Child();
        child.PrintValue();
    }
}


//Write a program on private access modifier in c#

using System;

class MyClass
{
    private int privateVariable;

    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");

        // Access the private variable and private method within the class
        privateVariable = 10;
        PrivateMethod();
    }
}

class Program
{
    static void Main()
    {
        MyClass myObj = new MyClass();

        // Access the public method, but not the private variable or private method
        myObj.PublicMethod();
    }
}


//Write a program on default access modifier in c#
using System;

class MyClass
{
    int defaultVariable;  // Default access modifier is private

    void DefaultMethod()
    {
        Console.WriteLine("This is a default method.");
    }

    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");

        // Access the default variable and default method within the class
        defaultVariable = 10;
        DefaultMethod();
    }
}

class Program
{
    static void Main()
    {
        MyClass myObj = new MyClass();

        // Access the public method, but not the default variable or default method
        myObj.PublicMethod();
    }
}


//. Write any 5 Properties of List

In C#, a list is a commonly used data structure that represents an ordered collection of elements. Here are five properties of the list in C#:

1. Dynamic Size: Lists in C# have a dynamic size, which means they can grow or shrink as elements are added or removed. This makes them flexible for handling varying amounts of data.

2. Indexed Access: Lists provide indexed access to their elements, allowing you to access elements by their position. The index starts at 0, so the first element is accessed using index 0, the second with index 1, and so on.

3. Ordered Elements: Lists maintain the order of elements as they are added. This means that elements are stored in the list based on the order in which they were inserted, and you can rely on this order when working with the list.

4. Heterogeneous Elements: Lists in C# can store elements of different data types. For example, you can have a list that contains a mix of integers, strings, objects, or any other valid data type supported by C#.

5. Built-in Operations: Lists provide a variety of built-in operations and methods to manipulate and work with the collection of elements. These operations include adding and removing elements, searching for elements, sorting, iterating over the elements, and more.


    //. Write any 5 methods of List 

    List<string> names = new List<string>();
names.Add("Alice");
names.Add("Bob");


List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
numbers.Remove(30);


List<char> characters = new List<char> { 'a', 'b', 'c' };
characters.Clear();


List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
bool containsTwenty = numbers.Contains(20);


List<int> numbers = new List<int> { 50, 20, 40, 10, 30 };
numbers.Sort();


// Create an integer list and add any 5 integers to this list   

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Adding integers to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // Printing the elements in the list
        Console.WriteLine("Elements in the list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}



//Print the integer elements in the above list using for loop
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Adding integers to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // Printing the elements in the list using a for loop
        Console.WriteLine("Elements in the list:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}



//Print the integer elements in the above list using  foreach loop   
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Adding integers to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // Printing the elements in the list using a foreach loop
        Console.WriteLine("Elements in the list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}


//Create an string list and add any 5 integers to this list

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();

        // Adding strings to the list
        words.Add("Apple");
        words.Add("Banana");
        words.Add("Cherry");
        words.Add("Date");
        words.Add("Elderberry");

        // Printing the elements in the list
        Console.WriteLine("Elements in the list:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}


// Print the string elements in the above list using for  loop   

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();

        // Adding strings to the list
        words.Add("Apple");
        words.Add("Banana");
        words.Add("Cherry");
        words.Add("Date");
        words.Add("Elderberry");

        // Printing the elements in the list using a for loop
        Console.WriteLine("Elements in the list:");
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}


//Print the string elements in the above list using  foreach loop

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();

        // Adding strings to the list
        words.Add("Apple");
        words.Add("Banana");
        words.Add("Cherry");
        words.Add("Date");
        words.Add("Elderberry");

        // Printing the elements in the list using a foreach loop
        Console.WriteLine("Elements in the list:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}


//Count the elements in the list and print on the console  

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Counting the elements in the list
        int count = numbers.Count;

        // Printing the count on the console
        Console.WriteLine("Number of elements in the list: " + count);
    }
}


// Clear all the elements in the list using clear method

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Clearing the elements in the list
        numbers.Clear();

        // Printing the count on the console
        Console.WriteLine("Number of elements in the list: " + numbers.Count);
    }
}


//Check whether 'Kishore' is present in the string list using exists method  

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "John", "Alice", "Kishore", "Bob", "Mary" };

        // Checking if "Kishore" exists in the list
        bool exists = names.Exists(name => name == "Kishore");

        // Printing the result on the console
        Console.WriteLine("Does 'Kishore' exist in the list? " + exists);
    }
}


//. Check whether 'Kishore' is present in the string list using Find  method
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "John", "Alice", "Kishore", "Bob", "Mary" };

        // Checking if "Kishore" exists in the list
        string kishore = names.Find(name => name == "Kishore");

        // Printing the result on the console
        if (kishore != null)
        {
            Console.WriteLine("'Kishore' exists in the list.");
        }
        else
        {
            Console.WriteLine("'Kishore' does not exist in the list.");
        }
    }
}


// Check whether 'Kishore' is present in the string list using contains method  


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "John", "Alice", "Kishore", "Bob", "Mary" };

        // Checking if "Kishore" exists in the list
        bool containsKishore = names.Contains("Kishore");

        // Printing the result on the console
        if (containsKishore)
        {
            Console.WriteLine("'Kishore' exists in the list.");
        }
        else
        {
            Console.WriteLine("'Kishore' does not exist in the list.");
        }
    }
}


//. Insert  an element into the list using Insert method   

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Inserting an element at index 2
        numbers.Insert(2, 25);

        // Printing the updated list
        Console.WriteLine("Elements in the list after inserting:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}


//. Reverse the list using reverse method  

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Reversing the list
        numbers.Reverse();

        // Printing the reversed list
        Console.WriteLine("Reversed list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}


// Remove an element at index 3 using RemoveAt method 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Removing the element at index 3
        numbers.RemoveAt(3);

        // Printing the updated list
        Console.WriteLine("Elements in the list after removal:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}


// Create a list with student class (List that accepts student objects)  
using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        // Creating a list of Student objects
        List<Student> students = new List<Student>();

        // Adding Student objects to the list
        students.Add(new Student("Alice", 20));
        students.Add(new Student("Bob", 22));
        students.Add(new Student("Charlie", 21));

        // Printing the list of students
        Console.WriteLine("List of Students:");
        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}

// Add 10  Student  objects to the  list  

using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        // Creating a list of Student objects
        List<Student> students = new List<Student>();

        // Adding 10 Student objects to the list
        students.Add(new Student("Alice", 20));
        students.Add(new Student("Bob", 22));
        students.Add(new Student("Charlie", 21));
        students.Add(new Student("David", 19));
        students.Add(new Student("Emily", 20));
        students.Add(new Student("Frank", 23));
        students.Add(new Student("Grace", 21));
        students.Add(new Student("Henry", 22));
        students.Add(new Student("Isabella", 19));
        students.Add(new Student("Jack", 20));

        // Printing the list of students
        Console.WriteLine("List of Students:");
        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}


//Count the elements in the list and print on the console  

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a list of Student objects
        List<Student> students = new List<Student>();

        // Adding 10 Student objects to the list
        students.Add(new Student("Alice", 20));
        students.Add(new Student("Bob", 22));
        students.Add(new Student("Charlie", 21));
        students.Add(new Student("David", 19));
        students.Add(new Student("Emily", 20));
        students.Add(new Student("Frank", 23));
        students.Add(new Student("Grace", 21));
        students.Add(new Student("Henry", 22));
        students.Add(new Student("Isabella", 19));
        students.Add(new Student("Jack", 20));

        // Counting the number of elements in the list
        int count = students.Count;

        // Printing the count on the console
        Console.WriteLine($"Number of students: {count}");
    }
}


//. Clear all the elements in the list using clear method

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a list of Student objects
        List<Student> students = new List<Student>();

        // Adding 10 Student objects to the list
        students.Add(new Student("Alice", 20));
        students.Add(new Student("Bob", 22));
        students.Add(new Student("Charlie", 21));
        students.Add(new Student("David", 19));
        students.Add(new Student("Emily", 20));
        students.Add(new Student("Frank", 23));
        students.Add(new Student("Grace", 21));
        students.Add(new Student("Henry", 22));
        students.Add(new Student("Isabella", 19));
        students.Add(new Student("Jack", 20));

        // Clearing the list
        students.Clear();

        // Printing the count after clearing the list
        Console.WriteLine($"Number of students after clearing: {students.Count}");
    }
}


//Create a datatable object
using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("ID", typeof(int));
        dataTable.Columns.Add("Name", typeof(string));
        dataTable.Columns.Add("Age", typeof(int));

        // Add rows to the DataTable
        dataTable.Rows.Add(1, "John", 25);
        dataTable.Rows.Add(2, "Jane", 30);
        dataTable.Rows.Add(3, "Mark", 35);

        // Display the DataTable
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", row["ID"], row["Name"], row["Age"]);
        }
    }
}


// Create  a datatable object with a name by using constructor
using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable with a name
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("ID", typeof(int));
        dataTable.Columns.Add("Name", typeof(string));
        dataTable.Columns.Add("Age", typeof(int));

        // Add rows to the DataTable
        dataTable.Rows.Add(1, "John", 25);
        dataTable.Rows.Add(2, "Jane", 30);
        dataTable.Rows.Add(3, "Mark", 35);

        // Display the DataTable
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", row["ID"], row["Name"], row["Age"]);
        }
    }
}


//. Write any 10 properties of DataTable
Sure! Here are 10 common properties of the DataTable class in C#:

1. **TableName**: Gets or sets the name of the DataTable.
2. **Columns**: Gets the collection of DataColumn objects that define the schema of the DataTable.
3. **Rows**: Gets the collection of DataRow objects that represent the data in the DataTable.
4. **Constraints**: Gets the collection of Constraint objects that define constraints on the DataTable.
5. **PrimaryKey**: Gets or sets an array of DataColumn objects that make up the primary key of the DataTable.
6. **ParentRelations**: Gets the collection of DataRelation objects that relate this DataTable to its parent tables.
7. **ChildRelations**: Gets the collection of DataRelation objects that relate this DataTable to its child tables.
8. **DefaultView**: Gets a customized view of the DataTable that can be sorted, filtered, and searched.
9. **Namespace**: Gets or sets the namespace for the XML representation of the data stored in the DataTable.
10. **ExtendedProperties**: Gets the collection of additional user-defined properties associated with the DataTable.

These are just a few properties available in the DataTable class. There are more properties and methods that can be used to manipulate and work with data in a DataTable.


    // Write any 10 method of DataTable

    Certainly! Here are 10 common methods of the DataTable class in C#:

1. ** NewRow**: Creates a new DataRow with the same schema as the DataTable.
2. **Load**: Loads data into the DataTable from a data reader or a data adapter.
3. **ImportRow**: Copies a DataRow into the DataTable.
4. **Clear**: Clears all data from the DataTable, removing all rows.
5. **Clone**: Creates a copy of the DataTable, including structure and data.
6. **Compute**: Computes a given expression on the current rows that match the filter criteria.
7. **Merge**: Merges another DataTable into the current DataTable, combining both schema and data.
8. **Select**: Returns an array of DataRow objects that match the specified filter criteria.
9. **AcceptChanges**: Commits all changes made to the DataTable since the last call to AcceptChanges.
10. **RejectChanges**: Rolls back all changes made to the DataTable since the last call to AcceptChanges.

These are just a few methods available in the DataTable class. There are more methods that can be used to manipulate, query, and interact with data in a DataTable.


    //Add 4 columns(EmpId, EmpName, Emp Salary,  Department) to this data table object using columns.add() method.

    using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("EmpId", typeof(int));
        dataTable.Columns.Add("EmpName", typeof(string));
        dataTable.Columns.Add("EmpSalary", typeof(decimal));
        dataTable.Columns.Add("Department", typeof(string));

        // Add rows to the DataTable
        dataTable.Rows.Add(1, "John Doe", 5000.00, "Sales");
        dataTable.Rows.Add(2, "Jane Smith", 6000.00, "Marketing");
        dataTable.Rows.Add(3, "Mark Johnson", 7000.00, "Finance");

        // Display the DataTable
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine("EmpId: {0}, EmpName: {1}, EmpSalary: {2}, Department: {3}",
                row["EmpId"], row["EmpName"], row["EmpSalary"], row["Department"]);
        }
    }
}


//Add 5 records to this datatable object using Rows.Add() method. 

using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("EmpId", typeof(int));
        dataTable.Columns.Add("EmpName", typeof(string));
        dataTable.Columns.Add("EmpSalary", typeof(decimal));
        dataTable.Columns.Add("Department", typeof(string));

        // Add records to the DataTable
        dataTable.Rows.Add(1, "John Doe", 5000.00, "Sales");
        dataTable.Rows.Add(2, "Jane Smith", 6000.00, "Marketing");
        dataTable.Rows.Add(3, "Mark Johnson", 7000.00, "Finance");
        dataTable.Rows.Add(4, "Alice Brown", 5500.00, "Sales");
        dataTable.Rows.Add(5, "Robert Davis", 6500.00, "Operations");

        // Display the DataTable
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine("EmpId: {0}, EmpName: {1}, EmpSalary: {2}, Department: {3}",
                row["EmpId"], row["EmpName"], row["EmpSalary"], row["Department"]);
        }
    }
}


//Print the EmpId column of this datatable using for loop
using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("EmpId", typeof(int));
        dataTable.Columns.Add("EmpName", typeof(string));
        dataTable.Columns.Add("EmpSalary", typeof(decimal));
        dataTable.Columns.Add("Department", typeof(string));

        // Add records to the DataTable
        dataTable.Rows.Add(1, "John Doe", 5000.00, "Sales");
        dataTable.Rows.Add(2, "Jane Smith", 6000.00, "Marketing");
        dataTable.Rows.Add(3, "Mark Johnson", 7000.00, "Finance");
        dataTable.Rows.Add(4, "Alice Brown", 5500.00, "Sales");
        dataTable.Rows.Add(5, "Robert Davis", 6500.00, "Operations");

        // Print the EmpId column
        Console.WriteLine("EmpId column values:");
        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            Console.WriteLine(dataTable.Rows[i]["EmpId"]);
        }
    }
}



//Print the EmpId column of this datatable using foreach loop

using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("EmpId", typeof(int));
        dataTable.Columns.Add("EmpName", typeof(string));
        dataTable.Columns.Add("EmpSalary", typeof(decimal));
        dataTable.Columns.Add("Department", typeof(string));

        // Add records to the DataTable
        dataTable.Rows.Add(1, "John Doe", 5000.00, "Sales");
        dataTable.Rows.Add(2, "Jane Smith", 6000.00, "Marketing");
        dataTable.Rows.Add(3, "Mark Johnson", 7000.00, "Finance");
        dataTable.Rows.Add(4, "Alice Brown", 5500.00, "Sales");
        dataTable.Rows.Add(5, "Robert Davis", 6500.00, "Operations");

        // Print the EmpId column
        Console.WriteLine("EmpId column values:");
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine(row["EmpId"]);
        }
    }
}


//Print the EmpId column of this datatable using DataRow property

using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("EmpId", typeof(int));
        dataTable.Columns.Add("EmpName", typeof(string));
        dataTable.Columns.Add("EmpSalary", typeof(decimal));
        dataTable.Columns.Add("Department", typeof(string));

        // Add records to the DataTable
        dataTable.Rows.Add(1, "John Doe", 5000.00, "Sales");
        dataTable.Rows.Add(2, "Jane Smith", 6000.00, "Marketing");
        dataTable.Rows.Add(3, "Mark Johnson", 7000.00, "Finance");
        dataTable.Rows.Add(4, "Alice Brown", 5500.00, "Sales");
        dataTable.Rows.Add(5, "Robert Davis", 6500.00, "Operations");

        // Print the EmpId column
        Console.WriteLine("EmpId column values:");
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine(row.Field<int>("EmpId"));
        }
    }
}


//Create another datatable with  5 columns(Your choice) and  4 records

using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("ProductID", typeof(int));
        dataTable.Columns.Add("ProductName", typeof(string));
        dataTable.Columns.Add("Category", typeof(string));
        dataTable.Columns.Add("UnitPrice", typeof(decimal));
        dataTable.Columns.Add("UnitsInStock", typeof(int));

        // Add records to the DataTable
        dataTable.Rows.Add(1, "Product A", "Electronics", 999.99, 10);
        dataTable.Rows.Add(2, "Product B", "Clothing", 49.99, 50);
        dataTable.Rows.Add(3, "Product C", "Home Decor", 19.99, 25);
        dataTable.Rows.Add(4, "Product D", "Books", 9.99, 100);

        // Display the DataTable
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine("ProductID: {0}, ProductName: {1}, Category: {2}, UnitPrice: {3}, UnitsInStock: {4}",
                row["ProductID"], row["ProductName"], row["Category"], row["UnitPrice"], row["UnitsInStock"]);
        }
    }
}


//Create a DataSet object  

using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataSet
        DataSet dataSet = new DataSet("MyDataSet");

        // Create a DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("ID", typeof(int));
        dataTable.Columns.Add("Name", typeof(string));
        dataTable.Columns.Add("Age", typeof(int));

        // Add rows to the DataTable
        dataTable.Rows.Add(1, "John", 25);
        dataTable.Rows.Add(2, "Jane", 30);
        dataTable.Rows.Add(3, "Mark", 35);

        // Add the DataTable to the DataSet
        dataSet.Tables.Add(dataTable);

        // Access the DataTable within the DataSet
        DataTable retrievedDataTable = dataSet.Tables["MyDataTable"];

        // Display the data from the retrieved DataTable
        foreach (DataRow row in retrievedDataTable.Rows)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", row["ID"], row["Name"], row["Age"]);
        }
    }
}


//Create a DataSet object with name 'MyDataSet' using its constructor

using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataSet with name "MyDataSet"
        DataSet dataSet = new DataSet("MyDataSet");

        // Perform operations with the DataSet
        // ...
    }
}


//. Add above two datatables to MyDataSet DataSet using Tables.Add() method

using System;
using System.Data;

class Program
{
    static void Main()
    {
        // Create a new DataSet with name "MyDataSet"
        DataSet dataSet = new DataSet("MyDataSet");

        // Create the first DataTable
        DataTable dataTable1 = new DataTable("DataTable1");
        dataTable1.Columns.Add("ID", typeof(int));
        dataTable1.Columns.Add("Name", typeof(string));
        dataTable1.Rows.Add(1, "John");
        dataTable1.Rows.Add(2, "Jane");

        // Create the second DataTable
        DataTable dataTable2 = new DataTable("DataTable2");
        dataTable2.Columns.Add("ProductID", typeof(int));
        dataTable2.Columns.Add("ProductName", typeof(string));
        dataTable2.Rows.Add(101, "Product A");
        dataTable2.Rows.Add(102, "Product B");

        // Add the DataTables to the DataSet
        dataSet.Tables.Add(dataTable1);
        dataSet.Tables.Add(dataTable2);

        // Access the DataTables within the DataSet
        DataTable retrievedDataTable1 = dataSet.Tables["DataTable1"];
        DataTable retrievedDataTable2 = dataSet.Tables["DataTable2"];

        // Display the data from the retrieved DataTables
        Console.WriteLine("Data from DataTable1:");
        foreach (DataRow row in retrievedDataTable1.Rows)
        {
            Console.WriteLine("ID: {0}, Name: {1}", row["ID"], row["Name"]);
        }

        Console.WriteLine("\nData from DataTable2:");
        foreach (DataRow row in retrievedDataTable2.Rows)
        {
            Console.WriteLine("ProductID: {0}, ProductName: {1}", row["ProductID"], row["ProductName"]);
        }
    }
}


//Write any 3 Properties of ArrayList

ArrayList myArrayList = new ArrayList();
myArrayList.Add("Apple");
myArrayList.Add("Banana");
myArrayList.Add("Orange");

int count = myArrayList.Count; // Retrieves the count of elements in the ArrayList
Console.WriteLine("Count: " + count); // Output: Count: 3


    ArrayList myArrayList = new ArrayList(5); // Specifies an initial capacity of 5 elements
int capacity = myArrayList.Capacity; // Retrieves the capacity of the ArrayList
Console.WriteLine("Capacity: " + capacity); // Output: Capacity: 5


    ArrayList myArrayList = new ArrayList();
myArrayList.Add("Apple");
myArrayList.Add("Banana");
myArrayList.Add("Orange");

bool isFixedSize = myArrayList.IsFixedSize; // Checks if the ArrayList has a fixed size
Console.WriteLine("Is Fixed Size: " + isFixedSize); // Output: Is Fixed Size: False


    // Write any 3 methods of ArrayList

    ArrayList myArrayList = new ArrayList();
myArrayList.Add("Apple");
myArrayList.Add("Banana");
myArrayList.Add("Orange");

myArrayList.Add("Mango"); // Adds "Mango" to the end of the ArrayList


    ArrayList myArrayList = new ArrayList();
myArrayList.Add("Apple");
myArrayList.Add("Banana");
myArrayList.Add("Orange");

myArrayList.Remove("Banana"); // Removes the first occurrence of "Banana" from the ArrayList



    ArrayList myArrayList = new ArrayList();
myArrayList.Add("Apple");
myArrayList.Add("Banana");
myArrayList.Add("Orange");

bool containsBanana = myArrayList.Contains("Banana"); // Checks if the ArrayList contains "Banana"
if (containsBanana)
{
    Console.WriteLine("The ArrayList contains 'Banana'.");
}
else
{
    Console.WriteLine("The ArrayList does not contain 'Banana'.");
}


// Difference between Array and Arraylist  

Arrays and ArrayLists are both used to store collections of data, but they have some key differences:

1.Fixed Size vs. Dynamic Size:
   -Arrays: Arrays have a fixed size, meaning the length is determined at the time of declaration and cannot be changed afterward. To resize an array, you need to create a new array with the desired size and copy the elements from the original array.
   - ArrayList: ArrayLists have a dynamic size and can grow or shrink dynamically as elements are added or removed. The capacity of an ArrayList is automatically managed internally.

2. Type Safety:
   -Arrays: Arrays in .NET are type-safe, meaning they can store elements of a specific type. Once defined, the elements in an array must conform to the specified type.
   - ArrayList: ArrayLists are not type-safe by default. They can store elements of any type since they store objects. However, you can use generics with the `List<T>` class (available in newer versions of .NET) to achieve type safety similar to arrays.

3. Direct Access vs. Methods:
   -Arrays: Arrays allow for direct access to elements using index-based notation.You can access or modify elements in an array using the index position.
   - ArrayList: ArrayLists require the use of methods to add, remove, or access elements. They provide methods like `Add`, `Remove`, and `Get` to manipulate the collection.

4. Performance:
   -Arrays: Arrays generally offer better performance in terms of accessing elements since they provide direct index-based access. They have a fixed size, which allows for efficient memory allocation and access.
   - ArrayList: ArrayLists may have slightly lower performance due to the overhead of using methods for element manipulation and dynamic resizing of the collection.However, the performance impact may not be significant for small to moderate - sized collections.

In summary, arrays are fixed-size, type - safe collections with direct access to elements, while ArrayLists are dynamic-sized collections that provide flexibility but involve additional overhead and lack type safety. The choice between the two depends on the specific requirements of your program, such as the need for dynamic resizing or type safety.



    
    //Create a Arraylist and add 3 string elements  'One' , 'Two' , 'Three' by using add using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create a new ArrayList
        ArrayList arrayList = new ArrayList();

        // Add string elements to the ArrayList
        arrayList.Add("One");
        arrayList.Add("Two");
        arrayList.Add("Three");

        // Display the elements in the ArrayList
        foreach (string element in arrayList)
        {
            Console.WriteLine(element);
        }
    }
}

//Print the above arraylist element using for and foreach loop

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create a new ArrayList
        ArrayList arrayList = new ArrayList();

        // Add string elements to the ArrayList
        arrayList.Add("One");
        arrayList.Add("Two");
        arrayList.Add("Three");

        // Print elements using a for loop
        Console.WriteLine("Elements using a for loop:");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine(arrayList[i]);
        }

        Console.WriteLine();

        // Print elements using a foreach loop
        Console.WriteLine("Elements using a foreach loop:");
        foreach (string element in arrayList)
        {
            Console.WriteLine(element);
        }
    }
}


//Remove all the elements in the ArrayList using Clear method

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create a new ArrayList
        ArrayList arrayList = new ArrayList();

        // Add string elements to the ArrayList
        arrayList.Add("One");
        arrayList.Add("Two");
        arrayList.Add("Three");

        // Print the elements before removing
        Console.WriteLine("Elements before clearing:");
        foreach (string element in arrayList)
        {
            Console.WriteLine(element);
        }

        // Clear the ArrayList
        arrayList.Clear();

        // Print the elements after removing
        Console.WriteLine("\nElements after clearing:");
        foreach (string element in arrayList)
        {
            Console.WriteLine(element);
        }
    }
}


//0. Reverse all the elements in the ArrayList using  Reverse method

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create a new ArrayList
        ArrayList arrayList = new ArrayList();

        // Add string elements to the ArrayList
        arrayList.Add("One");
        arrayList.Add("Two");
        arrayList.Add("Three");

        // Print the elements before reversing
        Console.WriteLine("Elements before reversing:");
        foreach (string element in arrayList)
        {
            Console.WriteLine(element);
        }

        // Reverse the ArrayList
        arrayList.Reverse();

        // Print the elements after reversing
        Console.WriteLine("\nElements after reversing:");
        foreach (string element in arrayList)
        {
            Console.WriteLine(element);
        }
    }
}


//Sort all the elements in the ArrayList using  Sort method  

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create a new ArrayList
        ArrayList arrayList = new ArrayList();

        // Add string elements to the ArrayList
        arrayList.Add("Apple");
        arrayList.Add("Orange");
        arrayList.Add("Banana");

        // Print the elements before sorting
        Console.WriteLine("Elements before sorting:");
        foreach (string element in arrayList)
        {
            Console.WriteLine(element);
        }

        // Sort the ArrayList
        arrayList.Sort();

        // Print the elements after sorting
        Console.WriteLine("\nElements after sorting:");
        foreach (string element in arrayList)
        {
            Console.WriteLine(element);
        }
    }
}



//1. Create a list of employee objects with properties EmpId,EmpName,EmpSalary and DeptId  
add 10 employee objects to the above list  
  
Note:   
Create objects with at least two objects having same property values  
ie Two objects should have  empname="kishore" (or  any same value)  
ie Two objects should have  deptid =2 (or  any same value)  
ie Two objects should have  empsalary=1000 (or  any same value)  
  
  
Questions:
1.Check whether 'Kishore' employee is present in the  list using select method with lambda 
expression.   and print the empid, empname, empsal and deptid of the employee object 
print distinct objects not distinct name

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Check if an employee with name 'Kishore' is present using select method with lambda expression
        List<Employee> kishoreEmployees = employeeList.Where(emp => emp.EmpName == "Kishore").ToList();

        if (kishoreEmployees.Count > 0)
        {
            foreach (Employee emp in kishoreEmployees)
            {
                Console.WriteLine("Employee ID: " + emp.EmpId);
                Console.WriteLine("Employee Name: " + emp.EmpName);
                Console.WriteLine("Employee Salary: " + emp.EmpSalary);
                Console.WriteLine("Department ID: " + emp.DeptId);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No employee with the name 'Kishore' found in the list.");
        }
    }
}


Check whether empid =4 employee is present in the  list using select method with lambda 
expression.   and print the empid, empname, empsal and deptid of the employee object 
print distinct objects not distinct names

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Check if an employee with empid = 4 is present using select method with lambda expression
        Employee employee = employeeList.FirstOrDefault(emp => emp.EmpId == 4);

        if (employee != null)
        {
            Console.WriteLine("Employee ID: " + employee.EmpId);
            Console.WriteLine("Employee Name: " + employee.EmpName);
            Console.WriteLine("Employee Salary: " + employee.EmpSalary);
            Console.WriteLine("Department ID: " + employee.DeptId);
        }
        else
        {
            Console.WriteLine("No employee with empid = 4 found in the list.");
        }
    }
}


Check whether deptid=4 employee is present in the  list using select method with lambda 
expression.   and print the empid, empname, empsal and deptid of the employee object  
print distinct objects not distinct names

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Check if an employee with deptid = 4 is present using select method with lambda expression
        List<Employee> employeesWithDeptId4 = employeeList.Where(emp => emp.DeptId == 4).ToList();

        if (employeesWithDeptId4.Count > 0)
        {
            foreach (Employee emp in employeesWithDeptId4)
            {
                Console.WriteLine("Employee ID: " + emp.EmpId);
                Console.WriteLine("Employee Name: " + emp.EmpName);
                Console.WriteLine("Employee Salary: " + emp.EmpSalary);
                Console.WriteLine("Department ID: " + emp.DeptId);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No employee with deptid = 4 found in the list.");
        }
    }
}


//4. Create another employee list and copy the above list to this newly created employee list

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Create a new employee list and copy the contents
        List<Employee> newEmployeeList = new List<Employee>(employeeList);

        // Print the contents of the new employee list
        foreach (Employee emp in newEmployeeList)
        {
            Console.WriteLine("Employee ID: " + emp.EmpId);
            Console.WriteLine("Employee Name: " + emp.EmpName);
            Console.WriteLine("Employee Salary: " + emp.EmpSalary);
            Console.WriteLine("Department ID: " + emp.DeptId);
            Console.WriteLine();
        }
    }
}


//Create another employee list and copy the above list with empname having Kishore and print 
this list
Note: The new list should contain only employee objects with name Kishore 

    using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Create a new employee list with employees having name "Kishore"
        List<Employee> kishoreEmployees = employeeList.Where(emp => emp.EmpName == "Kishore").ToList();

        // Print the kishoreEmployees list
        foreach (Employee emp in kishoreEmployees)
        {
            Console.WriteLine("Employee ID: " + emp.EmpId);
            Console.WriteLine("Employee Name: " + emp.EmpName);
            Console.WriteLine("Employee Salary: " + emp.EmpSalary);
            Console.WriteLine("Department ID: " + emp.DeptId);
            Console.WriteLine();
        }
    }
}


Create another employee list and copy the above list with empsalary having greater than 2000 
and print this list count and list   
Note: The new list should contain only employee objects with empsalary >2000   

    using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Create a new employee list with employees having empsalary > 2000
        List<Employee> highSalaryEmployees = employeeList.Where(emp => emp.EmpSalary > 2000).ToList();

        // Print the count of highSalaryEmployees list
        Console.WriteLine("Number of Employees with EmpSalary > 2000: " + highSalaryEmployees.Count);

        // Print the highSalaryEmployees list
        foreach (Employee emp in highSalaryEmployees)
        {
            Console.WriteLine("Employee ID: " + emp.EmpId);
            Console.WriteLine("Employee Name: " + emp.EmpName);
            Console.WriteLine("Employee Salary: " + emp.EmpSalary);
            Console.WriteLine("Department ID: " + emp.DeptId);
            Console.WriteLine();
        }
    }
}


. Check whether deptid=4 employee is present in the  list using select method with lambda 
expression.   and print the empid, empname, empsal and deptid of the employee object  

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Check if an employee with deptid = 4 is present using select method with lambda expression
        var employeeWithDeptId4 = employeeList.FirstOrDefault(emp => emp.DeptId == 4);

        if (employeeWithDeptId4 != null)
        {
            Console.WriteLine("Employee ID: " + employeeWithDeptId4.EmpId);
            Console.WriteLine("Employee Name: " + employeeWithDeptId4.EmpName);
            Console.WriteLine("Employee Salary: " + employeeWithDeptId4.EmpSalary);
            Console.WriteLine("Department ID: " + employeeWithDeptId4.DeptId);
        }
        else
        {
            Console.WriteLine("No employee with deptid = 4 found in the list.");
        }
    }
}


// Check whether deptid=4 employee is present in the  list using contains method with lambda 
expression.and print the empid, empname, empsal and deptid of the employee object 

    using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Check if an employee with deptid = 4 is present using Contains method with lambda expression
        bool hasEmployeeWithDeptId4 = employeeList.Any(emp => emp.DeptId == 4);

        if (hasEmployeeWithDeptId4)
        {
            var employeeWithDeptId4 = employeeList.Where(emp => emp.DeptId == 4);

            foreach (var emp in employeeWithDeptId4)
            {
                Console.WriteLine("Employee ID: " + emp.EmpId);
                Console.WriteLine("Employee Name: " + emp.EmpName);
                Console.WriteLine("Employee Salary: " + emp.EmpSalary);
                Console.WriteLine("Department ID: " + emp.DeptId);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No employee with deptid = 4 found in the list.");
        }
    }
}


Print the distinct employee name count in the  list using Distinct method with lambda 
expression.   and print the empid, empname, empsal and deptid of the employee objects 

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 8, EmpName = "Sarah", EmpSalary = 3500, DeptId = 3 },
            new Employee { EmpId = 9, EmpName = "Alex", EmpSalary = 2000, DeptId = 2 },
            new Employee { EmpId = 10, EmpName = "Katherine", EmpSalary = 1000, DeptId = 2 }
        };

        // Get the count of distinct employee names
        int distinctEmployeeNamesCount = employeeList.Select(emp => emp.EmpName).Distinct().Count();

        Console.WriteLine("Count of distinct employee names: " + distinctEmployeeNamesCount);
        Console.WriteLine();

        // Print the details of all employee objects
        foreach (var emp in employeeList)
        {
            Console.WriteLine("Employee ID: " + emp.EmpId);
            Console.WriteLine("Employee Name: " + emp.EmpName);
            Console.WriteLine("Employee Salary: " + emp.EmpSalary);
            Console.WriteLine("Department ID: " + emp.DeptId);
            Console.WriteLine();
        }
    }
}


//Create an integer array with 5 elements and convert this integer array into integer list 
using ToList()

    using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create an integer array with 5 elements
        int[] integerArray = { 1, 2, 3, 4, 5 };

        // Convert the integer array to an integer list using ToList()
        List<int> integerList = integerArray.ToList();

        // Print the elements of the integer list
        foreach (var number in integerList)
        {
            Console.WriteLine(number);
        }
    }
}


//. Get the first employee in the employee list using First() method

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 6, EmpName = "David", EmpSalary = 2000, DeptId = 1 }
        };

        // Get the first employee using First()
        Employee firstEmployee = employeeList.First();

        // Print the details of the first employee
        Console.WriteLine("Employee ID: " + firstEmployee.EmpId);
        Console.WriteLine("Employee Name: " + firstEmployee.EmpName);
        Console.WriteLine("Employee Salary: " + firstEmployee.EmpSalary);
        Console.WriteLine("Department ID: " + firstEmployee.DeptId);
    }
}


//Get the first employee in the employee list using FirstOrDefault() method 

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 6, EmpName = "David", EmpSalary = 2000, DeptId = 1 }
        };

        // Get the first employee using FirstOrDefault()
        Employee firstEmployee = employeeList.FirstOrDefault();

        // Check if the firstEmployee is not null before accessing its properties
        if (firstEmployee != null)
        {
            // Print the details of the first employee
            Console.WriteLine("Employee ID: " + firstEmployee.EmpId);
            Console.WriteLine("Employee Name: " + firstEmployee.EmpName);
            Console.WriteLine("Employee Salary: " + firstEmployee.EmpSalary);
            Console.WriteLine("Department ID: " + firstEmployee.DeptId);
        }
        else
        {
            Console.WriteLine("No employees found in the list.");
        }
    }
}


// Get the first employee in the employee list using Single() method  

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 6, EmpName = "David", EmpSalary = 2000, DeptId = 1 }
        };

        // Get the first employee using Single()
        Employee firstEmployee = employeeList.Single();

        // Print the details of the first employee
        Console.WriteLine("Employee ID: " + firstEmployee.EmpId);
        Console.WriteLine("Employee Name: " + firstEmployee.EmpName);
        Console.WriteLine("Employee Salary: " + firstEmployee.EmpSalary);
        Console.WriteLine("Department ID: " + firstEmployee.DeptId);
    }
}


//Get the first employee in the employee list using SingleOrDefault() method 

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 5, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 },
            new Employee { EmpId = 6, EmpName = "David", EmpSalary = 2000, DeptId = 1 }
        };

        // Get the first employee using SingleOrDefault()
        Employee firstEmployee = employeeList.SingleOrDefault();

        if (firstEmployee != null)
        {
            // Print the details of the first employee
            Console.WriteLine("Employee ID: " + firstEmployee.EmpId);
            Console.WriteLine("Employee Name: " + firstEmployee.EmpName);
            Console.WriteLine("Employee Salary: " + firstEmployee.EmpSalary);
            Console.WriteLine("Department ID: " + firstEmployee.DeptId);
        }
        else
        {
            Console.WriteLine("No employees found in the list.");
        }
    }
}


//Sort the employee list by EmpID using OrderBy() method  

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 5, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 }
        };

        // Sort the employee list by EmpId using OrderBy()
        List<Employee> sortedList = employeeList.OrderBy(emp => emp.EmpId).ToList();

        // Print the sorted employee list
        foreach (Employee employee in sortedList)
        {
            Console.WriteLine("Employee ID: " + employee.EmpId);
            Console.WriteLine("Employee Name: " + employee.EmpName);
            Console.WriteLine("Employee Salary: " + employee.EmpSalary);
            Console.WriteLine("Department ID: " + employee.DeptId);
            Console.WriteLine();
        }
    }
}


//Sort the employee list by EmpName using OrderBy() method 

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 5, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 }
        };

        // Sort the employee list by EmpName using OrderBy()
        List<Employee> sortedList = employeeList.OrderBy(emp => emp.EmpName).ToList();

        // Print the sorted employee list
        foreach (Employee employee in sortedList)
        {
            Console.WriteLine("Employee ID: " + employee.EmpId);
            Console.WriteLine("Employee Name: " + employee.EmpName);
            Console.WriteLine("Employee Salary: " + employee.EmpSalary);
            Console.WriteLine("Department ID: " + employee.DeptId);
            Console.WriteLine();
        }
    }
}


//Sort the employee list by EmpName and then reverse by empid using Sort() method

using System;
using System.Collections.Generic;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>
        {
            new Employee { EmpId = 4, EmpName = "Mike", EmpSalary = 2500, DeptId = 1 },
            new Employee { EmpId = 2, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee { EmpId = 6, EmpName = "David", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 1, EmpName = "John", EmpSalary = 2000, DeptId = 1 },
            new Employee { EmpId = 3, EmpName = "Jane", EmpSalary = 3000, DeptId = 3 },
            new Employee { EmpId = 5, EmpName = "Alice", EmpSalary = 1500, DeptId = 3 }
        };

        // Sort the employee list by EmpName in ascending order
        employeeList.Sort((emp1, emp2) => emp1.EmpName.CompareTo(emp2.EmpName));

        // Reverse the order of the list by EmpId
        employeeList.Sort((emp1, emp2) => emp2.EmpId.CompareTo(emp1.EmpId));

        // Print the sorted and reversed employee list
        foreach (Employee employee in employeeList)
        {
            Console.WriteLine("Employee ID: " + employee.EmpId);
            Console.WriteLine("Employee Name: " + employee.EmpName);
            Console.WriteLine("Employee Salary: " + employee.EmpSalary);
            Console.WriteLine("Department ID: " + employee.DeptId);
            Console.WriteLine();
        }
    }
}




