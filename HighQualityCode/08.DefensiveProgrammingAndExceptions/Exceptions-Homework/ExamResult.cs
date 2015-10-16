using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            this.CheckIfLessThanZero(value, "Grade");

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            this.CheckIfLessThanZero(value, "Min grade");

            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade; 
        }

        private set
        {
            this.CheckIfLessThanZero(value, "Max grade");

            if (value <= this.minGrade)
            {
                throw new ArgumentOutOfRangeException("Maximum grade cannot be less than minimum grade.");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Comments cannot be null or empty!");
            }

            this.comments = value;
        }
    }

    private void CheckIfLessThanZero(int value, string name)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(name + " cannot be less than zero!");
        }
    }
}