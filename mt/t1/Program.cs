﻿
using System;
using System.Runtime.InteropServices;

using SQLitePCL;
using SQLitePCL.Ugly;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
			SQLitePCL.Setup.Load("e_sqlite3.dll");

			using (var db = ugly.open(":memory:"))
			{
				var s = db.query_scalar<string>("SELECT sqlite_version()");	
				Console.WriteLine("{0}", s);
			}

            Console.WriteLine("Hello World!");
        }
    }
}