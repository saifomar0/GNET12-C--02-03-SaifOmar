namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////ASSIGNMET02///////////////////////////////
            ///

            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //

            //A: They donot affect execution of the program. , we use it in to easly read the code
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example

            #region school 

            string teachers;
            #region
            string shudents;
            #endregion


            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════



            // EXPLICIT DECLARATION 
            // the type is clearly visble 
            int age;
            string name = "saif";
            double gpa = 3.5;

            // IMPLICIT DECLARATION 
            //should be inistilized first
            var agee = 21;
            var namee = "saifOmar";


            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════



            // Constant examples
            const double pi = 3.14;
            //we use constant if we dont want to change the varible value and it must be initialized when declared

            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.

            //Class-Level scope: the varibles declared inside it can be accessed by all methouds inside the class
            //Method-Level Scope (local varibles):the varibles declared inside it can only acced inside the method 
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.

            //block scope means that a variable is only accessible inside the block
            // EX : IF,FOr,While
            // ══════════════════════════════════════════════════════════════════════

            #endregion



            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.

            // local lifetime  destroyed when the block or method scop finshes
            // Static lifetime  destroyed when the program is ended
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //

            // it manges the memory  fro objects
            // it Frees memory when objects are no longer used
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?

            //when a variable declared in an inner scope has the same name as a variable in an outer scope.
            //The inner variable hides (shadows) the outer variable inside its scope.
            //No because C# prevents redeclaring a local variable with the same name in nested blocks.
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            int Age;
            int _age;
            int age1;
            int ageStu;
            // it cannot start with number
            // it cannot have space


            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?

            // Local : CamelCase -->saifOmar
            // Class :PascalCase -- SaifOmar
            //constants : CamelCase or  PascalCase
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.

            // syntax errors,: when the compiler find error like missing semicoulmn (not follw the language rules )
            //  runtime errors : creashes during executian  like if there is array has 3 indexies and i make consoule to index 7
            // logical errors : the console run but the logic is error like if i have a function should returns sum of two numbers but it return a-b

            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?

            // its important because instade of the program creaches and stop it could help me to know where is the error 
            // it Prevents Program Crashes and  Improves User Experience
            // if we dont handle exeption the program stops immediately when an exception occurs.
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            int a = 10, b = 0;

            try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
            //  the finally block executes if the value of b is not zero
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //1- null refrance exeption
            string nameee = null;
            Console.WriteLine(name.Length);
            //2-index out of range
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]);
            //3-divide by zero
            int a = 10, b = 0;
            int result = a / b;
            //4-FormatException
            string input = "abc";
            int numberrrr = int.Parse(input);
            //5-
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.


            //the order matters because the runtime checks them from top to bottom.

            using System;


            static void Main()
            {
                try
                {
                    int a = 10, b = 0;
                    int[] numbers = { 1, 2, 3 };

                    //  throw divide by zero exeption
                    int result = a / b;

                    //index out of range
                    Console.WriteLine(numbers[5]);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot divide by zero" + ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Array index is out of range" + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Some other exception" + ex.Message);
                }
            }


            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            // 

            // Both are used to re-throw an exception but 
            // throw re-throws original exception
            //throw ex   re-throws but stack trace is reset so  lose information about where it originally occurred.
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // Stack :used for storing local variables , last in first out  ,Very fast,Smaller than heap ,stores (int,double,bool)
            //References to objects , cleard when method ends


            // heap:heap is large memory, slower memory used for storing objects and (reference types) cleared by garbage collector
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.


