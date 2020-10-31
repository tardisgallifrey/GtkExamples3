using System;

namespace PropertyRegistration
{
    public class TestObject : GLib.Object
    {
        public TestObject() : base()
        {



        }

        int my_int;
        [GLib.Property("my_int")]
        public int MyInt
        {
            get { return my_int; }
            set { my_int = value; }
        }

        public void TestInt()
        {

            GLib.Value val = new GLib.Value(42);
            //SetProperty ("my_int", val);
            MyInt = (int)val.Val;

            val.Dispose();
            if (MyInt != 42)
            {
                Console.Error.WriteLine("int Property setter did not run.");
                Environment.Exit(1);
            }

            GLib.Value val2 = new GLib.Value(0);
            val2.Val = (int) val.Val;

            if ((int)val2.Val != 42)
            {
                Console.Error.WriteLine("int Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("int succeeded.");
        }
    }
}