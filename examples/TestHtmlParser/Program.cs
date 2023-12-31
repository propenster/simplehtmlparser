﻿using HtmlParser;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var htmlText =
            @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
</head>
<body>

    <p id=""paragraph1"">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Odit veritatis, assumenda quibusdam et deserunt architecto nulla eligendi quod recusandae vitae doloremque dicta quam? Asperiores, aut? Autem doloribus voluptatum itaque maiores?</p>
    <p id=""paragraph2"">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Odit veritatis, assumenda quibusdam et deseru?</p>
    <p id=""paragraph3"">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Odit veritatis, assumenda quibusdam et deserunt aaque maiores?</p>
    <p id=""paragraph4"">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Odit veritatis, assumenda quibusdam et deserunt architecto nulla eligendi quod recusandae vitae doloremque dicta quam? Asperiores, aut? Autem doloribus voluptatum itaque maiores?</p>
    <p>My name is Faith</p>
    <h2 class=""Header2"">Welcome to HTMLParser C# by propenster</h2>
    <p>
        This is another paragraph... 
        Loaded 'C:\MinGW\bin\libgcc_s_dw2-1.dll'. Symbols loaded.
        Loaded 'C:\MinGW\bin\libstdc++-6.dll'. Symbols loaded.

    </p>

    <div id=""myDiv"">
       <p>Paragraph under div</p>
        <p>Another paragraph under div </p>
    </div>

</body>
</html>";

        var htmlParser = new HTMLParser();
        var htmlDocument = htmlParser.Parse(htmlText);

        //get a P Tag with a particular Attribute...
        IHtmlElement paragraph1 = htmlDocument.FindElement(By.Id("paragraph1"));

        Console.WriteLine("Paragraph1 Text >>> {0}", paragraph1?.Text ?? string.Empty);

        IHtmlElement headerElement = htmlDocument.FindElement(By.ClassName("Header2"));
        Console.WriteLine("Header2 Text >>> {0}", headerElement?.Text);

        //get div...
        IHtmlElement myDiv = htmlDocument.FindElement(By.Id("myDiv"));
        var paragraphsUnderMyDiv = myDiv.FindElements(By.ElementTag("p"));
        Console.WriteLine("There are {0} paragraph tags under DIV myDiv", paragraphsUnderMyDiv.Count());
        




    }
}