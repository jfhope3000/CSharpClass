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
            // MyOtherLesson8Examples();
            // MyLesson9Examples();
            // MyLesson10Examples();
            // MyLesson11Examples();
            MyBeerSong();
        } // End Method Main

        static void MyBeerSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            Console.WriteLine(beer.LetsSing());
        }

        static void MyLesson11Examples()
        {
            Lesson11 myEleven = new Lesson11("Happy", 42);
            Lesson11 myOtherEleven = new Lesson11(22);
            Lesson11 myLesson11 = new Lesson11();

            Lesson11struct myStruct = new Lesson11struct(9.99m, "Philip K. Dick", "The Man in the High Castle");
            int myValue = 14;
            myEleven.MyBasicRefExample(ref myValue);
            Console.WriteLine(myValue + " from program");

            string first, last;
            myLesson11.MyBasicOutExample("Charlie Brown", out first, out last);
            Console.WriteLine(first);
            Console.WriteLine(last);

        } // end method my lesson 11 examples


        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10();
            myTen.BasicPublicMethod();
            Lesson5 myFive = new Lesson5();
            myFive._myLongValue = 12345L; // can see because internal

        } // end lesson 10 examples
        static void MyLesson9Examples()
            {
                Lesson9 myNine = new Lesson9();
                myNine.BasicArray();
                myNine.MultiArraySample();
                myNine.My3DArrayExample();
                myNine.MyJaggedArrayExample();

            } // end method my lesson 9 examples

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
