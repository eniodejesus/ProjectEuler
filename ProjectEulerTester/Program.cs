using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ProjectEuler;

namespace ProjectEulerTester
{
    class Program
    {
        static void Main(string[] args)
        {

            ProjectEuler.Problems Ejercicio = new Problems();
            Constant Fixed = new Constant();

            DateTime time;

            time = DateTime.Now;
            Console.WriteLine("Problem 1: {0}", Ejercicio.Problem1(1000));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 2: {0}", Ejercicio.Problem2(4000000));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 3: {0}", Ejercicio.Problem3(600851475143));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 4: {0}", Ejercicio.Problem4(100, 1000));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 5: {0}", Ejercicio.Problem5(20));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 6: {0}", Ejercicio.Problem6(100));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 7: {0}", Ejercicio.Problem7(10001));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 8: {0}", Ejercicio.Problem8(Fixed.Problem8String, 13));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 9: {0}", Ejercicio.Problem9(1000));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 10: {0}", Ejercicio.Problem10(2000000));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 11: {0}", Ejercicio.Problem11(Fixed.buildArrayProblem11()));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            time = DateTime.Now;
            Console.WriteLine("Problem 12: {0}", Ejercicio.Problem12(500));
            Console.WriteLine("Time: {0}", (DateTime.Now - time).Milliseconds);

            Console.ReadKey();
        }
    }
}