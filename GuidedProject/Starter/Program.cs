using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;


    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;
    
    //int sumAssigmentScores = 0;

    decimal currentStudentGrade = 0; ;

    int gradedAssignments = 0;

    int examSume = 0;

    int extraCreditSum = 0;

    decimal currentOverallGrade = 0;

    decimal currentExtraCredit = 0;

    int extraCreditCount = 0;

    foreach (int score in studentScores)
    {

        gradedAssignments += 1;
          
        if (gradedAssignments <= 5)

            examSume += score;
    
        if (gradedAssignments > 5)
        {
            extraCreditSum += score;
            extraCreditCount += 1;
        }
    }

    currentStudentGrade = (decimal)examSume / examAssignments;
    currentOverallGrade = examSume + (decimal)extraCreditSum / 10;
    currentOverallGrade /= examAssignments;
    currentExtraCredit = currentOverallGrade - currentStudentGrade;
    decimal extraCreditAverage = extraCreditCount > 0 ? (decimal)extraCreditSum / extraCreditCount : 0;

    if (currentOverallGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentOverallGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentOverallGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentOverallGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentOverallGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentOverallGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentOverallGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentOverallGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentOverallGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentOverallGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentOverallGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentOverallGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentOverallGrade}\t{currentStudentLetterGrade}\t{extraCreditAverage} ({currentExtraCredit} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
