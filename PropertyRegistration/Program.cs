using System;
using GLib;


namespace PropertyRegistration
{
    class Program
    {

        static int Main(string[] args)
        {
            GType.Init();
            TestUnit obj = new TestUnit();
            obj.TestInt();
            obj.TestUInt();
            obj.TestLong();
            obj.TestULong();
            obj.TestFloat();
            obj.TestDouble();
            obj.TestBool();
            obj.TestBoxed();
            obj.TestByte();
            obj.TestSByte();
            obj.TestIntPtr();
            obj.TestString();
            obj.TestGObject();
            Console.WriteLine("All properties succeeded.");
            return 0;
        }

       
    }
}

