using System.Xml.Linq;

namespace DEPI_Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part_1

            #region Program_1
            //1
            int[] arr = new int[3] {11 , 12 , 13};
            //2
            int[] arr2 = {4 , 5 , 6};
            //3
            int[] arr3 = new int[] {7 , 8 , 9};

            //assigning values to array elements
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;// 0 1 2
            }
            //printing the array elements
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // the Index out of range exeption occurs when we try to access an index outside the array size:
            //Console.WriteLine(arr[5]); // this line would throw an exception
            #endregion
            #region Question_1
            //Question: What is the default value assigned to array elements in C#? 
            /*
             * it depends on the data type of the array elements 
             * if the array contains a value type elements , therefore each element will be initialized with its default value :
             * int => 0
             * boolean => false
             * string => null
             * if the array contains a reference type elements , they will be null
             */









            #endregion

            #region program_2
            int[] arr01 = { 1, 2, 3 };
            int[] arr02 = { 4, 5, 6 };

            // shallow copy
            arr01 = arr02;
            arr02[0] = 0;
            Console.WriteLine(arr01[0]);//0

            // deep copy
            // clone returns object
            // the clone task => a new object has been created in the heap & it contains the data of the arr02
            // the assignment operator task => make the reference arr01 point to the object which was created by the clone function
            // therefore we have now an unreachable object in the heap (which was pointed by arr01 before the cloning operation)
            arr01 = (int[])arr02.Clone();
            arr02[1] = 22;
            Console.WriteLine(arr01[1]);//5
            #endregion
            #region Question_2
            //Question: What is the difference between Array.Clone() and Array.Copy()?

            int[] arr03 = { 1, 2, 3 };
            int[] arr04 = { 4, 5, 6 };
            Array.Copy(arr04 , arr03 , 2);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr03[i]);
            }
            Console.WriteLine(arr03.GetHashCode());
            Console.WriteLine(arr04.GetHashCode());

            /*
             * the diffrence between the two methods in the way of coping the data 
             * 
             * Array.Copy() => 
             *      1. it let us to choose the range of the elements we want to copy 
             *      2. it does not creates a new object in the heap , it copy in place
             *      3. it need an existing array to copy in it
             * Array.Clone() => 
             *      1. it does not let us to choose the range of the elements we want to copy 
             *      2. it creates a new object in the heap
             *      3. it does not needs an existing array to copy , because it creates a new object in the heap
             *      
             * the two methods prform a shallow copy when the array contains a reference type elements because the reference will be copied to the second array
             * but if the elements are value type , the value will be copied to the second array normally 
             * 
             */
            #endregion

            #region Program_3
            // creating the 2d array
            int[,] arr2d = new int[3, 3];
            // getting the input from the user
            for(int i = 0; i < 3;i++)
            {
                Console.WriteLine($"enter the grades of student {i+1}: ");
                for (int j = 0; j < 3; )
                {
                    Console.Write($"enter grade {j+1}: ");
                    bool flag = int.TryParse(Console.ReadLine() , out arr2d[i, j]);
                    if (flag)
                        j++;
                }
            }

            // printing the grades
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"grades of student {i + 1}: ");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"grade {j + 1} = {arr2d[i,j]}");
                }
            }

            #endregion
            #region Question_3
            //Question: What is the difference between GetLength() and Length for multi
            //dimensional arrays? 
            /*
             * Length: it returns the total length of the array => the number of all elements of the array
             * GetLength(dimential): it returns the number of elements for a specific dimential
             */

            #endregion

            #region Program_4
            int[] arr05 = { 12, 4, 6, 78, 36 };
            // SORT
            // it sorting the array in ascending order
            //before sorting
            for(int i = 0; i < 5;i++)
            {
                Console.WriteLine(arr05[i]);
            }
            Array.Sort(arr05);
            //after sorting
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr05[i]);
            }

            // REVERSE
            //it reverse the array
            //before reversing
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr05[i]);
            }
            Array.Reverse(arr05);
            //after reversing
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr05[i]);
            }

            // INDEXOF
            //it searchs on a specefic value and returns the first one in the array & returns -1 if the value did not found
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Array.IndexOf(arr05, 78));//4
            }

            // COPY()
            //1.it let us to choose the range of the elements we want to copy
            //2.it does not creates a new object in the heap, it copy in place
            //3.it need an existing array to copy in it

            int[] arr06 = { 100, 200, 300 };
            Array.Copy(arr05, 1, arr06, 0, 3);// Copy(source , start from ,destination , start from , length of elements)

            for(int i = 0; i < arr06.Length;i++)
            {
                Console.WriteLine(arr06[i]);// 6 12 36
            }

            // CLEAR
            Array.Clear(arr05);
            // it delete elements from the array (it assign the default value to the elements you want to delete)
            for (int i = 0; i < arr05.Length; i++)
            {
                Console.WriteLine(arr05[i]);// 0 0 0 0 0
            }
            #endregion
            #region Question_4
            //Question: What is the difference between Array.Copy() and 
            //Array.ConstrainedCopy() ?
            /*
             *  
             *  Copy => if it failed to copy the elements from source to target , it may modifies the target and does not completes the coping operation 
             *  it is un safe if any exeption was thrown
             *  
             *  ConstrainedCopy() => it treats the coping operation as an atomic operation and it must done completly
             *  if any exeption was thrown while the coping , the target array will not be affected
             *  it is more safe than Copy()
             */
            #endregion

            #region Program_5
            int[] arr07 = new int[] { 100 , 200 , 300 , 400 , 500};
            //for
            for(int i = 0; i < arr07.Length; i++)
            {
                Console.WriteLine(arr07[i]);
            }

            //foreach
            foreach(int enumerator in arr07)
            {
                Console.WriteLine(enumerator);
            }

            //while in reverse order
            int counter = arr07.Length-1;
            while(counter >= 0)
            {
                Console.WriteLine(arr07[counter]);
                counter--;
            }
            #endregion
            #region Question_5
            //Question: Why is foreach preferred for read-only operations on arrays?
            /*
             * it designed to make the collection uneditable in its scope
             * because it make a temporary copy from the original data
             * if you want to use a collection in its scope , this collection must implements the IEnumerable interface
             * and this interface has a method called GetEnumerator , and this enumerator is the loop iterator
             * therefore if you want to edit this enumerator , it will be confiused and will not be able to iterate on the collection any more
             */
            #endregion

            #region Program_6
            int positiveOdd;
            bool flag02;
            do
            {
                Console.Write("Enter a positive odd number: ");
                flag02 = int.TryParse(Console.ReadLine(), out positiveOdd);
            }
            while (!flag02 || positiveOdd % 2 != 1);


            #endregion
            #region Question_6
            //Question: Why is input validation important when working with user inputs?
            /*
             * to avoid the famous exeptions like invalid format exeption OR null reference exeption
             */
            #endregion

            #region Program_7
            int[,] arr2d02 = new int [3,3]{  {1 , 2 , 3 } ,
                                             {4 , 5 , 6 } ,
                                             {7 , 8 , 9 } };
            for(int i = 0; i < arr2d02.GetLength(0);i++)
            {
                for (int j = 0; j < arr2d02.GetLength(1); j++)
                {
                    Console.Write($"{arr2d02[i,j]} ");
                }
                Console.WriteLine();
            }
            #endregion
            #region Question_7
            //Question: How can you format the output of a 2D array for better readability? 
            /*
             * 
             */
            #endregion

            #region Program_8
            int month;
            bool flag03;
            do
            {
                Console.WriteLine("Enter a month number: ");
                flag03 = int.TryParse(Console.ReadLine(), out month);
            }
            while (!(flag03 && month < 13 && month > 0));
            
            if(month == 1)
                Console.WriteLine("Jan");
            else if (month == 2)
                Console.WriteLine("Feb");
            else if (month == 3)
                Console.WriteLine("Mar");
            else if (month == 4)
                Console.WriteLine("Apr");
            else if (month == 5)
                Console.WriteLine("May");
            else if (month == 6)
                Console.WriteLine("Jun");
            else if (month == 7)
                Console.WriteLine("Jul");
            else if (month == 8)
                Console.WriteLine("Aug");
            else if (month == 9)
                Console.WriteLine("Sep");
            else if (month == 10)
                Console.WriteLine("Oct");
            else if (month == 11)
                Console.WriteLine("Nov");
            else if (month == 12)
                Console.WriteLine("Dec");
            else
                Console.WriteLine("Invalid month");

            switch (month)
            {
                case 1:
                    Console.WriteLine("Jan");
                    break;
                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("Mar");
                    break;
                case 4:
                    Console.WriteLine("Apr");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Jun");
                    break;
                case 7:
                    Console.WriteLine("Jul");
                    break;
                case 8:
                    Console.WriteLine("Aug");
                    break;
                case 9:
                    Console.WriteLine("Sep");
                    break;
                case 10:
                    Console.WriteLine("Oct");
                    break;
                case 11:
                    Console.WriteLine("Nov");
                    break;
                case 12:
                    Console.WriteLine("Dec");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }

            #endregion
            #region Question_8
            //Question: When should you prefer a switch statement over if-else?
            /*
             * use a switch when comparing a single variable against multiple fixed,
             * discrete values (like enums or constants) for better readability. 
             * It is preferred over if-else for 3 or more conditions because it creates a cleaner, 
             * flatter structure that is easier to scan. Additionally, in many languages, 
             * it offers a performance boost by using jump tables instead of checking every condition linearly
             */
            #endregion

            #region Program_9
            int[] numbers = { 5, 2, 8, 3, 2, 1 };
            int target = 2;

            // 1. Sort the array
            Array.Sort(numbers);

            // 2. search on the valus
            int firstIndex = Array.IndexOf(numbers, target);
            int lastIndex = Array.LastIndexOf(numbers, target);

            Console.WriteLine($"first index of {target}: {firstIndex}");
            Console.WriteLine($"last index of {target}: {lastIndex}");

            #endregion
            #region Question_9
            //Question: What is the time complexity of Array.Sort()?
            /*
             * the time complexity of Sort function is O(nlogn) using the intro sort algorithm
             */
            #endregion

            #region Program_10
            int[] numbers02 = { 10, 20, 30, 40, 50 };
            int sumFor = 0;
            int sumForeach = 0;

            // using for loop
            for (int i = 0; i < numbers02.Length; i++)
            {
                sumFor += numbers02[i];
            }

            // using foreach loop
            foreach (int num in numbers02)
            {
                sumForeach += num;
            }

            Console.WriteLine($"sum (for): {sumFor}");
            Console.WriteLine($"sum (foreach): {sumForeach}");
            #endregion
            #region Question_10
            //Question: Which loop (for or foreach) is more efficient for calculating the sum of an 
            //array, and why?

            /*
             * the (for) loop is more efficient here because it can access the actual index in the memory and does not copy a temporary copy from 
             * the original data 
             * 
             * but i prefer (foreach) because the diffirence between them in the performance can be neglected and it more safe than (for)
             * and in this case we do not need to change any value in tha original array , just summation
             */
            #endregion
            #endregion

            #region Part_2
            int dayNum;
            bool flag04;
            do 
            {
                Console.WriteLine("Enter a number from 1 to 7: ");
                flag04 = int.TryParse(Console.ReadLine(), out dayNum);
            }
            while (!flag04);
            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNum.ToString());
            Console.WriteLine($"using explisit casting: {(DayOfWeek)dayNum}");
            Console.WriteLine($"using Enum.Parse: {day}");

            //3- What happens if the user enters a value outside the range of 1 to 7? 
            /*
             * the entered number will be printed in the console because : 
             * this number may be a combination between two values in the Enum OR can exist in the Enum
             */
            #endregion
        }
    }
}
