using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Linq;

namespace DEPI_Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part_1
            #region Problem_1
            // declare an integer variable x and assign the value 10 to it
            int x = 10;
            // declare an integer variable y and assign the value 20 to it
            int y = 20;
            /*
             * declare an integer variable sum to store the summation of the value of x and y 
             * then print the value of the sum variable
             */
            int sum = x + y;
            Console.WriteLine(sum);
            #endregion

                #region Question_1
                /*
                 * The short cut to comment and uncomment a selected block of code in Visual 
                    Studio is : ctrl + k + c to comment 
                    and ctrl + k + u to uncomment
                 */
                #endregion

                #region Problem_2
                /*
                 *  int x = "10";   
                    console.WriteLine(x + y); 
                 */
                // the variable x can store just an integer values , but it initialized with a string value "10"
                // the variable y is not declared to use it 

                // the correct code should be:
                int x1 = 10;
                int y1 = 20;
                Console.WriteLine(x + y);
                #endregion

                #region Question_2
                /*
                 * Explain the difference between a runtime error and a logical error with examples
                 */
                // the run time error occurs while the program is executing , for example:
                int nem = 10;
                int den = 0;
                Console.WriteLine(nem / den); // this will cause a runtime error because we can't divide by zero

                //the logical error occurs when the program runs without any errors but is gives an unexpected output, for example:
                // I need to the value of 10 * (5 + 3) which is 80
                int a = 10;
                int b = 5;
                int c = 3;
                Console.WriteLine(a * b + c);//the program will run without any errors but the output will be 53 instead of 80

                #endregion

                #region Problem_3
                /*
                 * Problem: Declare variables using proper naming conventions to store: 
                     Your full name. 
                     Your age. 
                     Your monthly salary. 
                     Whether you are a student. 
                 */
                string FullName = "Zeyad Ali ELazzab Mohamed"; // PascalCase 
                int myAge = 20; // camelCase
                decimal monthly_salary = 1500.50m; // snack case
                bool isStudent = true; // camelCase
                                       // Note : C# does not support kebab case
                #endregion

                #region Question_3
                /*
                 * Question: Why is it important to follow naming conventions such as PascalCase in C#? 
                 */
                // it is important to follow naming conventions becuase it considers a best practice in programming
                // specially when you are working in a team, it helps to make the code more readable and maintainable
                #endregion

                #region Problem_4
                /*
                 Problem: Write a program to demonstrate that changing the value of a reference type affects all 
                 references pointing to that object. 
                 */
                Rectangle rec1 = new Rectangle();
                rec1.leangth = 10;
                rec1.width = 5;
                Rectangle rec2 = rec1; // 2 references point to the same object in the heap
                rec2.leangth = 20;
                Console.WriteLine(rec1.leangth);//20
                #endregion

                #region Question_4
                //Question: Explain the difference between value types and reference types in terms of memory
                //allocation.

                /*
                 1. value type:
                     all the value types are stored in the stack with them actual values
                     and when you assign a value type variable to another variable a copy of the value is created to the
                     new variable
                2. reference type:
                    all the reference types data are stored in the heap , but the stack stores the address of this object in a variable to point to it
                    and when you assign a reference type variable to another variable both variables point to the same object in the heap
                 */
                #endregion

                #region Problem_5
                /*
                 * Problem: Create a program that calculates the following using variables x = 15 and y = 4: 
                    o Sum 
                    o Difference 
                    o Product 
                    o Division result 
                    o Remainder 
                 */
                int x2 = 15, y2 = 4;
                int sum2 = x2 + y2;
                int difference = x2 - y2;
                int product = x2 * y2;
                int divisionResult = x2 / y2;
                int remainder = x2 % y2;
                Console.WriteLine("Sum: " + sum2);
                Console.WriteLine("Difference: " + difference);
                Console.WriteLine("Product: " + product);
                Console.WriteLine("Division Result: " + divisionResult);
                Console.WriteLine("Remainder: " + remainder);
                #endregion

                #region Question_5
                /*
                 * Question: What will be the output of the following code? Explain why: 
                    int a = 2, b = 7; 
                    Console.WriteLine(a % b); 
                 */
                // the output will be 2 because the number 2 is less than 7 OR 2 has no 7 on it
                #endregion

                #region Problem_6
                /*
                 * Problem: Write a program that checks if a given number is both: 
                    o Greater than 10. 
                    o Even.
                 */
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if (number > 10 && number % 2 == 0)
                    Console.WriteLine("The number is greater than 10 and even");
                else
                    Console.WriteLine("Invalid Input");
                #endregion

                #region Question_6
                //Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator? 

                /*
                 1.The Logical AND Operator (&&):
                     the && operator is used to checks two boolean expressions and returns true if both expressions are true and false otherwise
                     and it uses short circuit evaluation ,which means if the first expression is false , then the second one will not be checked
            
                2.The Bitwise AND operator (&):
                    this operator is used to perform a bitwise AND operation between 2 integers
                    and it works with bits not the decimal values , it perform AND operation between each corresponding bits 
                    it does not use short circuit evaluation , which means both expressions will be evaluated till the end of all bits
                 */

                #endregion

                #region Problem_7
                /*
                 * Problem: Implement a program that takes a double input from the user and casts it to an int. 
                    Use both implicit and explicit casting, then print the results.
                 */
                Console.WriteLine("Enter a fractional number");
                double input = double.Parse(Console.ReadLine());
                // explicit casting
                int explicitCast = (int)input;
                Console.WriteLine("Explicit Cast to int: " + explicitCast);
                // implicit casting
                // Note : can not perform an implicit casting from double to int ,but it can be done from int to double
                double implicitCast = explicitCast;
                Console.WriteLine("ImplicitCast Cast to Double: " + implicitCast);
                #endregion

                #region Question_7
                /*
                 * Question: Why is explicit casting required when converting a double to an int?
                 */

                /*
                 * when you need to convert from a larger data type (double) to a smaller one (int),may be you will lose some data which means (over flow)
                 * so the compiler alert you to performing the explicit casting to avoid the data loss
                 */
                #endregion

                #region Problem_8
                /*
                 * Problem: Write a program that: (G01 Bonus, G02 mandatory) 
                    o Prompts the user for their age as a string. 
                    o Converts the string to an integer using Parse 
                    o Checks if the age is valid (e.g., greater than 0).
                 */
                Console.WriteLine("Enter Your Age");
                string Userinput = Console.ReadLine();

                int age = int.Parse(Userinput);
                if (age > 0)
                    Console.WriteLine("Valid Age");
                else
                    Console.WriteLine("Invalid Age");
                #endregion

                #region Question_8
                //Question: What exception might occur if the input is invalid and how can you handle it
                /*
                 * 1.if the input is invalid like non numeric value OR NULL => a FormatException will be occured 
                 * 2.we can handle it by using a try catch block OR by using int.TryParse method which is returns a boolean value means 
                 * if the conversion is successfull or not
                 */
                #endregion

                #region Problem_9
                /*
                 * Problem: Write a program that demonstrates the difference between prefix and postfix 
                    increment operators using a variable x.
                 */
                int x3 = 5;
                Console.WriteLine(x3++);  // will print 5 and x3 will be 6 =>(postfix increment) the increment happens after the value is used
                Console.WriteLine(++x3);  // will print 7 and x3 will be 7 =>(prefix increment) the increment happens before the value is used
            #endregion

            #region Question_9
            /*
             * Question: Given the code below, what is the value of x after execution? Explain why 
                int x = 5; 
                int y = ++x + x++; 
             */

            /*
             * the value of x will be 7 after the execution
             * because ++x means => x = x + 1 , x++ means =>  x = x + 1
             * so the value of x has been incremented 2 times => from 5 to 6 at ++x then from 6 to 7 at x++
             */
            #endregion
            #endregion

            #region Part_2
            #region Question_1
            /*
             * 2- what's the difference between compiled and interpreted languages and in this way what 
                about Csharp? 
            1. Compiled Languages:
                 in compiled languages the source code is translated into machine code by a compiler in an .exe file  on your computer before execution
                 and the resulted machine code is specific to the target operating system OR platform (Platform dependant)
                 examples of compiled languages are C and C++

            2. Interpreted Languages:
                in interpreted languages the source code is translated into machine code line by line by an interpreter at runtime
                and the resulted machine code is not specific to any operating system OR platform (Platform independant)
                examples of interpreted languages are Python and JavaScript

            3. C# Language:
                C# is a hybrid language that uses both compilation and interpretation

                3.1. compilation:
                    the C# source code is first compiled into an intermediate language (IL) by the C# compiler
                    and the result is .exe OR .dll file that contains the IL code ,but not a machine code
                    this IL code is platform independant and can be executed on any operating system 

                3.1. Interpretation:
                    Then the IL code is translated to machine code by the CLR using JIT compilation at runtime to match 
                    the specific operating system and hardware which is running on it

             */


            #endregion

            #region Question_2
            /*
             * 3- Compare between implicit, explicit, Convert and parse casting 
                * 1. Implicit Casting:
                     it is done automatically by the compiler when you assign a value of a smaller data type to a larger one
                     for example: int to double

                * 2. Explicit Casting:
                         it is done manually by the programmer when you assign a value of a larger data type to a smaller one

                * 3. Convert Class:
                     it is a built-in class in C# that provides methods to convert between different data types
                     it can handle null values by setting a default value to the variable which you want to convert to it
                     it is throwing exceptions when the user inputs invalid formats

                * 4. Parse Method:
                     it is a method that belongs to specific data types like int.Parse, double.Parse
                     it converts a string to a number to its corresponding data type
                     it does not handle null values and will throw an exception if the input is null
                     it is throwing exceptions when the user inputs invalid formats
             * 
             */
            #endregion
            #endregion

            #region Part_3_Bonus
            //5- what meant by Csharp is managed code 

            /*
             * managed code means that the CLR is responsible for memory allocation and deallocation 
             * and this is happening automatically
             */
            #endregion
        }
    }
}
