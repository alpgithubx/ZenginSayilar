﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenginSayılar {
    internal class Program {
        static void Main(string[] args) {
            for (int i = 1; i < 1000000; i++) {
                int sum = 0;
                for (int j = 1; j < i; j++) {
                    if (i % j == 0) {
                        sum += j;
                    }
                }
                if (sum > i) {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
