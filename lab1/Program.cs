﻿// See https://aka.ms/new-console-template for more information
using ClassLibrary;
Console.WriteLine("Hello, World!");
Console.Write("x: ");
var x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
var y = Convert.ToInt32(Console.ReadLine());
Console.Write("a: ");
var a = Convert.ToInt32(Console.ReadLine());
var ds = new ArithmaticClass();
Console.WriteLine($"#1 {ds.z_func1(x, y, a)}");
Console.WriteLine($"#2 {ds.z_func2(x, y, a)}");