﻿using System;
using RandomWalker2;

namespace ConsoleLauncher
{
   class Program
   {
      private static void Main(string[] args)
      {
         var tests = new Tests();
         tests.Test();
         tests.TearDown();

         Console.WriteLine("Press any key to continue...");
         Console.ReadKey();
      }
   }
}
