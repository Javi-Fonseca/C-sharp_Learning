//  https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-final-gpa/
// Project: Calculate Final GPA    2023.12.16
using System;

public class finalGPA {
    public static void Main (string[] args){
        /*  Parameters
              -Give the student's name and class information.

              -Each class has a name, the student's grade and the number
               of credit hours for that class.

              -To calculate the GPA for a course:
                -Multiply the grade value for a course by the number of
                 credit hours for that course.

                -To calculate a student's GPA, you need the total number
                 of credit hours, and the total number of grade points earned.
                  --The grade points earned for a course is equal to the 
                    course credit hours multiplied by the earned grade.

                -Do this for each course, then add these results together.

                -Divide the resulting sum by the total number of credit hours.
           
            Expected output:
            Student: Sophia Johnson

            Course          Grade   Credit Hours	
            English 101         4       3
            Algebra 101         3       3
            Biology 101         3       4
            Computer Science I  3       4
            Psychology 101      4       3

            Final GPA:          3.35
        */
        //Datas
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        /*  Student's grades for each course:
            Course			    Grade		
            English 101		     A
            Algebra 101		     B
            Biology 101		     B
            Computer Science I	 B
            Psychology 101	     A
        */

        //Tip: Use variables for avoid typos
        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        int totalCreditHours = 0;
        totalCreditHours += course1Credit;
        totalCreditHours += course2Credit;
        totalCreditHours += course3Credit;
        totalCreditHours += course4Credit;
        totalCreditHours += course5Credit;

        int totalGradePoints = 0;
        totalGradePoints += (course1Credit * course1Grade);
        totalGradePoints += (course2Credit * course2Grade);
        totalGradePoints += (course3Credit * course3Grade);
        totalGradePoints += (course4Credit * course4Grade);
        totalGradePoints += (course5Credit * course5Grade);

        decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;
        
        //Casting a fractional value will never round up the result.
        int leadingDigit = (int) gradePointAverage;
        int firstDigit = (int)(gradePointAverage * 10) % 10;
        int secondDigit = (int) (gradePointAverage * 100 ) % 10;

        //Outputs
        Console.WriteLine($"Student: {studentName}\n");

        Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

        Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
        Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
        Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
        Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
        Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
        
        Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");

    }
}