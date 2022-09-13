using System.ComponentModel;

Console.WriteLine("What is your first name?");// input 
var userName = Console.ReadLine();

Console.WriteLine($"Hi, {userName}. What is your favorite color?"); // input
var color = Console.ReadLine();

Console.WriteLine($"{color} is sketch. What is your favorite animal?");// input
var animal = Console.ReadLine();

Console.WriteLine($"{animal} is the best! What is your favorite band?");// input
var band = Console.ReadLine();

Console.WriteLine($"{band} is well-known. He was a likeable guy whose passing was related to his struggle with existentialism. You are wise, Earl."); //input


// Exercise II / Mathematica

Console.WriteLine(Add(5,5));
Console.WriteLine(Divide(2,2));
Console.WriteLine(Multiply(3,3));
Console.WriteLine(Subtract(4,4));


    static int Add(int num1, int num2)
    { 
        return num1 + num2;
    }
    static int Divide(int num3, int num4)
    {
        return num3 / num4;  
    }
    static int Multiply(int num5, int num6)
    {
        return num5 * num6;
    }
    static int Subtract(int num7, int num8)
    {
        return num7 - num8;
    }


