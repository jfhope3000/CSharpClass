using System;

/* This struct is part of Lesson 11 */
namespace CSharpClass.Lessons
{
        public struct Lesson11struct
    {
        private decimal _price;

        private string _author;

        private string _title;

        public Lesson11struct(decimal price, string author, string title)
        {
            _price = price;
            _author = author; 
            _title = title;

            Console.WriteLine("The title {0} from {1} costs ${2}",
            title, author, price);
        } // 
    } // end lesson 11 struct
} // end namespace