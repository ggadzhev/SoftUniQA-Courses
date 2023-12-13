
        int studentsCount = int.Parse(Console.ReadLine());

        int topStudents = 0;
        int bScoreStudents = 0;
        int cScoreStudents = 0;
        int failedStudents = 0;
        double totalScore = 0;

        for (int i = 0; i < studentsCount; i++)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.00)
            {
                topStudents++;
            }
            else if (grade >= 4.00)
            {
                bScoreStudents++;
            }
            else if (grade >= 3.00)
            {
                cScoreStudents++;
            }
            else
            {
                failedStudents++;
            }

            totalScore += grade;
        }

        double topStudentsPercentage = (double)topStudents / studentsCount * 100;
        double bScoreStudentsAmount = (double)bScoreStudents / studentsCount * 100;
        double cScoreStudentsAmount = (double)cScoreStudents / studentsCount * 100;
        double failedStudentsAmount = (double)failedStudents / studentsCount * 100;
        double averageScore = totalScore / studentsCount;

        Console.WriteLine($"Top students: {topStudentsPercentage:F2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {bScoreStudentsAmount:F2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {cScoreStudentsAmount:F2}%");
        Console.WriteLine($"Fail: {failedStudentsAmount:F2}%");
        Console.WriteLine($"Average: {averageScore:F2}");
