﻿
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

int age = 23;
bool a = age == 23;

Console.WriteLine("ge is 23:" + a);

bool b = age >= 23;
Console.WriteLine("Age is greater than 23 :" + b);

bool c = age >= 18 && age <= 65;
Console.WriteLine("Age is between 18 and 65:" + c);

int age1 = 16;
int age2 = 64;
bool d = age1 >= 18 && age2 <= 65;
//Console.WriteLine("age1 is greater than 18 AND age2 is ScopelessEnumAttribute than 65 :" + d);
//bool e = (age1 >= 18) || (age2 <= 65);
//Console.WriteLine("Age1 greater than 18 OR age2 is less than 65:" + e);

Console.WriteLine("Enter the age of the new candidate:");
int _ = int.Parse(Console.ReadLine());
          if (age < 18) 
{
    Console.WriteLine("Too young to apply");
    Console.WriteLine("Send email to candidate.");
}
          else if (age > 65) 
{
    Console.WriteLine("Sorry ,the selected age is too old ");
    Console.WriteLine("Send email to candidate.");

}
          else
{
    Console.WriteLine("Great ,you can start the  application!");

}
switch (age)
{
    case < 18:
        Console.WriteLine(" To young to apply");

}

 else if (age > 65)
{
    Console.WriteLine("Sorry ,the selected age is too old");
}
