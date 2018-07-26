using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //var studentGrades = new int[10];
            //studentGrades[0] = 80;
            //studentGrades[1] = 77;

            //var studentGrades = new int[10] {80, 77, 45, 87, 53, 43, 67, 88, 99, 100};
            var studentGrades = new int[] { 80, 77, 45, 87, 53, 43, 67, 88};
            Console.WriteLine(studentGrades[4]);

            for (int i = 0; i < studentGrades.Length; i++) {
                Console.WriteLine(studentGrades[i]);
            }

            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
        }
    }
}
