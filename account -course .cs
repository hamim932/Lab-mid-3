using System;

namespace acount__course
{
    class Program
    {
        static void Main(string[] args)


             public class Account
        {
            private string accName = "Shourav Hasan";
            private string accid = "7017013567";
            private int balance = 0;

            public string AccName
            {
                get
                {
                    return accName;
                }
                set
                {
                    accName = Console.ReadLine();
                }
            }
            public string Acid
            {
                get
                {
                    return accid;
                }
                set
                {
                    accid = Console.ReadLine();
                }
            }

            public int Balance
            {
                get
                {
                    return balance;
                }
                set
                {
                    balance = Convert.ToInt32(Console.ReadLine());
                }
            }

            
            public void Deposit(int amount)
            
             {
                 balance += amount;
            }
             public void WithDraw(int amount)
             {
                balance -= amount;
            }
        }

         public class Course
         {
            private string courseName;
            private string courseCode;
            private int courseCredit;
            public string CourseName
            {
                get
                 {
                    return courseName;
                 }
                set
                 {
                     courseName = Console.ReadLine();
                 }

            }
             public string CourseCode
            {
                get
                {
                     return courseCode;
                }
                set
                {
                    courseCode = Console.ReadLine();
                }

            }
             public int CourseCredit
            {
                get
                {
                     return courseCredit;
                }
                set
                {
                     courseCredit = Convert.ToInt32(Console.ReadLine());
                }

            }

             public void ShowCourseInfo()
            
             {
                Console.WriteLine("Course name   : " + courseName);
                Console.WriteLine("Course code   : " + courseCode);
                Console.WriteLine("Course credit : " + courseCredit);

             }
        }

    }