class Person
        {
            public string Name;
        }

        class Program
        {
            static void Main()
            {
                // Value Type Example
                int a = 10;
                int b = a;  // Copy of value
                b = 20;


                Console.WriteLine("a =" + a);  // a is still 10
                Console.WriteLine("b = " + b);  // b is 20

                //  Reference Type Example
                Person person1 = new Person();
                person1.Name = "Saif";

                Person person2 = person1;  // Copies reference
                person2.Name = "Ahmed";    // Changes original object


                Console.WriteLine("person1.Name = " + person1.Name); // Ahmed
                Console.WriteLine("person2.Name = " + person2.Name); // Ahmed
            }
        }

        // ══════════════════════════════════════════════════════════════════════

        #endregion

        #region Question 19: Object in C#
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 19: OBJECT IN C#
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Why is 'object' considered the base type of all types in C#? 
        //    What methods does every type inherit from System.Object?

        //   All types (int, struct) or reference types (class, string) inherit from object

        // this allows C# to treat any type as an object if needed, enabling polymorphism and general-purpose programming.
        //
        // ══════════════════════════════════════════════════════════════════════

        #endregion



        ///////////////////// ASSIGNMENT03////////////////////
        ///

        #region Question01
        ///////////////////////
        //double d = 9.99;
        //int x = (int)d;
        //Console.WriteLine(x);
        /////////////////////////////////////////////
        //the output will be 9  because we have assigned the in  x to be int od d value
        // 9.99 --> 9
        #endregion

        #region Question02
        //////////////////////////////
        //int n = 5;
        //double d2 = n / 2;
        //Console.WriteLine(d2);
        //it compiles  but it will return int because n   is intger
        #endregion

        #region Question03
        /////////////////////////////////////
        //Console.Write("Enter Youe age :"  );
        //int age =int.Parse(Console.ReadLine());
        //Console.WriteLine("Age is: " + age);
        #endregion

        #region Question04
        ////////////////////////
        //string s = "12a";
        //int x = int.Parse(s);
        //Console.WriteLine(x);
        // Crash Run Time  
        //int.parse expected number in string format only and we have 'a' in the string

        #endregion


        #region Question05
        //string s = "12a";

        //if (int.TryParse(s, out int x))
        //{
        //    Console.WriteLine(x);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid");
        //}

        #endregion

        #region Question06
        ////////////////////
        //object o = 10;
        //int a = (int)o;
        //Console.WriteLine(a + 1);

        //10 is boxed into object
        //unboxed to int then increment by one
        #endregion

        #region Question07
        //////////////////////////////
        //object o = 10;
        //long x = (long)o;
        //Console.WriteLine(x);

        //Unhandled exception.
        // 10 i boxed into int not as long
        // we cannot unbox it as long
        #endregion


        #region Question08
        //object o = 10;

        //long x = -1;

        //if (o is int i)
        //{
        //    x = i;    
        //}

        //Console.WriteLine(x);

        #endregion

        #region Question09

        //string? name = null;
        //Console.WriteLine(name?.Length);

        // name is nullable its value is null so length is 0
        #endregion

        #region Question10

        //string? name2 = null;
        //int length = name2?.Length ?? 0;

        //since name2 is null so it dosent access length
        #endregion

        #region Question11

        //string? s = null;
        //int x = int.Parse(s ?? "0");
        //Console.WriteLine(x);

        //it might fail if  s contains a non-numeric string
        //it avoids null so it does not prevent invalid format exceptions

        // safe code

        //string? s = null;
        //int x;

        //if (!int.TryParse(s, out x))
        //{
        //    x = 0;  
        //}

        //Console.WriteLine(x);



        #endregion



        #region Question12

        //string? s = null;
        //Console.WriteLine(s!.Length);


        //Unhandled exception.
        // s is null and the ! tells the compiler is not null


        #endregion

        #region Question13

        //string? s = null;
        //int x = Convert.ToInt32(s);
        //Console.WriteLine(x);

        //s is null
        //Convert.ToInt32(s)  returns 0
        //x becomes 0


        #endregion

        #region Question14

        //string? s = null;
        ////A
        // int a = int.Parse(s);
        ////B
        //int b = Convert.ToInt32(s);
        //Console.WriteLine(b);

        //Unhandled exception
        //A :  Passing null -> throws an exception
        //B:   Convert.ToInt32 can handle null    return 0 if input is null

        #endregion

        #region Question15

        //string? user = null;
        //string? user2 = "saif";
        //Console.WriteLine((user ?? "Geust").ToUpper());
        //Console.WriteLine((user2 ?? "Geust").ToUpper());



        #endregion


    }
}
}
