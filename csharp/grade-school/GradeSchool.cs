using System;
using System.Linq;
using System.Collections.Generic;

public class GradeSchool
{
    private readonly IDictionary<string, int> students;

    public GradeSchool()
    {
        students = new Dictionary<string, int>();
    }
    public void Add(string student, int grade) => students.Add(student, grade);

    public IEnumerable<string> Roster() => students.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToList();

    public IEnumerable<string> Grade(int grade) => students.Where(x => x.Value == grade).OrderBy(x => x.Key).Select(x => x.Key).ToList();
}