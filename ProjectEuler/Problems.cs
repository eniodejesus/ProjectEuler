using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ProjectEuler
{
    public class Problems
    {
        int[,] Problem11Grid;
 
        Int64 NextFibonacciNumber(Int64 n1, Int64 n2)
        {
            return n1 + n2;
        }
 
        Int64 DecomposeNumberInPrimeFactors(Int64 Number)
        {
 
            List<Int64> PrimeNumber = new List<Int64>();
            PrimeNumber.Add(2);
 
            while (Number > 1)
            {
                Number = GetNumberFromDiv(Number, PrimeNumber.LastOrDefault());
                PrimeNumber.Add(GetNextPrimeNumber(PrimeNumber));
            }
 
            PrimeNumber.Remove(PrimeNumber.LastOrDefault());
 
            return PrimeNumber.LastOrDefault();
        }
 
        Int64 GetNumberFromDiv(Int64 Upper, Int64 Lower)
        {
            while (Upper % Lower == 0)
            {
                Upper = Upper / Lower;
            }
            return Upper;
        }
 
        Int64 GetNextPrimeNumber(List<Int64> PrimeList)
        {
            Int64 currentPrime;
            Int64 testPrime = 0;
            bool pass = false;
 
            currentPrime = PrimeList.LastOrDefault();
            
            while (!pass)
            {
                if (currentPrime == 2)
                    testPrime = currentPrime + 1;
                else
                    testPrime = currentPrime + 2;
 
                pass = true;
                foreach (Int64 Prime in PrimeList)
                {
                    if (Prime > Math.Sqrt(testPrime))
                        break;
                    if (testPrime % Prime == 0)
                    { pass = false; currentPrime = testPrime; break; }
                }
            }
            return testPrime;
 
        }
 
        bool IsExactForAllNumbers(Int64 Number, Int64 Max)
        {
            while (Max > 1)
            {
                if (Number % Max != 0)
                    return false;
                Max -= 1;
            }
            return true;
        }
 
        bool isPalindrome(Int64 Number)
        {
            string numero = Number.ToString();
 
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] != numero[numero.Length - i - 1])
                    return false;
            }
            return true;
 
                
        }
 
        Int64 GetSquareNumber(Int64 Number)
        {
            return Number * Number;
        }
 
        Int64 GridDown(int X, int Y)
        {
            if (X > 16) return 0;
            Int64 Product = 1;
            for (int i = 0; i < 4; i++)
			{
                Product *= Problem11Grid[X + i, Y];
            }
            return Product;
        }
        Int64 GridRigth(int X, int Y)
        {
            if (Y > 16) return 0;
            Int64 Product = 1;
            for (int i = 0; i < 4; i++)
            {
                Product *= Problem11Grid[X, Y + i];
            }
            return Product;

        }
        Int64 GridDiagonal(int X, int Y)
        {
            if (X > 16 || Y > 16) return 0;
            Int64 Product = 1;
            for (int i = 0; i < 4; i++)
            {
                Product *= Problem11Grid[X + i, Y + i];
            }
            return Product;
        }
        Int64 GridDiagonalBack(int X,int Y)
        {
            if (X > 16 || Y < 3) return 0;
            Int64 Product = 1;
            for (int i = 0; i < 4; i++)
            {
                Product *= Problem11Grid[X + i, Y - i];
            }
            return Product;
        }
 
        Int64 DivisorAmount(Int64 Number)
        {
            Int64 count = 2;
            Int64 Divisors = 2;
            while (count < Math.Sqrt(Number))
            {
                if (Number % count == 0)
                    Divisors++;
                count++;
            }
            return Divisors*2;
        }

        string GetSum(string Sum,string Digit)
        {
            int count = 0;
            int sum = 0;
            string returnValue = "";
            string returnValueHelp = "";
            string rest = "0";
            foreach (char SumDigit in Sum.Reverse())
            {
                count++;

                if (count == 1)
                {
                    sum = int.Parse(SumDigit.ToString()) + int.Parse(Digit);
                    returnValue = returnValue + (sum % 10).ToString();
                    rest = (sum / 10).ToString();
                }
                else if (rest != "0")
                {
                    sum = int.Parse(SumDigit.ToString()) + int.Parse(rest);
                    returnValue = returnValue + (sum % 10).ToString();
                    rest = (sum / 10).ToString();
                }
                else
                {
                    returnValue = returnValue + SumDigit.ToString();
                }
            }

            if (rest != "0")
                returnValue = returnValue + rest;

            foreach (char item in returnValue.Reverse())
            {
                if (returnValueHelp == "")
                    returnValueHelp = (int.Parse(item.ToString()) * 10).ToString();
                else
                    returnValueHelp = ((int.Parse(returnValueHelp) + int.Parse(item.ToString())) * 10).ToString();
            }

            return returnValueHelp.Substring(0,returnValueHelp.Length - 1);
        }

        string GetSum2Numbers(string N1, string N2)
        {
            int max = N1.Length;
            if (N2.Length > max)
                max = N2.Length;

            string Digit = "";
            int sum = 0;
            int Rest = 0;
            int num = 0;
            for (int i = 1; i <= max; i++)
            {
                int num1 = 0;
                int num2 = 0;
                if (N1.Length >= i)
                    num1 = int.Parse(N1[N1.Length-i].ToString());
                if (N2.Length >= i)
                    num2 = int.Parse(N2[N2.Length-i].ToString());

                sum = num1 + num2 + Rest;
                num = (sum % 10);
                Rest = (sum / 10);

                Digit += num.ToString();

            }
            if (Rest != 0)
                Digit += Rest.ToString();
            return RevertString(Digit.ToString());
        }
        private string RevertString(string Num)
        {
            string ret = "";
            for (int i = 0; i < Num.Length; i++)
			{
                ret = Num[i] + ret;
			}
            return ret;
	{
		 
	}
        }

        public Int64 Problem1(Int64 topNumber)
        {
            Int64 sum=0;
            for (int i = 0; i < topNumber; i++)
			{
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
			}
            return sum;
        }
 
        public Int64 Problem2(Int64 topNumber)
        {
            Int64 n1 = 0;
            Int64 n2 = 1;
            Int64 temp = NextFibonacciNumber(n1, n2);
            Int64 sum = 0;
 
            while (temp <= topNumber)
            {
                if (temp % 2 == 0)
                    sum += temp;
 
                n1 = n2;
                n2 = temp;
                temp = NextFibonacciNumber(n1, n2);
            }
 
            return sum;
 
        }
 
        public Int64 Problem3(Int64 Number)
        {
            return DecomposeNumberInPrimeFactors(Number);
        }
 
        public Int64 Problem4(Int64 Min , Int64 Max)
        {
            List<Int64> Palin = new List<Int64>();
            Int64 result;
            for (Int64 i = Min; i < Max; i++)
            {
                for (Int64 j = Min; j < Max; j++)
                {
                    result = i * j;
                    if (isPalindrome(result))
                        Palin.Add(result);
                }
            }
            return Palin.Max();
        }
 
        public Int64 Problem5(Int64 Max)
        {
            Int64 Number = Max;
            while (!IsExactForAllNumbers(Number,Max))
            {
                Number += Max;
            }
            return Number;
        }
 
        public Int64 Problem6(Int64 TopNumber)
        {
            Int64 sumOfSquare = 0;
            Int64 squareOfSum = 0;
 
            for (Int64 i = 1; i <= TopNumber; i++)
            {
                sumOfSquare += GetSquareNumber(i);
                squareOfSum += i;
            }
            squareOfSum = GetSquareNumber(squareOfSum);
 
            return  squareOfSum - sumOfSquare;
        }
 
        public Int64 Problem7(Int64 PrimeAmount)
        {
            List<Int64> PrimeNumber = new List<Int64>();
            PrimeNumber.Add(2);
            for (Int64 i = 1; i < PrimeAmount; i++)
            {
                PrimeNumber.Add(GetNextPrimeNumber(PrimeNumber));
            }
            return PrimeNumber.LastOrDefault();
        }
 
        public Int64 Problem8(string Digits, Int64 places)
        {
            Int64 Max = 0;
            Int64 CurrentValue = 0;
            int totalMoves = 0;
            for (int i = 0; i <= Digits.Length-places-1; i++)
            {
                CurrentValue = 1;
                for (int j = 0; j < places; j++)
                {
                    CurrentValue *= Int64.Parse(Digits[totalMoves+j].ToString());
                }
                totalMoves++;
                Max = Math.Max(CurrentValue, Max);
            }
            return Max;
        }
 
        public Int64 Problem9(Int64 MaxSum)
        {
            for (Int64 x = 0; x < MaxSum; x++)
            {
                for (Int64 y = x+1; y < MaxSum; y++)
                {
                    for (Int64 z = y+1; z < MaxSum; z++)
                    {
                        if (x + y + z == MaxSum)
                        {
                            if (GetSquareNumber(x) + GetSquareNumber(y) == GetSquareNumber(z))
                                return x * y * z;
                        }
                    }
                }
            }
            return 0;
        }
 
        public Int64 Problem10(Int64 MaxPrime)
        {
            List<Int64> PrimeNumber = new List<Int64>();
            PrimeNumber.Add(2);
            while(PrimeNumber.LastOrDefault() < MaxPrime)
            {
                PrimeNumber.Add(GetNextPrimeNumber(PrimeNumber));
            }
            PrimeNumber.Remove(PrimeNumber.LastOrDefault());
            return PrimeNumber.Sum();
            
        }
 
        public Int64 Problem11(int[,] Array)
        {
            Problem11Grid = Array;
            Int64 Max = 0;
            Int64 Tester = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Tester = Math.Max(Math.Max(GridDown(i, j), GridRigth(i, j)), 
                        Math.Max(GridDiagonal(i, j), GridDiagonalBack(i, j)));
                    Max = Math.Max(Max, Tester);
                    
                }
            }
            return Max;
        }

        public Int64 Problem12(Int64 AmountOfDivisors)
        {
            Int64 count = 1;
            Int64 sum = 0;
            List<Int64> triangleNumbers = new List<Int64>();
            while (true)
            {
                sum = triangleNumbers.LastOrDefault() + count;
                triangleNumbers.Add(sum);
                if (DivisorAmount(triangleNumbers.LastOrDefault()) >= AmountOfDivisors)
                    return triangleNumbers.LastOrDefault();
                ++count;
            }
        }

        public string Problem13(string [] BigNumber)
        {
            string sum = "0";
            int count = 0;

            for (int i = 0; i < BigNumber.Count(); i++)
			{
                sum = GetSum2Numbers(sum, BigNumber[i].ToString());
			}

            return sum.Substring(0, 10);
        }
    }
}