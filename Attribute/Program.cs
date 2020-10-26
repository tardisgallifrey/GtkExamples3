using System;

//This has little to do with Gtk that I can tell.
//But, going to keep it included as it may have value.
//
//Has something to do with setting attributes to include or not include 
//program elements
//https://docs.microsoft.com/en-us/dotnet/api/system.attribute?view=netcore-3.1

//Several example programs use this at the beginning of Windows classes.
//I'll use this when needed.  It does fit.


namespace AttributeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");

            Demo myAttribute = new Demo("My Attribute", @"./Attribute.csproj", "Attribute Group");

            Console.WriteLine(myAttribute.Filename);
        }
    }
}
