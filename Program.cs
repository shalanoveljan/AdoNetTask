
using Core.Models;
using Services.Implementations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Net.Http.Headers;


//ProductService productService = new();

//Console.WriteLine("1.add product");
//Console.WriteLine("2.show product");
//Console.WriteLine("3.Exit");

//string request=Console.ReadLine();

//while (request != "3")
//{
//	switch (request)
//	{
//		case "1":
//			productService.Add();
//			break;
//			case "2":
//            productService.ShowAll();
//            break;
//		default:
//			break;
//	}

//    Console.WriteLine("1.add product");
//    Console.WriteLine("2.show product");
//    Console.WriteLine("3.Exit");

//    request = Console.ReadLine();
//}

ProductService productService = new();


Console.WriteLine("1.create");
Console.WriteLine("2.ShowAll");
Console.WriteLine("3.Delete");
Console.WriteLine("4.Get");
Console.WriteLine("0.Close");

string request = Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
            productService.Create();
            break;
        case "2":
            productService.ShowAll();
            break;
            case"3":
                productService.Delete();
            break;
            case "4":
                productService.GetProductById();
            break;
        default:
            Console.WriteLine("Add valid option");
            break;
    }

    Console.WriteLine("1.create");
    Console.WriteLine("2.ShowAll");
    Console.WriteLine("3.Delete");
    Console.WriteLine("4.Get");
    Console.WriteLine("0.Close");

    request = Console.ReadLine();
}
