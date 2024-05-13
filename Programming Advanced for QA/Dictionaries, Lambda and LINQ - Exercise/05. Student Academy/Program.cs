var studentsGrades = new Dictionary<string, List<double>>();

int studentsGradesCount = int.Parse(Console.ReadLine());

for (int i = 0; i < studentsGradesCount; i++)
{
    string studentName = Console.ReadLine();
    double grades = double.Parse(Console.ReadLine());

    if (studentsGrades.ContainsKey(studentName))
    {
        studentsGrades[studentName].Add(grades);
    }
    else
    {
        studentsGrades.Add(studentName, new List<double> { grades });
    }


}

foreach (var pairs in studentsGrades)
{
    string student = pairs.Key;
    double avgGrade = pairs.Value.Average();

    if (avgGrade >= 4.50)
    {
        Console.WriteLine($"{student} -> {avgGrade:F2}");
    }
}
