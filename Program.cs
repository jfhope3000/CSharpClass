﻿using System;
using CSharpClass.Lessons;

namespace CSharpClass
{
    /* This class is the start of my applications.
    Lesson 3 - My First Application */
    class Program
    {
        static void Main(string[] args)
        {   
            // Console.WriteLine("Hello World!");
            // MyLesson5Examples();
            // MyLesson6Examples();
            // MyLesson7Examples();
            // MyLesson8Examples();
            MyOtherLesson8Examples();
        } // End Method Main

        static void MyOtherLesson8Examples()
        {
            Lesson8 myLesson8 = new Lesson8();
            myLesson8.BasicWhileLoop();
            myLesson8.BasicDoWhileLoopExample();
            Console.WriteLine(myLesson8.BasicJumpStatementExample("Sunday"));
            myLesson8.BasicOtherJumpStatements();
            
        } // end method my other lesson 8 examples
        static void MyLesson8Examples()
        {
            Lesson8 myEight = new Lesson8();
            myEight.BasicIfStatement();
            myEight.BasicIfElseExample();
            myEight.BasicIfElseChainExample();
            Console.WriteLine(myEight.BasicAndConditionExample());
            Console.WriteLine(myEight.BasicOrConditionExample(24));
            myEight.BasicTernaryOperatorExample(42);
            myEight.BasicSwitchExmple(4);

        } // end method my lesson 8 examples
        static void MyLesson7Examples()
        {
            Lesson7 mySeven = new Lesson7();
            mySeven.BasicMath();
            mySeven.BasicModulus();
            mySeven.MyCheckOperator1();
            mySeven.MyCheckOperator2();
            mySeven.MyLeftShiftOperator();
            mySeven.MyRightShiftOperator();
            mySeven.MyAndAssignmentOperator();
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXOrAssignmentOperator();
            mySeven.MyIncrementDecrementExample();

        } // end method my lesson 7 examples

        static void MyLesson6Examples()
        {
            Lesson6 mySix = new Lesson6();
            mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.MyLowerUpperExample();
            mySix.MyStringLength();
            string myJoined = mySix.MyJoinedStrings("Happy", "Coding");
            Console.WriteLine(myJoined);
            string myFav = mySix.MyStringBuilder("spaghetti", 8);
            Console.WriteLine(myFav);
            mySix.MyExampleChar();
            mySix.MyEscapeExample();
            mySix.MyPlaceHolderExample("Black Tiger", "bomb");

        } // end method my lesson 6 examples

        static void MyLesson5Examples()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();
        } // end method my lessons 5 examples

    } // end class
} // end namespace    
