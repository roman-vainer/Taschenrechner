using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Taschenrechner {
    internal class Berechnung {
        public static double rechnen(double z1, double z2, char op) {
            return op switch
            {
                '+' => Addition(z1, z2),
                '-' => Substraktion(z1, z2),
                '*' => Multiplikation(z1, z2),
                '/' => Division(z1, z2),
                _ => throw new ArgumentOutOfRangeException(nameof(op), op, "Ugültiger OPerator")
            };
        } 
        private static double Addition(double z1, double z2) {
            return z1 + z2;
        }
        private static double Substraktion(double z1, double z2) {
            return z1 - z2;
        }
        private static double Multiplikation(double z1, double z2) {
            return z1 * z2;
        }
        public static double Division(double z1, double z2) {
            if (z2 != 0) {
                return z1 / z2;
            } else {
                throw new DivideByZeroException();
            }
            
        }
    }
}
