using CsharpP2;
using System;


//prob 12
Prob12 person = new Prob12();
person.Name = "John";
person.Age = 25;
person.Greet();


//prob 18
MyClass obj = new MyClass();
obj.PrintMessage(); // call instance method

MyStaticClass.PrintMessage(); // call static method


//DateTime currentDate = DateTime.Now;

//// get the day of the month
//int day = currentDate.Day;


//// get the month as a string
//string month = currentDate.ToString("MMMM");


//Console.WriteLine(currentDate.AddHours(-2));

//// add 1 day to the current date
//DateTime tomorrow = currentDate.AddDays(1);

//// subtract 2 hours from the current time
//DateTime twoHoursAgo = currentDate.AddHours(-2);

//// compare two dates
//DateTime date1 = new DateTime(2023, 4, 6);
//DateTime date2 = new DateTime(2023, 4, 7);
//int result = DateTime.Compare(date1, date2);