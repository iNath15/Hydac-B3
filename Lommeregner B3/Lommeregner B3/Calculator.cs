using System;
using System.Collections.Generic;
using System.Text;

namespace Lommeregner_B3 {
    internal class Calculator {
        public double Add(double a, double b) {
            return a + b;
        }

        public double Subtract(double a, double b) {
            return a - b;
        }

        public double Multiply(double a, double b) {
            return a * b;
        }

        public double Divide(double a, double b) {
            if (b == 0) {
                Console.WriteLine("Cannot divide by 0");
                return 0;
            }
            return a / b;
        }
    }
}
