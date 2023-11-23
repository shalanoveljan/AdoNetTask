
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
CategoryService categoryService = new();


Console.WriteLine("1.Create Product");
Console.WriteLine("2.ShowAll Product");
Console.WriteLine("3.Delete Product");
Console.WriteLine("4.Get Product");
Console.WriteLine("5.Update Product");
Console.WriteLine("6.Create Category");
Console.WriteLine("7.ShowAll Category");
Console.WriteLine("8.Delete Category");
Console.WriteLine("9.Get Category");
Console.WriteLine("10.Update Category");
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
        case "5":
            productService.Update();
            break;
            case "6":
                categoryService.Create();
            break;
            case "7":
                categoryService.ShowAll();
            break;
        case "8":
            categoryService.Delete();
            break;
        case "9":
            categoryService.GetProductById();
            break;
        case "10":
            categoryService.Update();
            break;
        default:
            Console.WriteLine("Add valid option");
            break;
    }

    Console.WriteLine("1.Create Product");
    Console.WriteLine("2.ShowAll Product");
    Console.WriteLine("3.Delete Product");
    Console.WriteLine("4.Get Product");
    Console.WriteLine("5.Update Product");
    Console.WriteLine("6.Create Category");
    Console.WriteLine("7.ShowAll Category");
    Console.WriteLine("8.Delete Category");
    Console.WriteLine("9.Get Category");
    Console.WriteLine("10.Update Category");
    Console.WriteLine("0.Close");

    request = Console.ReadLine();
}
