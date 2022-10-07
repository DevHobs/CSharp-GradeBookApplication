using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count() > 25) { Console.WriteLine("A")} else;
            if (Students.Count() > 20) { } else Console.WriteLine("B");
            if (Students.Count() > 15) { } else Console.WriteLine("C");
            if (Students.Count() > 10) { } else Console.WriteLine("D");
            if (Students.Count() > 5) { } else Console.WriteLine("F");
            {
                InvalidOperationException invalidOperationException = new InvalidOperationException;
                throw invalidOperationException;
            }
        }
    }
}

