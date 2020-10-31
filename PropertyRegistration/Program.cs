using System;
using GLib;


namespace PropertyRegistration
{
    class Program
    {

        static int Main(string[] args)
        {
            GLib.GType.Init();
            TestObject obj = new TestObject();
            obj.TestInt();
            Console.WriteLine("All properties succeeded.");
            return 0;
        }

    }
}

