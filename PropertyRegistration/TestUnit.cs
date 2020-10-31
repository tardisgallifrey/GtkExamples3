using System;
using System.Runtime.InteropServices;
using Gtk;

namespace PropertyRegistration
{
    public class TestUnit
    {
        public void TestInt()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value(42);

            myobject.MyInt = (int)val.Val;

            val.Dispose();
            if (myobject.MyInt != 42)
            {
                Console.Error.WriteLine("int Property setter did not run.");
                Environment.Exit(1);
            }

            GLib.Value val2 = new GLib.Value(0);
            val2.Val = myobject.MyInt;

            if ((int)val2.Val != 42)
            {
                Console.Error.WriteLine("int Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("int succeeded.");
        }

        
        public void TestUInt()
        {

            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value((uint)42);
            myobject.MyUInt = (uint) val.Val;
            
            val.Dispose();
            if (myobject.MyUInt != 42)
            {
                Console.Error.WriteLine("uint Property setter did not run.");
                Environment.Exit(1);
            }

            GLib.Value val2 = new GLib.Value((uint)0);
            val2.Val = myobject.MyUInt;

            if ((uint)val2.Val != 42)
            {
                Console.Error.WriteLine("uint Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("uint succeeded.");
        }



        public void TestLong()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value((long)42);
            myobject.MyLong = (long) val.Val;

            val.Dispose();
            if (myobject.MyLong != 42)
            {
                Console.Error.WriteLine("long Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value((long) 0);
            val2.Val = myobject.MyLong;

            if ((long)val2.Val != 42)
            {
                Console.Error.WriteLine("long Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("long succeeded.");
        }



        public void TestULong()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value((ulong)42);
            myobject.MyULong = (ulong) val.Val;

            val.Dispose();
            if (myobject.MyULong != 42)
            {
                Console.Error.WriteLine("ulong Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value((ulong) 0);
            val2.Val = myobject.MyULong;

            if ((ulong)val2.Val != 42)
            {
                Console.Error.WriteLine("ulong Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("ulong succeeded.");
        }


        public void TestByte()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value((byte)42);
            myobject.MyByte = (byte) val.Val;

            val.Dispose();
            if (myobject.MyByte != 42)
            {
                Console.Error.WriteLine("byte Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value((byte) 0);
            val2.Val = myobject.MyByte;

            if ((byte)val2.Val != 42)
            {
                Console.Error.WriteLine("byte Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("byte succeeded.");
        }



        public void TestSByte()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value((sbyte)42);
            myobject.MySByte = (sbyte) val.Val;

            val.Dispose();
            if (myobject.MySByte != 42)
            {
                Console.Error.WriteLine("sbyte Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value((sbyte) 0);
            val2.Val = myobject.MySByte;

            if ((sbyte)val2.Val != 42)
            {
                Console.Error.WriteLine("sbyte Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("sbyte succeeded.");
        }



        public void TestBool()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value(true);
            myobject.MyBool = (bool) val.Val;

            val.Dispose();
            if (!myobject.MyBool)
            {
                Console.Error.WriteLine("bool Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value(false);
            val2.Val = myobject.MyBool;

            if (!((bool)val2.Val))
            {
                Console.Error.WriteLine("bool Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("bool succeeded.");
        }



        public void TestFloat()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value(42.0f);
            myobject.MyFloat = (float) val.Val;

            val.Dispose();
            if (myobject.MyFloat != 42.0f)
            {
                Console.Error.WriteLine("float Property setter did not run.");
                Environment.Exit(1);
            }

            GLib.Value val2 = new GLib.Value(0.0f);
            val2.Val = myobject.MyFloat;

            if ((float)val2.Val != 42.0f)
            {
                Console.Error.WriteLine("float Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("float succeeded.");
        }



        public void TestDouble()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value(42.0);
            myobject.MyDouble = (double) val.Val;

            val.Dispose();
            if (myobject.MyDouble != 42.0)
            {
                Console.Error.WriteLine("double Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value(0.0);
            val2.Val = myobject.MyDouble;

            if ((double)val2.Val != 42.0)
            {
                Console.Error.WriteLine("double Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("double succeeded.");
        }



        public void TestString()
        {
            TestObject myobject = new TestObject();
            GLib.Value val = new GLib.Value("42");
            myobject.MyString = (string) val.Val;

            val.Dispose();
            if (myobject.MyString != "42")
            {
                Console.Error.WriteLine("string Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value("aa");
            val2.Val = myobject.MyString;

            if ((string)val2.Val != "42")
            {
                Console.Error.WriteLine("string Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("string succeeded.");
        }




        public void TestIntPtr()
        {
            TestObject myobject = new TestObject();
            IntPtr ptr = Marshal.AllocHGlobal(4);
            Console.WriteLine(ptr);
            GLib.Value val = new GLib.Value(ptr);
            myobject.MyIntPtr = (IntPtr) val.Val;

            val.Dispose();
            if (myobject.MyIntPtr != ptr)
            {
                Console.Error.WriteLine("IntPtr Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value(IntPtr.Zero);
            Console.WriteLine(val2.Val);

            val2.Val = myobject.MyIntPtr;
            Console.WriteLine((IntPtr) val2.Val);

            if (!val2.Val.Equals(ptr))
            {
                Console.Error.WriteLine("IntPtr Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Marshal.FreeHGlobal(ptr);
            Console.WriteLine("IntPtr succeeded.");
        }



        public void TestBoxed()
        {
            TestObject myobject = new TestObject();
            Gdk.Color color = new Gdk.Color(0, 0, 0);
            GLib.Value val = (GLib.Value)color;
            myobject.MyBoxed = (Gdk.Color) val.Val;

            val.Dispose();
            if (!myobject.MyBoxed.Equals(color))
            {
                Console.Error.WriteLine("boxed Property setter did not run.");
                Environment.Exit(1);
            }

            Gdk.Color color2 = new Gdk.Color( 9, 9, 9);
            GLib.Value val2 = (GLib.Value)color2;
            if (color.Equals((Gdk.Color)val2.Val))
            {
                Console.Error.WriteLine("boxed Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("boxed succeeded.");
        }


        public void TestGObject()
        {
            TestObject myobject = new TestObject();
            Gtk.Window win = new Gtk.Window("test");
            GLib.Value val = new GLib.Value(win);
            myobject.MyObject = (Window) val.Val;

            val.Dispose();
            if (myobject.MyObject != win)
            {
                Console.Error.WriteLine("GObject Property setter did not run.");
                Environment.Exit(1);
            }
            GLib.Value val2 = new GLib.Value(win);
            val2.Val = myobject.MyObject;
            
            if ((GLib.Object)val2.Val != win)
            {
                Console.Error.WriteLine("GObject Property set/get roundtrip failed.");
                Environment.Exit(1);
            }
            Console.WriteLine("GObject succeeded.");
        }

    }
}