using System;
using System.Threading;
using System.Diagnostics;

namespace CairoPngSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CairoPng ();
		    int iterations = 100;

		    for (int loop = 0; loop < 10; loop++) 
            {
			    Stopwatch stop_watch = new Stopwatch ();
			    stop_watch.Start ();
			    Console.Write ("Starting iterations, {0} bytes used...\t", Process.GetCurrentProcess().PrivateMemorySize64);
			
                    for (int i = 0; i < iterations; i++) 
                    {
				        app.CreatePng ();
			        }

			    stop_watch.Stop ();
			    Console.WriteLine ("Created {0} PNG files in {1}ms", iterations, stop_watch.ElapsedMilliseconds);
			    Thread.Sleep (1000);     //Uses System.Threading.Thread
		    }
        }
    }
}
