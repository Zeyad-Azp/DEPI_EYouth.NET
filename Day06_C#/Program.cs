namespace DEPI_Day06
{
    internal struct Point
    {
        #region Program_1
        public int x;
        public int y;
        // parameterless
        public Point() { }
        // parametarized
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public override string ToString()
        {
            return $" ({x} , {y}) ";
        }
        #endregion
        #region Question_1
        //Question: Why can't a struct inherit from another struct or class in C#?
        /*
         * because the struct is designed as a value type which means that it will be allocated in the stack
         * which means that it will have a fixed size , if it can be inherit from struct or a class : 
         * 1. inherited struct can have more fields or methods which will change the size of the struct
         * 2. each struct will have a method table to determine which method will be called , so this will violate the value type objects
         * which is faster than the reference type
         */
        #endregion
    }
    public class TypeA
    {
        private protected int F;
        internal protected int G;
        public int H;
    }
    public struct Point1
    {
        #region Program_4
        int x;
        int y;
        public Point1(int _x) : this(_x, 0)
        {
            //x = _x;
            //y = 0;
        }
        public Point1(int _x, int _y)
        {
            x = _x;
            y = _y;
        } 
        #endregion
    }
    public struct Employee
    {
        #region Attributes
        int EmpId;
        string name;
        decimal salary;
        #endregion
        #region Getter&Setter
        public string Get_Name()
        {
            return name;
        }
        public void Set_Name(string value)
        {
            name = value;
        } 
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // PART_1
            #region Program_2
            TypeA T = new TypeA();
            //T.F = 10; F is accessable only in the TypeA class
            T.G = 10; // G is accessable only in the project
            T.H = 10; // H is accessable in all
            #endregion
            #region Question_2
            //Question: How do access modifiers impact the scope and visibility of a class member?
            /*
             * we have 6 access modifiers in C# and all of them can be applied on the class member
             * 1. private
             * 2. public
             * 3. protected
             * 4. internal
             * 5. private protected
             * 6. internal protected
             */
            #endregion

            #region Program_3
            Employee e = new Employee();
            e.Set_Name("Zeyad");
            Console.WriteLine(e.Get_Name());
            #endregion
            #region Question_3
            // Question: Why is encapsulation critical in software design?  
            // 1.with this set method I can check the user input and make him enter a specific value as I need
            // 2.the class attributs are in safe because they are all private (not accessable)
            // 3.the code is maintainable & scalable
            // 4. if I need to change the name of any attribute in the class , I will modify in this class only
            #endregion

            #region Program_4
            //in this case I used the parameterless ctor which its task to initialize the attributes with thier default value
            Point1 p1 = new Point1();
            // in this case I used the ctor which its task to initialize x to a value & y to 0
            Point1 p2 = new Point1(10);
            // in this case I used the ctor which its task to initialize x to a value & y to value
            Point1 p3 = new Point1(10 , 10);

            #endregion
            #region Question_4
            // Question: what is constructors in structs?  
            /*
             * the constructor in the struct is a special method its task is to initialize the attributes
             * of the struct instance whatever it is a parameterless(in this case it will initialize with default values)
             * or parametarized (in this case it will initialize with specific values)
             */
            #endregion

            #region Program_5
            Point p01 = new Point(1 , 2);
            Console.WriteLine(p01);
            Point p02 = new Point(3 , 4);
            Console.WriteLine(p02);
            Point p03 = new Point(5, 6);
            Console.WriteLine(p03);
            #endregion
            #region Question_5
            // Question: How does overriding methods like ToString() improve code readability?  
            /*
             * because it is let us to make a string representation of any class
             */
            #endregion

            #region Program_6
            Employee e01 = new Employee();
            Point p04 = new Point();
            changeRef(e01);
            changeVal(p04);
            #endregion
            #region Question_6
            // Question: How does memory allocation differ for structs and classes in C#? 
            /*
             * Class : 
             * 1. the class is a reference type , therefore it will be allocated at the heap
             * 2. but there is a reference at the stack points to the allocated object at the heap
             * 
             * Struct :
             * 1. the struct is a value type , therefore it will be allocated at the stack
             * 2. but it is faster than the class because it is in the stack
             */
            #endregion

            // PART_2
            #region Question_1
            //What is copy constructor? 
            /*
             * the copt constructor is a regular constructor but when you define it you must make it takes
             * an object as a parameter to copy its data to the object who called the constructor
             * which means (deep copy) , because if I made this : obj1 = obj2
             * this will make the 2 references point to the same object (obj2)
             */
            #endregion
            #region Question_2
            /*
             * public : The member can be accessed by any other code
             * private : The type or member can be accessed only by code in the same scope
             * protected : The member can be accessed only by code in the same class or in a class that is inherited from that class
             * internal : The member can be accessed by any code in the same project
             * protected internal : The member can be accessed by any code in the project OR from an inherited class in another project
             * private internal : The member can be accessed by inherited from the class that are declared within its project
             * 
             */
            #endregion
        }
        //functions of program 6
        #region Program_6
        public static void changeRef(Employee e)
        {
            // the reference e which is in the function contains the reference of the e01
            // so , the 2 references points to the same object
            // so , if I modified on the object which the e reference points to , the object which the e01 reference points to will change
            // therefore , the reference type (class) is passed to the methods by reference
            e.Set_Name("mohy_elsharkawy");
            // (in main function) Console.WriteLine(e01.Get_Name()); => this will print mohy_elsharkawy
        }
        public static void changeVal(Point p)
        {
            // the instance P which is in the function scope it is a copy of the passed instance with its all values
            // so each one of the 2 instance are independant & one is a copy from the another
            p.x = 555;
            // it will not affect on the value of p04.x
            // therefore , the value type (struct) is passed to the methods by value
        }
        #endregion
    }
}
