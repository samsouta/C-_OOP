using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        const int totalStudents = 5;

        List<string> names = new List<string>();
        List<int> marks = new List<int>();
        List<char> grades = new List<char>();

        int inputCol = 0;    
        int reportCol = 50;   

        for (int i = 0; i < totalStudents; i++)
        {
            Console.SetCursorPosition(inputCol, i * 3);
            Console.Write("Enter Student Name  : ->  ");
            string name = Console.ReadLine();

            Console.SetCursorPosition(inputCol, i * 3 + 1);
            Console.Write("Enter Student Mark : ->  ");
            int mark = int.Parse(Console.ReadLine());

            names.Add(name);
            marks.Add(mark);
            grades.Add(GetGrade(mark));
        }

        
        int row = 0;

        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("EXAMINATION REPORT");

        row++;
        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("NO.    STUDENT NAME       MARK   GRADE");

        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("--------------------------------------");

        for (int i = 0; i < totalStudents; i++)
        {
            Console.SetCursorPosition(reportCol, row);
            Console.WriteLine(
                string.Format("{0,-5} {1,-18} {2,-6} {3}",
                i + 1,
                names[i].ToUpper(),
                marks[i],
                grades[i])
            );
            row += 2; 
        }

        double average = marks.Average();
        int min = marks.Min();
        int max = marks.Max();

        int countA = grades.Count(g => g == 'A');
        int countB = grades.Count(g => g == 'B');
        int countC = grades.Count(g => g == 'C');
        int countF = grades.Count(g => g == 'F');

        row++;
        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("Average Mark : " + average.ToString("0.00"));

        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("Minimum Mark : " + min);

        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("Maximum Mark : " + max);

        row++;
        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("GRADE STATISTICS");

        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("A : " + countA);

        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("B : " + countB);

        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("C : " + countC);

        Console.SetCursorPosition(reportCol, row++);
        Console.WriteLine("F : " + countF);

        Console.ReadKey();
    }

    static char GetGrade(int mark)
    {
        if (mark >= 85) return 'A';
        if (mark >= 70) return 'B';
        if (mark >= 55) return 'C';
        return 'F';
    }
}
