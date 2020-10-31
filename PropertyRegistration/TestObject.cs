using System;

namespace PropertyRegistration
{
    public class TestObject : GLib.Object
    {

        int my_int;
        [GLib.Property("my_int")]
        public int MyInt
        {
            get { return my_int; }
            set { my_int = value; }
        }

        uint my_uint;
        [GLib.Property("my_uint")]
        public uint MyUInt
        {
            get { return my_uint; }
            set { my_uint = value; }
        }

        long my_long;
        [GLib.Property("my_long")]
        public long MyLong
        {
            get { return my_long; }
            set { my_long = value; }
        }

        ulong my_ulong;
        [GLib.Property("my_ulong")]
        public ulong MyULong
        {
            get { return my_ulong; }
            set { my_ulong = value; }
        }

        byte my_byte;
        [GLib.Property("my_byte")]
        public byte MyByte
        {
            get { return my_byte; }
            set { my_byte = value; }
        }

        sbyte my_sbyte;
        [GLib.Property("my_sbyte")]
        public sbyte MySByte
        {
            get { return my_sbyte; }
            set { my_sbyte = value; }
        }

        bool my_bool;
        [GLib.Property("my_bool")]
        public bool MyBool
        {
            get { return my_bool; }
            set { my_bool = value; }
        }

        float my_float;
        [GLib.Property("my_float")]
        public float MyFloat
        {
            get { return my_float; }
            set { my_float = value; }
        }

        double my_double;
        [GLib.Property("my_double")]
        public double MyDouble
        {
            get { return my_double; }
            set { my_double = value; }
        }

        string my_string;
        [GLib.Property("my_string")]
        public string MyString
        {
            get { return my_string; }
            set { my_string = value; }
        }

        IntPtr my_intptr;
        [GLib.Property("my_intptr")]
        public IntPtr MyIntPtr
        {
            get { return my_intptr; }
            set { my_intptr = value; }
        }
        Gdk.Color my_boxed;
        [GLib.Property("my_boxed")]
        public Gdk.Color MyBoxed
        {
            get { return my_boxed; }
            set { my_boxed = value; }
        }

        GLib.Object my_object;
        [GLib.Property("my_object")]
        public GLib.Object MyObject
        {
            get { return my_object; }
            set { my_object = value; }
        }
    }
}