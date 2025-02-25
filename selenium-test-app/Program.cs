﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Hello, World!");

//var service = ChromeDriverService.CreateDefaultService();

//service.Start();

//var driverServiceProcess = (Process) typeof(DriverService).GetField("driverServiceProcess", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(service);

//Console.WriteLine(driverServiceProcess.StartInfo.FileName);

//var options = new ChromeOptions();
//var driver = new ChromeDriver(service, options);

var options = new ChromeOptions();
options.AddArgument("--headless");
var driver = new ChromeDriver(options);
driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

Console.WriteLine("Press any key to exit...");
Console.ReadKey(true);

driver.Dispose();

//service.Dispose();

Console.WriteLine("Bye, World!");