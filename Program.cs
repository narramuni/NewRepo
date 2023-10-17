using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsClassA, studentsClassB;

            studentsClassA = new string[10] { "Sai", "Pavan", "Kalyan", "SaiPavan", "Tharun", "Praveen", "Kumar", "Vinay", "Srinu", "Kishore" };
            studentsClassB = new string[10] { "Vinay", "Varun", "Vamsi", "Vinith", "Vishnu", "Venky", "Venkat", "dinesh", "Manu", "Naveen" };

            string[] subjects = new string[6];
            subjects[0] = "Math";
            subjects[1] = "Science";
            subjects[2] = "History";
            subjects[3] = "English";
            subjects[4] = "Art";
            subjects[5] = "Physical Education";

            int[] marks = new int[6];
            marks[0] = 95;
            marks[1] = 88;
            marks[2] = 76;
            marks[3] = 89;
            marks[4] = 94;
            marks[5] = 90;

            Console.WriteLine("Students of Class A:");
            foreach (string student in studentsClassA)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Students of Class B:");
            foreach (string student in studentsClassB)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Marks of Kamal:");
            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i] + " = " + marks[i]);
            }
            Console.WriteLine("TOTAL = " + total + "/600 = " + (total * 100 / 600) + " percent");

            Console.ReadLine();
        }
    }
}
    