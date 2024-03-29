using System;

namespace CSharpClass.Lessons
{
    /* This class goes over content for the Lesson 8
    Control Flow Statements */
    public class Lesson8
    {
        // Basic if statement
        public void BasicIfStatement()
        {
            int value = 17;
            Console.WriteLine("Before if statement");
            if(value > 15)
            {
                Console.WriteLine("Statement was valid");
            } // end if
            Console.WriteLine("After if statement");
        } // end method basic if statement

        // Basic if/else statement
        public void BasicIfElseExample()
        {
            int value = 12;
            Console.WriteLine("Before if statement");
            if(value >= 15)
            {
                Console.WriteLine("Statement was valid");
            } // end if
            else
            {
                Console.WriteLine("Statement was not valid");
            } // end else
            Console.WriteLine("After if else statement");
        } // end method basic if else example

        // Basic if/else chain
        public void BasicIfElseChainExample()
        {
            int value = 18;
            Console.WriteLine("Before if");
            if(value ==  15)
            {
                Console.WriteLine("Statement was valid 15");
            } // end if
            else if(value == 18)
            {
                Console.WriteLine("Statement was valid 18");
            } // end else if
            else {
                Console.WriteLine("Statement was valid");
            }
            Console.WriteLine("Statement was valid");
        } // end method basic if else chain example

        // This method uses the && operator
        public string BasicAndConditionExample()
        {
            int value = 18;
            Console.WriteLine("Before if statement");
            if(value > 15 && value < 30)
            {
                return "Statement was valid";
            } // end if
            else
                return"Statement was not valid";
        } // end basic and condition example

        // This method uses the || (OR) operator
        public int BasicOrConditionExample(int able)
        {
            Console.WriteLine("Before If statement");
            if(able == 12 || able > 13)
            {
                return able;
            } // end if
            else
            {
                return 0;
            }
        } // end method basic or condition example

        // this method shows a shortcut if statement called the ternary operator
        public void BasicTernaryOperatorExample(int beta)
        {
            string valid = beta > 30 ? "valid" : "not valid";
            Console.WriteLine(valid);
        } // end method basic ternary operator example

        // This method shows a basic switch statement
        public void BasicSwitchExmple(int charlie)
        {
            switch(charlie)
            {
                case 1:
                case 2:
                    Console.WriteLine("1 or 2 was chosen");
                    break;
                case 3:
                    Console.WriteLine("3 was chosen");
                    break;
                case 4:
                    Console.WriteLine("4 was chosen");
                    break;
                case 5:
                    Console.WriteLine("5 was chosen");
                    break;
                default:
                    Console.WriteLine("The number was greater than 5");
                    break;
            } // end switch
        } // end method basic switch statement

        // This method shows a basic while loop
        public void BasicWhileLoop()
        {
            int value = 0;
            while(value < 15)
            {
                Console.WriteLine("number = {0}", value);
                value++;
                
            } // end while
        } // end method basic while loop

        // This method shows a basic do while loop

        public void BasicDoWhileLoopExample()
        {
            int value = 0;
            do
            {
                Console.WriteLine("Do While Number = {0}", value);
                value++;
            } while (value < 12);

        } // end method basic do while loop example

        /*
        
        
        out of class
        







        code example missed






        
         */

        // end method basic foreach loop example

        // The method shows different jump statements
        public string BasicJumpStatementExample(string day)
        {
            switch (day)
            {
                case "Sunday":
                goto default;
                case "Monday":
                case "Tuesday":
                    return "Test something monday or tuesday";
                default:
                    return "Test Nothing";
            }
        } // end method basic jump statement example

        // This method shows other jump statements
        public void BasicOtherJumpStatements()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 2)
                {
                    continue;
                } // end if
                if(i == 4)
                {
                    Console.WriteLine("loop breaks");
                    break;
                } // end if
                Console.WriteLine(i);
            } // end for
            Console.WriteLine("End of loop");
        } // end method basic other jump statements





    } // end class
} // end namespace