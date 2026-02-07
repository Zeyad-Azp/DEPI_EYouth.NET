using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace DEPI_Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(); 
            // Console.ReadLine(); 
            // Console.Write("");
            #region Part_1
            #region Program_1
            try
            {
                bool flag, flag01;
                int x, y;
                do
                {
                    Console.Write("Enter the first number: ");
                    flag = int.TryParse(Console.ReadLine(), out x);
                    Console.Write("Enter the second number: ");
                    flag01 = int.TryParse(Console.ReadLine(), out y);
                }
                while (!(flag && flag01));
                Console.WriteLine($"{x / y}");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("operation completed");
            }
            #endregion
            #region Question_1
            //Question: What is the purpose of the finally block?
            /*
             * to execute a block of code regardless of success or failure (regardless there is an exeption or not)
             */
            #endregion

            #region Program_2
            //public static void TestDefensiveCode()

            int X, Y, Z;
            bool flag02;
            do
            {
                Console.WriteLine("Enter first Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
            do
            {
                Console.WriteLine("Enter Second Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out Y) || Y < 1);

            Z = X / Y;

            //int[] arr = { 1, 2, 3 };
            //if (arr?.Length > 69)
            //    arr[69] = 90;

            #endregion
            #region Question_2
            //How does int.TryParse() improve program robustness compared to 
            //int.Parse() ?
            /*
             * because int.TryParse() can handle the null reference exeption and invalid format exeption , because it 
             * returns a boolean value represents the status of casting is true or false
             */
            #endregion

            #region Program_3
            int? nullableInt = null;
            Console.WriteLine(nullableInt ?? default);
            // .HasValue prperty checks if the variable has a value or it is null and returns a boolean value
            if (nullableInt.HasValue)
                // it returns the value of the variable if it has a value,
                // if the variable is null it will throw an InvalidOperationException
                Console.WriteLine(nullableInt.Value);
            else
                Console.WriteLine("the variable is null!");
            #endregion
            #region Question_3
            //Question: What exception occurs when trying to access Value on a null Nullable<T>? 

            //// if the variable is null it will throw an InvalidOperationException
            #endregion

            #region Program_4
            int[] arr = { 1, 2, 3, 4, 5 };
            //using try catch
            try
            {
                Console.WriteLine(arr[6]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // defensive code
            int input; bool flag03;
            do
            {
                Console.WriteLine("Enter a number to access the array: ");
                flag03 = int.TryParse(Console.ReadLine(), out input);
            }
            while (!flag03 || input < 0 || input > arr.Length - 1);
            Console.WriteLine(arr[input]);
            #endregion
            #region Question_4
            //Question: Why is it necessary to check array bounds before accessing elements?

            // to avoid the IndexOutOfRange Exception
            #endregion

            #region Program_5
            int[,] arr01 = new int[3, 3];
            int rowSum = 0, colSum = 0;

            // getting the input
            for (int i = 0; i < arr01.GetLength(0); i++)
            {
                for (int j = 0; j < arr01.GetLength(1);)
                {
                    Console.Write($"Enter a number for row => {i} & column => {j}: ");
                    bool flag04 = int.TryParse(Console.ReadLine(), out arr01[i, j]);
                    if (!flag04)
                    {
                        Console.WriteLine("Invalid Number!");
                    }
                    else
                        j++;
                }
            }
            // summation
            for (int i = 0; i < arr01.GetLength(0); i++)
            {
                for (int j = 0; j < arr01.GetLength(1); j++)
                {
                    // row summation
                    rowSum += arr01[i, j];
                    // col summation
                    colSum += arr01[j, i];
                }
                Console.WriteLine($"the summation of row {i + 1} = {rowSum}");
                Console.WriteLine($"the summation of col {i + 1} = {colSum}");
                rowSum = 0;
                colSum = 0;
            }
            #endregion
            #region Question_5
            //Question: How is the GetLength(dimension) method used in multi-dimensional arrays? 

            // it used to get the length for a specific dimentional in a multi dimentioal array
            #endregion

            #region Program_6
            int[][] arr02 = new int[3][];
            arr02[0] = new int[2];
            arr02[1] = new int[3];
            arr02[2] = new int[4];

            //read inouts
            for (int i = 0; i < arr02.Length; i++)
            {
                for (int j = 0; j < arr02[i].Length;)
                {
                    Console.Write($"Enter a number for row => {i} & column => {j}: ");
                    bool flag05 = int.TryParse(Console.ReadLine(), out arr02[i][j]);
                    if (!flag05)
                    {
                        Console.WriteLine("Invalid Number!");
                    }
                    else
                        j++;
                }
            }
            //print
            for (int i = 0; i < arr02.Length; i++)
            {
                for (int j = 0; j < arr02[i].Length;)
                {
                    Console.Write($"{arr02[i][j]} ");
                }
                Console.WriteLine();
            }
            #endregion
            #region Question_6
            //Question: How does the memory allocation differ between jagged arrays and rectangular 
            //arrays ?

            /*
             * the jagged arrays are array of arrays , so each inner array can have a different length and they are stored in different memory locations
             * the rectangular arrays are stored in a contiguous block of memory and all elements are of the same type and size
             * the jagged arrays takes memory less than the rectangular arrays because the jagged arrays can have different lengths for each inner array 
             * and it can save memory by not allocating space for unused elements like in rectangular arrays
             */
            #endregion
#nullable enable
            #region Program_7
            string? text;
            do
            {
                Console.WriteLine("Enter a text: ");
                text = Console.ReadLine()!;
            }
            while (text == null);
            #endregion
            #region Question_7
            //Question: What is the purpose of nullable reference types in C#?
            /*
             * to determine whether a reference type variable can hold a null value or it required to have a non-null value
             * in the class prperties and method parameters to indicate that they can accept null values or not
             */
            #endregion

            #region Program_8
            // boxing
            int number = 10;
            object obj = number;

            // unboxing
            try
            {
                object obj2 = 20.1;
                double number2 = (double)obj2;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
            #region Question_8
            //Question: What is the performance impact of boxing and unboxing in C#? 
            /*
             * the boxing & unboxing operations have a bad performance impact because they make an memory overhead while
             * coping the value from stack to heap which is the boxing operation and 
             * while coping the value from heap to stack which is the unboxing operation & you may get an InvalidCastException if you try to unbox to a different type than the original value type
             */
            #endregion

            #region Program_9
            int x01, Y01;
            SumAndMultiply(out x01, out Y01);
            #endregion
            #region Question_9
            //Question: Why must out parameters be initialized inside the method? 
            /*
             * because the out parameters are used to return multiple values from a method and they must be assigned a value before the method ends
             * and the compiler allows us to use the out parameters without initialization before calling the function
             * so you must initiakize them in the function body to avoid the null reference exception
             */
            #endregion

            #region Program_10
            PrintMessage("hello");
            PrintMessage("hello22", 3);
            PrintMessage(message: "named parameter", count: 2);
            #endregion
            #region Question_10
            //Question: Why must optional parameters always appear at the end of a method's parameter 
            //list ?
            /*
             * because the optional parameters are used to set default values for parameters that cab be not passed when calling the method
             * and if you put an optional parameter before a required parameter it will cause a compilation error because the compiler will not be able to determine which value is for which parameter
             */
            #endregion

            #region Program_11
            int?[] arr03 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr03?.Length);//5
            Console.WriteLine(arr03?.Min());//1
            #endregion
            #region Question_11
            //Question: How does the null propagation operator prevent NullReferenceException?
            /*
             * it allows you to safely access members of an object that may be null without a NullReferenceException 
             * because it checks if the object is null or not before accessing its properties
             * if it is null it will return null
             * else it will return the value of the property
             */
            #endregion

            #region Program_12
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("saturday");
                    break;
                case 2:
                    Console.WriteLine("sunday");
                    break;
                case 3:
                    Console.WriteLine("monday");
                    break;
                case 4:
                    Console.WriteLine("tuesday");
                    break;
                case 5:
                    Console.WriteLine("wednesday");
                    break;
                case 6:
                    Console.WriteLine("thursday");
                    break;
                case 7:
                    Console.WriteLine("friday");
                    break;
                default:
                    break;
            }
            #endregion
            #region Question_12
            //Question: When is a switch expression preferred over a traditional if statement?
            /*
             * when you do not have multiple conditions to check and you want to improve the readability of your code
             * or you hava a value and checks its status like this case
             * and also the switch statment can be considered a jump table which is more efficient than if in some cases
             */
            #endregion

            #region Progrma_13
            int[] arr04 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumArray(arr04));//using array
            Console.WriteLine(SumArray(1, 2, 3, 4, 5));//using individual numbers
            #endregion
            #region Question_13
            // What are the limitations of the params keyword in method definitions? 
            /*
             * it must be the last parameter in the method definition
             * it can only be used with one parameter in the method definition
             * it can only be used with array types and it will not work with other types like lists or other collections
             * the compiler can fail to determine which overload to call if you have multiple overloads with params parameters 
             */
            #endregion
            #endregion
            #region Part_2
            #region Program_1
            int input01;
            do 
            { 
                Console.WriteLine("Enter a positive number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out input01) || input01 < 0);
            for (int i = 1; i <= input01; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Program_2
            int input02;
            do
            {
                Console.WriteLine("Enter an integer number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out input02));
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * input02);
            }
            #endregion

            #region Program_3
            int input03;
            do
            {
                Console.WriteLine("Enter a positive number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out input03) || input03 < 0);
            for (int i = 1; i <= input03; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            #endregion

            #region Program_4
            int input04, input05, mul = 1;
            do
            {
                Console.WriteLine("Enter a number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out input04));
            do
            {
                Console.WriteLine("Enter a number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out input05));
            for (int i = 1; i <= input05; i++)
            {
                mul *= input04;
            }
            Console.WriteLine($"{input04} power {input05} = {mul}");
            #endregion

            #region Program_5
            string input06;
            do
            {
                Console.WriteLine("Enter a string: ");
                input06 = Console.ReadLine()!;
            }
            while (input06 == null);
            for (int i = input06.Length - 1; i >= 0; i--)
            {
                Console.Write(input06[i]);
            }
            #endregion

            #region Program_6
            int input07;
            do
            {
                Console.WriteLine("Enter a number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out input07));
            string stringNum = input07.ToString();
            for (int i = stringNum.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(stringNum[i]);
            }
            #endregion

            #region Program_7
            int n;
            do 
            {
                Console.WriteLine("Enter the number of elements number: ");
            }
            while (!int.TryParse(Console.ReadLine() ,out n));
            int[] arr05 = new int[n];
            int[] results = new int[n];
            
            for(int i = 0 ; i < n; i++)
            {
                do
                {
                    Console.WriteLine($"Enter number {i + 1} : ");
                }
                while (!int.TryParse(Console.ReadLine(), out arr05[i]));
            }

            for (int i = 0; i < n; i++)
            {
                results[i] = Array.LastIndexOf(arr05, arr05[i]) - Array.IndexOf(arr05, arr05[i]) - 1;
            }
            Console.WriteLine(results.Max() == -1 ? 0 : results.Max());
            #endregion

            #region Program_8
            string[]input08 = Console.ReadLine().Split();
            for(int i = input08.Length - 1; i >= 0; i--)
            {
                Console.Write($"{input08[i]} ");
            }
            #endregion
            #endregion
        }
        #region SumAndMultiply
        public static void SumAndMultiply(out int x01, out int y01)
        {
            do
            {
                Console.Write("Enter the first number: ");
            }
            while (!int.TryParse(Console.ReadLine()!, out x01));

            do
            {
                Console.Write("Enter the second number: ");
            }
            while (!int.TryParse(Console.ReadLine()!, out y01));

            Console.WriteLine($"summation: {x01 + y01}");
            Console.WriteLine($"product: {x01 * y01}");

        }
        #endregion
        #region PrintMessage
        public static void PrintMessage(string message, int count = 5)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
        #endregion
        #region SumArray
        public static int SumArray(params int[] nums)
        {
            int summation = 0;
            foreach (int num in nums)
            {
                summation += num;
            }
            return summation;
        }
        #endregion

    }
    
}






    


