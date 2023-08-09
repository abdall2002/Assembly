// See https://aka.ms/new-console-template for more information
using ConsoleApp3;
using DempLib;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

//Console.WriteLine("Hello, World!");

/* Function Equals() */
//Employee e1 = new Employee() { Id = 100, Name = "Abdallah", Salary = 3000m, Department = "CS" };
//Employee e2 = new Employee() { Id = 100, Name = "Abdallah", Salary = 3000m, Department = "CS" };
//Employee e3 = e1;
//Console.WriteLine(e1 == e2);                 // -> print False;  references
//Console.WriteLine(e1 == e3);                 // -> print True;
//Console.WriteLine(e1.Equals(e2));            // -> print True;


//var s1 = "Hello";
//var s2 = "Hello";
//Console.WriteLine(s1 == s2);               // -> print True, Compare Content s1,s2;

/* Function GetHashCode() */

//Console.WriteLine(7.GetHashCode());          // -> print 7;

/////////////////////////////////////////////////////////

//var ints = new FiveIntegers(1, 2, 3, 4, 5);
//foreach (var i in ints)
//{
//  Console.WriteLine(i);
//}


//////////////////////////////////////////////////////////

/* IComparable */
//var temps = new List<Tempreture>();
//Random rnd = new Random();
//for (int i = 0; i < 100; i++)
//{
//  temps.Add(new Tempreture(rnd.Next(-30, 50)));
//}

//temps.Sort();
//foreach (var item in temps)
//{
//  Console.WriteLine(item.Value);
//}


//////////////////////////////////////////////////////////

/* XML Documentation */

//do
//{
//Console.Write("First Name: ");
//var fname = Console.ReadLine();

//  Console.Write("Last Name: ");
//    var lname = Console.ReadLine();

//Console.Write("Hired Date: ");
//DateTime? hireDate = null;
//if(DateTime.TryParse(Console.ReadLine(), out DateTime hDate))
//{
//  hireDate = hDate;   
//}
//var empId = Generator.GenerateId(fname, lname, hireDate);
//var randomPassword = Generator.GenerateRandomPassword(8);

//  Console.WriteLine($"{{\n Id: {empId},\n FName: {fname},\n LName: {lname},\n hire date: {hireDate},\n Password: {randomPassword}\n }}"); ;


//} while (1 == 1);


///////////////////////////////////////////////////////////////////

/* Assembly */
//var type = typeof(Employee);
//var assembly = type.Assembly;
//Console.WriteLine(assembly.FullName);
//var assembly = Assembly.GetExecutingAssembly();
//Console.WriteLine(assembly.FullName);       // -> print ConsoleApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
//Console.WriteLine(typeof(DateTime).Assembly.FullName);   // -> print System.Private.CoreLib, Version=7.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e

//Demo.Trace();

var type = typeof(Program);
var assembly = type.Assembly;
Console.WriteLine($"FullName: {assembly.FullName}");  // -> print ConsoleApp3, Version = 1.0.0.0, Culture = neutral, PublicKeyToken = null
Console.WriteLine($"Location: {assembly.Location}");  // -> print C:\Users\COMPUMARTS\source\repos\ConsoleApp3\ConsoleApp3\bin\Debug\net7.0\ConsoleApp3.dll
var assemblyName = assembly.GetName();
Console.WriteLine($"Name: {assemblyName.Name}");          // -> print "ConsoleApp3"
Console.WriteLine($"Version: {assemblyName.Version}");    // -> print "1.0.0.0"
Console.WriteLine($"Total Key Tokens length: {assemblyName.GetPublicKeyToken().Length}");   // -> print 0, return array of bytes
Console.WriteLine($"Code: {assemblyName.CodeBase}");  // -> print file:///C:/Users/COMPUMARTS/source/repos/ConsoleApp3/ConsoleApp3/bin/Debug/net7.0/ConsoleApp3.dll

