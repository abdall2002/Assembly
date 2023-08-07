// See https://aka.ms/new-console-template for more information
using CException;
using System.Net;

Console.WriteLine("Hello, World!");

/*Exception Handling*/

var delivary = new Delivery { Id = 1, CustomerName = "Abdallah", Address = "123 Street" }; // -> print these data; 
var service = new DeliveryService();
service.Start(delivary);
Console.WriteLine(delivary);