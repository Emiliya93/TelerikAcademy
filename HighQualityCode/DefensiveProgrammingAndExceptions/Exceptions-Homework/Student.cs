using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;

        // Empty list is set by default
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            this.CheckIfNull<string>(value, "First name");

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            this.CheckIfNull<string>(value, "Last name");

            this.lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get
        {
            return new List<Exam>(this.exams);
        }

        set
        {
            if (value == null)
            {
                this.exams = new List<Exam>();
            }
            else
            {
                this.exams = value;
            }
        }
    }

    public IList<ExamResult> CheckExams()
    {
        this.CheckIfNull<IList<Exam>>(this.Exams, "Exams");

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("The student has no exams!");
        }

        IList<ExamResult> results = new List<ExamResult>();

        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        // Cannot calculate average on missing exams
        this.CheckIfNull<IList<Exam>>(this.Exams, "Exams");

        if (this.Exams.Count == 0)
        {
            // No exams
            throw new InvalidOperationException("Cannot calculate average exam result, because no exams are provided!");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();

        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }

    private void CheckIfNull<T>(T value, string name)
    {
        if (value == null)
        {
            throw new ArgumentNullException(name + " cannot be null!");
        }
    }
}
