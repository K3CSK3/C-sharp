List<Student> students = new List<Student>
{
    new Student("Hetfo Henrik",10,154),
    new Student("Kedd Kinga",13,250),
    new Student("Szerda Szilárd",9,98),
    new Student("Csütörtök Csongot",11,198),
    new Student("Péntek Petra",13,245),
    new Student("Szombat Szimonetta",10,152),
    new Student("Vasárnap Virág",13,221)
};

int maxPoints = students.Max(x => x.Points);
Student bestStudent = students.MaxBy(x => x.Points);

int minPoints = students.Min(s => s.Points);
Student worstStudent = students.MinBy(x => x.Points);


List<string> studentNames = students.Select(x => x.Name).ToList();


List<string> studentNamesWithMoreThan200Points = students.Where(x => x.Points > 200).Select(x => x.Name).ToList();


List<string> orderedStudentsName = students.OrderBy(x => x.Name)
                                           .Select(x => x.Name)
                                           .ToList();


List<string> orderedStudentsNameAndPoints = students.OrderBy(s => s.Name)
                                                    .ThenByDescending(s =>s.Points)
                                                    .Select(s => s.Name)
                                                    .ToList();


List<string> orderedStudentsByGrade = students.OrderByDescending(s => s.Grade)
                                              .ThenByDescending(s => s.Points)
                                              .Select(s => s.Name)
                                              .ToList();


List<GradeAndPoints> gradeWithPoints = students.GroupBy(s =>s.Grade)
                                                .Select(s => new GradeAndPoints
                                                { 
                                                    Grade = s.Key,
                                                    SumOfPoints = s.Sum(s => s.Points)
                                                })
                                                .OrderByDescending(s => s.SumOfPoints)
                                                .ToList();


List<int> distinctPoints = students.Select(s => s.Points)
                                     .Distinct()
                                     .ToList();


List<int> distinctPoints2 = students.DistinctBy(s => s.Points)
                                      .Select(s => s.Points)              
                                     .ToList();