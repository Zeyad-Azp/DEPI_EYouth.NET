using System.Text;

namespace DEPI_Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part_1

            #region Program_1
            Console.Write("Enter a text: ");
            string txt = Console.ReadLine();
            //using int.parse
            try
            {
                int number = int.Parse(txt);
            }
            // the try block may throw a format OR NULL reference exception
            catch (Exception)
            {
                Console.WriteLine("The entered text is not a valid number OR Empty input");
            }
            //using int.convert.toint32
            try
            {
                int number = Convert.ToInt32(txt);
            }
            // the try block may throw a format exception ,but can handle null reference exception
            catch (Exception)
            {
                Console.WriteLine("The entered text is not a valid number");
            }
            #endregion
            #region Question_1
            //Question: What is the difference between int.Parse and Convert.ToInt32 when 
            //handling null inputs ?

            /*
             * 1. int.Parse throws a NullReferenceException when the input is null
             * 2. Convert.ToInt32 returns 0 when the input is null
             */
            #endregion


            #region Program_2
            Console.Write("Enter a number: ");
            int number1;
            bool valid = int.TryParse(Console.ReadLine() , out number1);

            if (valid)
                Console.WriteLine($"You entered the number: {number1}");
            else
                Console.WriteLine("The entered input is not a valid number");


            #endregion
            #region Question_2
            // Question: Why is TryParse recommended over Parse in user-facing applications? 
            /*
             * because TryParse does not throw an exception when the input is invalid,
             * and instead returns a boolean flag whether the parsing was successful or not
             */
            #endregion


            #region Program_3
            object obj = new object();

            //string
            obj = "string";
            Console.WriteLine(obj.GetHashCode()); 

            //int
            obj = 123;
            Console.WriteLine(obj.GetHashCode());

            //double
            obj = 12.34;
            Console.WriteLine(obj.GetHashCode());
            #endregion
            #region Question_3
            // Question: Explain the real purpose of the GetHashCode() method 
            /*
             * GetHashCode is used to generate a unique id for the object
             * which can be used for fast data lookup in hash collections like 
             * dictionaries and hash set
             */
            #endregion


            #region Program_4
            object obj1 = 2020;
            object obj2 = obj1;

            obj2 = 2026;
            Console.WriteLine(obj1);//2026
            #endregion
            #region Question_4
            // Question: What is the significance of reference equality in .NET? 
            /**
             * reference equality means that two object references point to the same location in memory
             * in .NET the reference equality is significant because 
             * it determines if there are two variables refer to the same object 
             * and this is important for understanding how objects are managed in memory
             */

            #endregion


            #region Program_5
            string str1 = "Hello";
            Console.WriteLine(str1.GetHashCode());
            str1 += "Hi Willy";
            Console.WriteLine(str1.GetHashCode());
            // different hash codes
            #endregion
            #region Question_5
            // Question: Why string is immutable in C# ? 
            /*
             * because it has been implemented base on the array data structure which is immutable and has 
             * a fixed size in memory
             */
            #endregion


            #region Program_6
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb.GetHashCode());
            sb.Append("Hi Willy");
            Console.WriteLine(sb.GetHashCode());
            //the same hash codes
            #endregion
            #region Question_6
            // Question: How does StringBuilder address the inefficiencies of string concatenation? 
            /*
             * the string builder can modify the existing string in memory without creating a new object
             * because it implemented based on a linked list data structure which is more daynamic than array
             */
            #endregion
      

            #region Question_7
            // Question: Why is StringBuilder faster for large-scale string modifications? 
            /*
             * because it does not create a new object in memory for each modification
             * but it modifies the existing object in memory
             * because it implemented based on a linked list data structure which is more daynamic than array
             */
            #endregion


            #region Program_7
            int num1, num2;
            Console.Write("Enter the first number: ");
            bool isvalid = int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter the second number: ");
            bool isvalid2 = int.TryParse(Console.ReadLine(), out num2);

            // + operator
            Console.WriteLine("The summation is: " + num1 + num2);

            // string.format method
            Console.WriteLine(string.Format("The summation is: {0} + {1}") , num1 , num2);

            // string interpolation
            Console.WriteLine($"The summation is: {num1 + num2}");
            #endregion
            #region Question_8
            // Question: Which string formatting method is most used and why? 
            /*
             * string interpolation is the most used method because it is more readable and easier to use
             * and it is more efficient than the other methods because it does not create a new objects in memory
             */

            #endregion


            #region Program_8
            StringBuilder sb1 = new StringBuilder("Hello , My Name Is Zeyad");
            //Append
            sb1.Append(" Azzab");

            //Replace sub string
            sb1.Replace("Hello" , "Hi");

            // Insert a string at a specific position.
            sb1.Insert(0 , "greeting: ");

            // Remove a portion of text.
            //remove "greeting: "
            sb.Remove(0 , 9);

            #endregion
            #region Question_9
            // Question: Explain how StringBuilder is designed to handle frequent modifications compared to strings. 
            /*
             * stringbuilder is designed to handle frequent modifications by using a linked list data structure
             * which allows for dynamic memory allocation and deallocation without the need to create new objects in memory
             */

            #endregion
            #endregion

            #region Part_2
            /*
             * 1.what is Enum data type, when is it used? And name three common built_in enums used frequently?
             *      the enum data type is a value type that represents a set of constants with specific names
             *      we use when we want to define a set of related constants that have specific names
             *      we use it when we treat with a numeric values that have specific meanings
             
                
               2. what are scenarios to use  string Vs StringBuilder? 
                    use string when:
                         the string is small and does not change frequently
                         when you need to perform simple operations like concatenation or comparison
                    use StringBuilder when:
                         the string is large and changes frequently
                         when you need to perform complex operations like insertion, deletion, or replacement

             */
            #endregion

            #region Part_3_Bonus
            /*
                1. what meant by user defined constructor and its role in initialization ?

                    the user defined constructor is a special method that is called when an object of a class is created
                    and its role is to initialize the object's properties and fields with specific values

                2. compare between Array and Linked List
                    array:
                        is a fixed size data structure that stores elements in contiguous memory locations
                        and allows for fast access to elements using an index
                        and used when the number of elements is known before and does not change frequently
                        it is more efficient in terms of memory usage and access speed and search    

                    linked list:
                        is a dynamic size data structure that stores elements in non contiguous memory locations
                        and allows for fast insertion and deletion of elements
                        and used when the number of elements is not known before and changes frequently
                        it is more efficient in terms of insertion and deletion speed
             */
            #endregion
        }
    }
}
